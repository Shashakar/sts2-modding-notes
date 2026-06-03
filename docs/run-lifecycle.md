# Run Lifecycle

## Confirmed run-start hook

**Status:** Confirmed

```text
Type:   MegaCrit.Sts2.Core.Runs.RunState
Method: CreateForNewRun
```

Confirmed signature:

```csharp
RunState CreateForNewRun(
  IReadOnlyList<Player> players,
  IReadOnlyList<ActModel> acts,
  IReadOnlyList<ModifierModel> modifiers,
  GameMode gameMode,
  int ascensionLevel,
  string seed
)
```

## Why this hook is useful

This hook fires when the actual run state is created. It is better than patching a UI button because the run is real at this point.

It provides:

- players
- acts
- modifiers
- game mode
- ascension level
- seed

## Confirmed captured values

Single-player example:

```text
GameMode=Standard
Ascension=0
Seed=<seed>
Players=1
Acts=3
Modifiers=0
```

Multiplayer example:

```text
GameMode=Standard
Ascension=0
Seed=<seed>
Players=2
Acts=3
Modifiers=0
```
