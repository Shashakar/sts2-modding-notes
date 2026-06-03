# Getting Started

This repo documents practical Slay the Spire 2 modding findings.

The current working modding path uses:

- Godot .NET
- C#
- `sts2.dll` as a compile-time reference
- Harmony for runtime patching
- Optional BaseLib for content-style mods

For mods that only inspect runtime state, BaseLib may not be required.

## Basic workflow

1. Create a Godot .NET project.
2. Reference `sts2.dll`.
3. Target the correct .NET/Godot SDK versions.
4. Add a `[ModInitializer]`.
5. Build a DLL.
6. Create a mod manifest JSON.
7. Place the mod files under the game's `mods/` folder.
8. Launch STS2 and choose to load/trust mods.

## Minimal confirmed mod output

For a DLL-only mod, this worked:

```text
Slay the Spire 2/
  mods/
    ExampleMod/
      ExampleMod.dll
      ExampleMod.json
      0Harmony.dll
```

`has_pck` can be `false` for DLL-only mods.
