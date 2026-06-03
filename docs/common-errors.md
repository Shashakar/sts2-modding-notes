# Common Errors

## Crash on mod load

### Symptom

STS2 prompts to trust/load mods, then crashes.

### Confirmed cause

Using Godot 4.6.3 while the working mod setup expected Godot 4.5.1.

### Fix

Install Godot 4.5.1 .NET side-by-side and open/build/export the project with that version.

Also ensure:

```xml
<Project Sdk="Godot.NET.Sdk/4.5.1">
  <PropertyGroup>
    <TargetFramework>net9.0</TargetFramework>
  </PropertyGroup>
</Project>
```

## Copying too many files into `mods/`

Do not copy the whole Debug output folder.

Avoid deploying:

```text
GodotSharp.dll
GodotSharpEditor.dll
*.deps.json
*.runtimeconfig.json
*.pdb
```

Start minimal:

```text
FirstMod.dll
FirstMod.json
0Harmony.dll
```

## `.pck` mismatch

If manifest says:

```json
"has_pck": true
```

then the `.pck` must exist.

For DLL-only mods, use:

```json
"has_pck": false
```

## Harmony original parameter names not binding

If original parameters are null/empty in postfix, use:

```csharp
object[] __args
```

instead of relying on named parameter binding.
