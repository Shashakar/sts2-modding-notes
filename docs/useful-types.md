# Useful Types

This file records runtime types discovered during confirmed mod testing.

## `MegaCrit.Sts2.Core.Entities.Players.Player`

**Status:** Confirmed

Known public properties from runtime reflection:

```text
MaxPotionCount
Character
Creature
NetId
PlayerRng
PlayerOdds
RelicGrabBag
UnlockState
RunState
IsActiveForHooks
PlayerCombatState
ExtraFields
Relics
PotionSlots
Potions
Osty
IsOstyAlive
IsOstyMissing
Gold
MaxAscensionWhenRunStarted
HasOpenPotionSlots
CanRemovePotions
Deck
MaxEnergy
DiscoveredCards
DiscoveredRelics
DiscoveredPotions
DiscoveredEnemies
DiscoveredEpochs
BaseOrbSlotCount
Piles
```

Useful properties for run-state inspection:

| Property | Use |
|---|---|
| `Character` | Resolve character/class via `Character.GetType().Name` |
| `NetId` | Platform-style player ID; observed as `UInt64` |
| `Gold` | Starting gold |
| `Deck` | Starting deck count |
| `Relics` | Starting relic count |
| `Potions` | Starting potion count |
| `MaxAscensionWhenRunStarted` | Player ascension context |

## Character extraction

Preferred approach:

```csharp
private static string? CleanCharacterNameFromType(object? character)
{
    if (character is null)
    {
        return null;
    }

    var typeName = character.GetType().FullName ?? character.GetType().Name;
    var lastDot = typeName.LastIndexOf('.');

    return lastDot >= 0
        ? typeName[(lastDot + 1)..]
        : typeName;
}
```

Expected output:

```text
Ironclad
Silent
Defect
Necrobinder
Regent
```

Avoid relying on `character.ToString()` if possible, because some outputs included noisier forms like:

```text
CHARACTER.IRONCLAD (58709918)
```

## `MegaCrit.Sts2.Core.Entities.Multiplayer.LobbyPlayer`

**Status:** Confirmed

Initial runtime reflection found no obvious public properties, but `ToString()` was useful.

Example:

```text
Player <platform id>, IRONCLAD
```

Use this as a fallback source for platform ID and character in lobby capture.

## `MegaCrit.Sts2.Core.Saves.SerializableRun`

**Status:** Confirmed

Known useful public properties from runtime testing:

```text
Players
GameMode
Ascension
RunTime
SaveTime
StartTime
WinTime
CurrentActIndex
```

Useful properties for saved, progressed, and finished run snapshots:

| Property | Use |
|---|---|
| `Players` | Serialized player snapshots for the run |
| `GameMode` | Run mode |
| `Ascension` | Run ascension level |
| `RunTime` | Run duration |
| `SaveTime` | Current save timestamp |
| `StartTime` | Run start timestamp |
| `WinTime` | Win timestamp when present |
| `CurrentActIndex` | Current act position |

## `MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer`

**Status:** Confirmed

Known useful public properties from runtime testing:

```text
NetId
Gold
Deck
Relics
Potions
CurrentHp
MaxHp
CharacterId
```

Useful properties for run snapshot inspection:

| Property | Use |
|---|---|
| `NetId` | Platform-style player ID |
| `Gold` | Player gold at snapshot time |
| `Deck` | Reliable deck count/source in saved, progressed, and finished snapshots |
| `Relics` | Reliable relic count/source in saved, progressed, and finished snapshots |
| `Potions` | Reliable potion count/source in saved, progressed, and finished snapshots |
| `CurrentHp` | Current HP at snapshot time |
| `MaxHp` | Max HP at snapshot time |
| `CharacterId` | Serialized character/class ID |
