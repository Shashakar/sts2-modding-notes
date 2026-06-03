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
