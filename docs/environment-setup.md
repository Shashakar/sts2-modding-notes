# Environment Setup

## Confirmed working setup

- Godot 4.5.1 .NET
- `Godot.NET.Sdk/4.5.1`
- `TargetFramework` = `net9.0`
- Local reference to `sts2.dll`
- Harmony via NuGet

## Important version warning

Using Godot 4.6.3 caused the mod to crash on load.

Switching the installed Godot editor/tooling to **Godot 4.5.1 .NET** fixed the crash.

Changing only the `.csproj` SDK version was not enough if the project was still being opened, built, or exported through the wrong Godot version.

## Example `.csproj`

```xml
<Project Sdk="Godot.NET.Sdk/4.5.1">
  <PropertyGroup>
    <TargetFramework>net9.0</TargetFramework>
    <EnableDynamicLoading>true</EnableDynamicLoading>
  </PropertyGroup>

  <ItemGroup>
    <Reference Include="sts2">
      <HintPath>deps\sts2.dll</HintPath>
      <Private>false</Private>
    </Reference>
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Lib.Harmony" Version="2.3.6" />
  </ItemGroup>
</Project>
```

## BaseLib

BaseLib is useful for content mods, but it is not required for a simple runtime-inspection mod unless BaseLib APIs are used.

If used at build time:

```xml
<PackageReference Include="Alchyr.Sts2.BaseLib" Version="*" />
```

At runtime, BaseLib release assets usually include:

```text
BaseLib.dll
BaseLib.json
BaseLib.pck
```

Do not commit these files to this repo.
