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
Seed=EEG04HPVQ5
Players=1
Acts=3
Modifiers=0
```

Multiplayer example:

```text
GameMode=Standard
Ascension=0
Seed=K0C8TK126Z
Players=2
Acts=3
Modifiers=0
```

## Recommended event schema

```json
{
  "eventType": "run_started",
  "schemaVersion": 1,
  "eventId": "unique-event-id",
  "runKey": "K0C8TK126Z|Standard|0|76561198008501134,76561198141181565",
  "utcTimestamp": "2026-06-01T22:32:58.6754213+00:00",
  "machineName": "DEX-ALLY",
  "windowsUserName": "dexta",
  "localPlatformPlayerName": "Shashakar",
  "gameMode": "Standard",
  "ascensionLevel": 0,
  "seed": "K0C8TK126Z",
  "playerCount": 2,
  "actCount": 3,
  "modifierCount": 0,
  "hasLobbyRoster": true,
  "players": [
    {
      "platformPlayerId": "76561198008501134",
      "displayName": "Shashakar",
      "character": "Ironclad",
      "gold": 99,
      "deckCount": 10,
      "relicCount": 1,
      "potionCount": 0
    }
  ],
  "modVersion": "0.1.0"
}
```

## Notes

- `eventId` should be unique per local write.
- `runKey` should be stable for deduping uploads.
- Local JSONL should be written before any upload attempt.
