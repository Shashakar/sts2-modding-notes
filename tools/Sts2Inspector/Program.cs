using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

var parsed = Args.Parse(args);

if (string.IsNullOrWhiteSpace(parsed.AssemblyPath))
{
    Console.Error.WriteLine("Missing --assembly <path>");
    return 1;
}

if (!File.Exists(parsed.AssemblyPath))
{
    Console.Error.WriteLine($"Assembly not found: {parsed.AssemblyPath}");
    return 1;
}

using var metadataContext = CreateMetadataLoadContext(parsed.AssemblyPath);
var assembly = metadataContext.LoadFromAssemblyPath(Path.GetFullPath(parsed.AssemblyPath));
var types = SafeGetTypes(assembly);

switch (parsed.Command)
{
    case "types":
        Require(parsed.CommandArgs.Count >= 1, "Usage: types <keyword>");
        PrintTypes(types, parsed.CommandArgs[0]);
        break;

    case "methods":
        Require(parsed.CommandArgs.Count >= 1, "Usage: methods <keyword>");
        PrintMethods(types, parsed.CommandArgs[0]);
        break;

    case "properties":
        Require(parsed.CommandArgs.Count >= 1, "Usage: properties <full-type-name>");
        PrintProperties(types, parsed.CommandArgs[0]);
        break;

    case "markdown":
        Require(parsed.CommandArgs.Count >= 1, "Usage: markdown <full-type-name>");
        PrintMarkdown(types, parsed.CommandArgs[0]);
        break;

    case "method-signatures":
        Require(parsed.CommandArgs.Count >= 2, "Usage: method-signatures <full-type-name> <method-name>");
        PrintMethodSignatures(types, parsed.CommandArgs[0], parsed.CommandArgs[1]);
        break;

    default:
        PrintHelp();
        return 1;
}

return 0;

static MetadataLoadContext CreateMetadataLoadContext(string assemblyPath)
{
    var runtimeAssemblies = Directory.GetFiles(RuntimeEnvironment.GetRuntimeDirectory(), "*.dll");
    var localAssemblies = Directory.GetFiles(Path.GetDirectoryName(Path.GetFullPath(assemblyPath))!, "*.dll");
    var resolverPaths = runtimeAssemblies.Concat(localAssemblies).Append(Path.GetFullPath(assemblyPath));

    return new MetadataLoadContext(new PathAssemblyResolver(resolverPaths.Distinct(StringComparer.OrdinalIgnoreCase)));
}

static Type[] SafeGetTypes(Assembly assembly)
{
    try
    {
        return assembly.GetTypes();
    }
    catch (ReflectionTypeLoadException ex)
    {
        return ex.Types.Where(t => t is not null).Cast<Type>().ToArray();
    }
}

static void PrintTypes(Type[] types, string keyword)
{
    foreach (var type in types
        .Where(t => (t.FullName ?? t.Name).Contains(keyword, StringComparison.OrdinalIgnoreCase))
        .OrderBy(t => t.FullName))
    {
        Console.WriteLine(type.FullName);
    }
}

static void PrintMethods(Type[] types, string keyword)
{
    foreach (var type in types.OrderBy(t => t.FullName))
    {
        foreach (var method in SafeGetMethods(type))
        {
            var full = $"{type.FullName}.{method.Name}";
            if (full.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{type.Assembly.GetName().Name} | {DescribeMethod(type, method)}");
            }
        }
    }
}

static void PrintProperties(Type[] types, string typeName)
{
    var type = FindType(types, typeName);

    if (type is null)
    {
        Console.Error.WriteLine($"Type not found: {typeName}");
        return;
    }

    foreach (var prop in SafeGetProperties(type).OrderBy(p => p.Name))
    {
        Console.WriteLine($"{FormatType(prop.PropertyType)} {prop.Name}");
    }
}

