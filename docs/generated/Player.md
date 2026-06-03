# `MegaCrit.Sts2.Core.Entities.Players.Player`

## Properties

| Name | Type |
|---|---|
| `BaseOrbSlotCount` | `System.Int32` |
| `CanRemovePotions` | `System.Boolean` |
| `Character` | `MegaCrit.Sts2.Core.Models.CharacterModel` |
| `Creature` | `MegaCrit.Sts2.Core.Entities.Creatures.Creature` |
| `Deck` | `MegaCrit.Sts2.Core.Entities.Cards.CardPile` |
| `DiscoveredCards` | `System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId>` |
| `DiscoveredEnemies` | `System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId>` |
| `DiscoveredEpochs` | `System.Collections.Generic.List<System.String>` |
| `DiscoveredPotions` | `System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId>` |
| `DiscoveredRelics` | `System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId>` |
| `ExtraFields` | `MegaCrit.Sts2.Core.Entities.Players.ExtraPlayerFields` |
| `Gold` | `System.Int32` |
| `HasOpenPotionSlots` | `System.Boolean` |
| `IsActiveForHooks` | `System.Boolean` |
| `IsInventoryPopulated` | `System.Boolean` |
| `IsOstyAlive` | `System.Boolean` |
| `IsOstyMissing` | `System.Boolean` |
| `MaxAscensionWhenRunStarted` | `System.Int32` |
| `MaxEnergy` | `System.Int32` |
| `MaxPotionCount` | `System.Int32` |
| `NetId` | `System.UInt64` |
| `Osty` | `MegaCrit.Sts2.Core.Entities.Creatures.Creature` |
| `Piles` | `System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardPile>` |
| `PlayerCombatState` | `MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState` |
| `PlayerOdds` | `MegaCrit.Sts2.Core.Odds.PlayerOddsSet` |
| `PlayerRng` | `MegaCrit.Sts2.Core.Random.PlayerRngSet` |
| `Potions` | `System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PotionModel>` |
| `PotionSlots` | `System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.PotionModel>` |
| `RelicGrabBag` | `MegaCrit.Sts2.Core.Runs.RelicGrabBag` |
| `Relics` | `System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RelicModel>` |
| `RunState` | `MegaCrit.Sts2.Core.Runs.IRunState` |
| `UnlockState` | `MegaCrit.Sts2.Core.Unlocks.UnlockState` |

## Methods

| Name | Return Type | Parameters |
|---|---|---|
| `<SyncWithSerializedPlayer>b__142_0` | `MegaCrit.Sts2.Core.Models.CardModel` | `MegaCrit.Sts2.Core.Saves.Runs.SerializableCard c` |
| `ActivateHooks` | `System.Void` |  |
| `AddPotionInternal` | `MegaCrit.Sts2.Core.Entities.Potions.PotionProcureResult` | `MegaCrit.Sts2.Core.Models.PotionModel potion`, `System.Int32 slotIndex`, `System.Boolean silent` |
| `AddRelicInternal` | `System.Void` | `MegaCrit.Sts2.Core.Models.RelicModel relic`, `System.Int32 index`, `System.Boolean silent` |
| `AddToMaxPotionCount` | `System.Void` | `System.Int32 maxPotionCountIncrease` |
| `AfterCombatEnd` | `System.Void` |  |
| `CreateForNewRun` | `MegaCrit.Sts2.Core.Entities.Players.Player` | `MegaCrit.Sts2.Core.Unlocks.UnlockState unlockState`, `System.UInt64 netId` |
| `CreateForNewRun` | `MegaCrit.Sts2.Core.Entities.Players.Player` | `MegaCrit.Sts2.Core.Models.CharacterModel character`, `MegaCrit.Sts2.Core.Unlocks.UnlockState unlockState`, `System.UInt64 netId` |
| `DeactivateHooks` | `System.Void` |  |
| `DiscardPotionInternal` | `System.Void` | `MegaCrit.Sts2.Core.Models.PotionModel potion`, `System.Boolean silent` |
| `FromSerializable` | `MegaCrit.Sts2.Core.Entities.Players.Player` | `MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer save` |
| `GetPotionAtSlotIndex` | `MegaCrit.Sts2.Core.Models.PotionModel` | `System.Int32 index` |
| `GetPotionSlotIndex` | `System.Int32` | `MegaCrit.Sts2.Core.Models.PotionModel model` |
| `GetRelic` | `T` |  |
| `GetRelicById` | `MegaCrit.Sts2.Core.Models.RelicModel` | `MegaCrit.Sts2.Core.Models.ModelId id` |
| `HasEventPet` | `System.Boolean` |  |
| `InitializeSeed` | `System.Void` | `System.String seed` |
| `LoadInventory` | `System.Void` | `MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer save` |
| `LoadPotions` | `System.Void` | `System.Collections.Generic.List<MegaCrit.Sts2.Core.Saves.Runs.SerializablePotion> serializablePotions`, `System.Boolean silent` |
| `MeltRelicInternal` | `System.Void` | `MegaCrit.Sts2.Core.Models.RelicModel relic` |
| `OnRelicFlashed` | `System.Void` | `MegaCrit.Sts2.Core.Models.RelicModel relic`, `System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets` |
| `OnSideSwitch` | `System.Void` |  |
| `PopulateCombatState` | `System.Void` | `MegaCrit.Sts2.Core.Random.Rng rng`, `MegaCrit.Sts2.Core.Combat.CombatState state` |
| `PopulateDeck` | `System.Void` | `System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards`, `System.Boolean silent` |
| `PopulateRelicGrabBagIfNecessary` | `System.Void` | `MegaCrit.Sts2.Core.Random.Rng rng` |
| `PopulateRelics` | `System.Void` | `System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> relics`, `System.Boolean silent` |
| `PopulateStartingDeck` | `System.Void` |  |
| `PopulateStartingInventory` | `System.Void` |  |
| `PopulateStartingRelics` | `System.Void` |  |
| `RemovePotionInternal` | `System.Void` | `MegaCrit.Sts2.Core.Models.PotionModel potion` |
| `RemoveRelicInternal` | `System.Void` | `MegaCrit.Sts2.Core.Models.RelicModel relic`, `System.Boolean silent` |
| `RemoveUsedPotionInternal` | `System.Void` | `MegaCrit.Sts2.Core.Models.PotionModel potion` |
| `ResetCombatState` | `System.Void` |  |
| `ReviveBeforeCombatEnd` | `System.Threading.Tasks.Task` |  |
| `SetMaxPotionCountInternal` | `System.Void` | `System.Int32 newMaxPotionCount` |
| `SubtractFromMaxPotionCount` | `System.Void` | `System.Int32 maxPotionCountDecrease` |
| `SyncWithSerializedPlayer` | `System.Void` | `MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer player` |
| `ToSerializable` | `MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer` |  |


