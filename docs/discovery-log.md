# Discovery Log

## 2026-06-03 - Community research pass

Added [Community Research](community-research.md) as a published source map for public Slay the Spire 2 modding resources.

High-value sources from the pass:

- [Alchyr/BaseLib-StS2](https://github.com/Alchyr/BaseLib-StS2)
- [Alchyr/ModTemplate-StS2 wiki](https://github.com/Alchyr/ModTemplate-StS2/wiki)
- [BAKAOLC/STS2-RitsuLib](https://github.com/BAKAOLC/STS2-RitsuLib)
- [STS2.GG install guide](https://sts2.gg/mods/install-guide)
- [GitHub topic: slay-the-spire-2](https://github.com/topics/slay-the-spire-2)

Key next research targets are BaseLib save/hook patches, RitsuLib run data and patching folders, dev-tooling mods, companion/run trackers, and multiplayer save-slot mods.

## 2026-06-01 - Minimal mod loading

Confirmed that a DLL-only mod can load with:

```text
ExampleMod.dll
ExampleMod.json
```

For Harmony patches, also deploy:

```text
0Harmony.dll
```

Confirmed Godot 4.5.1 .NET was required for stable mod loading. Godot 4.6.3 caused crashes.

## 2026-06-01 - Run start hook

Confirmed:

```text
MegaCrit.Sts2.Core.Runs.RunState.CreateForNewRun
```

Signature:

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

Observed values:

```text
GameMode=Standard
Ascension=0
Seed=<seed>
Players=1 or 2
Acts=3
Modifiers=0
```

## 2026-06-01 - Harmony args

Named Harmony parameter binding did not reliably capture original args.

`object[] __args` worked.

## 2026-06-01 - Player object

Runtime reflection confirmed `Player` properties:

```text
Character
NetId
Gold
Deck
Relics
Potions
MaxAscensionWhenRunStarted
RunState
```

`NetId` was observed as a `UInt64` and matched Steam-style IDs in multiplayer.

## 2026-06-01 - Multiplayer lobby

Confirmed lobby hooks:

```text
StartRunLobby.BeginRunLocally
StartRunLobby.BeginRunForAllPlayers
```

Both can fire for the same run start, requiring dedupe.

Confirmed two-player multiplayer capture:

```text
Names=<player one>, <player two>
NetIds=<platform id>, <platform id>
Seed=<seed>
GameMode=Standard
Ascension=0
Players=2
```
