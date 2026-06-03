# Sts2Inspector

A small reflection-based inspection tool for exploring STS2 assemblies.

The source lives at `tools/Sts2Inspector` in this repository.

## Local setup

Create:

```text
deps/
  sts2.dll
  BaseLib.dll
```

Do not commit these files.

## Commands

```powershell
dotnet run -- --assembly ../../deps/sts2.dll types RunState
dotnet run -- --assembly ../../deps/sts2.dll methods CreateForNewRun
dotnet run -- --assembly ../../deps/sts2.dll properties MegaCrit.Sts2.Core.Entities.Players.Player
dotnet run -- --assembly ../../deps/sts2.dll markdown MegaCrit.Sts2.Core.Entities.Players.Player
dotnet run -- --assembly ../../deps/sts2.dll method-signatures MegaCrit.Sts2.Core.Runs.RunState CreateForNewRun
```

## Suggested generated docs

Generate markdown for:

```text
MegaCrit.Sts2.Core.Runs.RunState
MegaCrit.Sts2.Core.Entities.Players.Player
MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby
MegaCrit.Sts2.Core.Combat.CombatManager
MegaCrit.Sts2.Core.Saves.Managers.RunSaveManager
```