static void PrintMarkdown(Type[] types, string typeName)
{
    var type = FindType(types, typeName);

    if (type is null)
    {
        Console.Error.WriteLine($"Type not found: {typeName}");
        return;
    }

    var sb = new StringBuilder();

    sb.AppendLine($"# `{type.FullName}`");
    sb.AppendLine();
    sb.AppendLine("## Properties");
    sb.AppendLine();
    sb.AppendLine("| Name | Type |");
    sb.AppendLine("|---|---|");

    foreach (var prop in SafeGetProperties(type).OrderBy(p => p.Name))
    {
        sb.AppendLine($"| `{prop.Name}` | `{FormatType(prop.PropertyType)}` |");
    }

    sb.AppendLine();
    sb.AppendLine("## Methods");
    sb.AppendLine();
    sb.AppendLine("| Name | Return Type | Parameters |");
    sb.AppendLine("|---|---|---|");

    foreach (var method in SafeGetMethods(type).OrderBy(m => m.Name))
    {
        if (method.IsSpecialName)
        {
            continue;
        }

        var parameters = string.Join(", ", method.GetParameters()
            .Select(p => $"`{FormatType(p.ParameterType)} {p.Name}`"));

        sb.AppendLine($"| `{method.Name}` | `{FormatType(method.ReturnType)}` | {parameters} |");
    }

    Console.WriteLine(sb.ToString());
}

static void PrintMethodSignatures(Type[] types, string typeName, string methodName)
{
    var type = FindType(types, typeName);

    if (type is null)
    {
        Console.Error.WriteLine($"Type not found: {typeName}");
        return;
    }

    var methods = SafeGetMethods(type)
        .Where(m => m.Name.Equals(methodName, StringComparison.Ordinal))
        .OrderBy(m => m.GetParameters().Length)
        .ToList();

    if (methods.Count == 0)
    {
        Console.Error.WriteLine($"Method not found: {typeName}.{methodName}");
        return;
    }

    foreach (var method in methods)
    {
        Console.WriteLine(DescribeMethod(type, method));
    }
}

static Type? FindType(Type[] types, string typeName)
{
    return types.FirstOrDefault(t =>
        string.Equals(t.FullName, typeName, StringComparison.Ordinal) ||
        string.Equals(t.Name, typeName, StringComparison.Ordinal));
}

static MethodInfo[] SafeGetMethods(Type type)
{
    try
    {
        return type.GetMethods(
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.DeclaredOnly);
    }
    catch
    {
        return [];
    }
}

static PropertyInfo[] SafeGetProperties(Type type)
{
    try
    {
        return type.GetProperties(
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.DeclaredOnly);
    }
    catch
    {
        return [];
    }
}

static string DescribeMethod(Type type, MethodInfo method)
{
    var parameters = string.Join(", ", method.GetParameters()
        .Select(p => $"{FormatType(p.ParameterType)} {p.Name}"));

    var visibility =
        method.IsPublic ? "public" :
        method.IsPrivate ? "private" :
        method.IsFamily ? "protected" :
        method.IsAssembly ? "internal" :
        "unknown";

    var scope = method.IsStatic ? "static" : "instance";

    return $"{visibility} {scope} {FormatType(method.ReturnType)} {type.FullName}.{method.Name}({parameters})";
}

static string FormatType(Type type)
{
    if (!type.IsGenericType)
    {
        return type.FullName ?? type.Name;
    }

    var genericTypeName = type.GetGenericTypeDefinition().FullName ?? type.Name;
    genericTypeName = genericTypeName.Split('`')[0];

    var args = string.Join(", ", type.GetGenericArguments().Select(FormatType));
    return $"{genericTypeName}<{args}>";
}

static void Require(bool condition, string message)
{
    if (!condition)
    {
        Console.Error.WriteLine(message);
        Environment.Exit(1);
    }
}

static void PrintHelp()
{
    Console.WriteLine("""
STS2 Inspector

Usage:
  dotnet run -- --assembly <path> types <keyword>
  dotnet run -- --assembly <path> methods <keyword>
  dotnet run -- --assembly <path> properties <full-type-name>
  dotnet run -- --assembly <path> markdown <full-type-name>
  dotnet run -- --assembly <path> method-signatures <full-type-name> <method-name>
""");
}

internal sealed class Args
{
    public string? AssemblyPath { get; private init; }
    public string? Command { get; private init; }
    public List<string> CommandArgs { get; private init; } = [];

    public static Args Parse(string[] args)
    {
        string? assemblyPath = null;
        string? command = null;
        var commandArgs = new List<string>();

        for (var i = 0; i < args.Length; i++)
        {
            if (args[i] == "--assembly" && i + 1 < args.Length)
            {
                assemblyPath = args[++i];
                continue;
            }

            if (command is null)
            {
                command = args[i];
            }
            else
            {
                commandArgs.Add(args[i]);
            }
        }

        return new Args
        {
            AssemblyPath = assemblyPath,
            Command = command,
            CommandArgs = commandArgs
        };
    }
}
