# STS2 Modding Notes

A practical knowledge base and inspection toolkit for Slay the Spire 2 modding.

Slay the Spire 2 modding currently has limited documentation. This repository captures confirmed findings from real mod development, runtime testing, and reflection against local copies of `sts2.dll` and `BaseLib.dll`.

## What this repo is

- A documentation repo for STS2 modding discoveries
- A place to record confirmed hooks, useful runtime types, and common failure modes
- A small C# inspection tool for exploring `sts2.dll` and `BaseLib.dll`
- A reference for building simple DLL-based mods

## What this repo is not

- Not a replacement for BaseLib
- Not a complete modding framework
- Not a redistribution point for STS2 game binaries
- Not guaranteed stable across STS2 updates

## Current confirmed areas

- Minimal DLL mod loading
- Godot/.NET version requirements
- Harmony patching
- Run-start lifecycle hook
- Multiplayer lobby roster capture
- Player identity and character extraction

## Local dependency setup

Create a local `deps/` folder:

```text
deps/
  sts2.dll
  BaseLib.dll
```

These files are intentionally ignored by git.

`sts2.dll` comes from the Slay the Spire 2 install. `BaseLib.dll` comes from the BaseLib-StS2 release assets.

## Quick inspection commands

From `tools/Sts2Inspector`:

```powershell
dotnet run -- --assembly ../../deps/sts2.dll types RunState
dotnet run -- --assembly ../../deps/sts2.dll methods CreateForNewRun
dotnet run -- --assembly ../../deps/sts2.dll properties MegaCrit.Sts2.Core.Entities.Players.Player
dotnet run -- --assembly ../../deps/sts2.dll markdown MegaCrit.Sts2.Core.Entities.Players.Player
dotnet run -- --assembly ../../deps/sts2.dll method-signatures MegaCrit.Sts2.Core.Runs.RunState CreateForNewRun
```

## Certainty labels

- **Confirmed**: verified in a running mod
- **Candidate**: found via reflection but not runtime-tested
- **Speculative**: inferred but not proven
- **Rejected**: previously considered but not recommended

Do not present guesses as confirmed facts.
