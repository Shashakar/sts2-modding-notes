# `MegaCrit.Sts2.Core.Runs.RunState`

## Properties

| Name | Type |
|---|---|
| `Act` | `MegaCrit.Sts2.Core.Models.ActModel` |
| `ActFloor` | `System.Int32` |
| `Acts` | `System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>` |
| `AscensionLevel` | `System.Int32` |
| `BaseRoom` | `MegaCrit.Sts2.Core.Rooms.AbstractRoom` |
| `CurrentActIndex` | `System.Int32` |
| `CurrentMapCoord` | `System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord>` |
| `CurrentMapPoint` | `MegaCrit.Sts2.Core.Map.MapPoint` |
| `CurrentMapPointHistoryEntry` | `MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry` |
| `CurrentRoom` | `MegaCrit.Sts2.Core.Rooms.AbstractRoom` |
| `CurrentRoomCount` | `System.Int32` |
| `ExtraFields` | `MegaCrit.Sts2.Core.Runs.ExtraRunFields` |
| `GameMode` | `MegaCrit.Sts2.Core.Runs.GameMode` |
| `IsGameOver` | `System.Boolean` |
| `Map` | `MegaCrit.Sts2.Core.Map.ActMap` |
| `MapLocation` | `MegaCrit.Sts2.Core.Runs.MapLocation` |
| `MapPointHistory` | `System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>>` |
| `Modifiers` | `System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>` |
| `MultiplayerScalingModel` | `MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel` |
| `NextRoomId` | `System.Int32` |
| `Odds` | `MegaCrit.Sts2.Core.Odds.RunOddsSet` |
| `Players` | `System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player>` |
| `Rng` | `MegaCrit.Sts2.Core.Runs.RunRngSet` |
| `RunLocation` | `MegaCrit.Sts2.Core.Runs.RunLocation` |
| `SharedRelicGrabBag` | `MegaCrit.Sts2.Core.Runs.RelicGrabBag` |
| `TotalFloor` | `System.Int32` |
| `UnlockState` | `MegaCrit.Sts2.Core.Unlocks.UnlockState` |
| `VisitedEventIds` | `System.Collections.Generic.IReadOnlySet<MegaCrit.Sts2.Core.Models.ModelId>` |
| `VisitedMapCoords` | `System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Map.MapCoord>` |

## Methods

| Name | Return Type | Parameters |
|---|---|---|
| `AddCard` | `System.Void` | `MegaCrit.Sts2.Core.Models.CardModel card`, `MegaCrit.Sts2.Core.Entities.Players.Player owner` |
| `AddCard` | `System.Void` | `MegaCrit.Sts2.Core.Models.CardModel card` |
| `AddModifierDebug` | `System.Void` | `MegaCrit.Sts2.Core.Models.ModifierModel modifier` |
| `AddPlayerDebug` | `System.Void` | `MegaCrit.Sts2.Core.Entities.Players.Player player`, `System.Int32 index` |
| `AddVisitedEvent` | `System.Void` | `MegaCrit.Sts2.Core.Models.EventModel eventModel` |
| `AddVisitedMapCoord` | `System.Boolean` | `MegaCrit.Sts2.Core.Map.MapCoord coord` |
| `AppendToMapPointHistory` | `System.Void` | `MegaCrit.Sts2.Core.Map.MapPointType mapPointType`, `MegaCrit.Sts2.Core.Rooms.RoomType initialRoomType`, `MegaCrit.Sts2.Core.Models.ModelId roomModelId` |
| `ClearVisitedMapCoordsDebug` | `System.Void` |  |
| `CloneCard` | `MegaCrit.Sts2.Core.Models.CardModel` | `MegaCrit.Sts2.Core.Models.CardModel mutableCard` |
| `Contains` | `System.Boolean` | `MegaCrit.Sts2.Core.Models.AbstractModel model` |
| `ContainsCard` | `System.Boolean` | `MegaCrit.Sts2.Core.Models.CardModel card` |
| `CreateCard` | `T` | `MegaCrit.Sts2.Core.Entities.Players.Player owner` |
| `CreateCard` | `MegaCrit.Sts2.Core.Models.CardModel` | `MegaCrit.Sts2.Core.Models.CardModel canonicalCard`, `MegaCrit.Sts2.Core.Entities.Players.Player owner` |
| `CreateForNewRun` | `MegaCrit.Sts2.Core.Runs.RunState` | `System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> players`, `System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> acts`, `System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers`, `MegaCrit.Sts2.Core.Runs.GameMode gameMode`, `System.Int32 ascensionLevel`, `System.String seed` |
| `CreateForTest` | `MegaCrit.Sts2.Core.Runs.RunState` | `System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> players`, `System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> acts`, `System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers`, `MegaCrit.Sts2.Core.Runs.GameMode gameMode`, `System.Int32 ascensionLevel`, `System.String seed` |
| `CreateShared` | `MegaCrit.Sts2.Core.Runs.RunState` | `System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> players`, `System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> acts`, `System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers`, `MegaCrit.Sts2.Core.Runs.GameMode gameMode`, `System.Int32 currentActIndex`, `MegaCrit.Sts2.Core.Runs.RunRngSet rng`, `MegaCrit.Sts2.Core.Odds.RunOddsSet odds`, `MegaCrit.Sts2.Core.Runs.RelicGrabBag sharedRelicGrabBag`, `System.Int32 ascensionLevel` |
| `FromSerializable` | `MegaCrit.Sts2.Core.Runs.RunState` | `MegaCrit.Sts2.Core.Saves.SerializableRun save` |
| `GetAndIncrementNextRoomId` | `System.Int32` |  |
| `GetHistoryEntryFor` | `MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry` | `MegaCrit.Sts2.Core.Runs.MapLocation location` |
| `GetPlayer` | `MegaCrit.Sts2.Core.Entities.Players.Player` | `System.UInt64 netId` |
| `GetPlayerSlotIndex` | `System.Int32` | `MegaCrit.Sts2.Core.Entities.Players.Player player` |
| `GetPlayerSlotIndex` | `System.Int32` | `System.UInt64 netId` |
| `IterateHookListeners` | `System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel>` | `MegaCrit.Sts2.Core.Combat.CombatState childCombatState` |
| `LoadCard` | `MegaCrit.Sts2.Core.Models.CardModel` | `MegaCrit.Sts2.Core.Saves.Runs.SerializableCard serializableCard`, `MegaCrit.Sts2.Core.Entities.Players.Player owner` |
| `PopCurrentRoom` | `MegaCrit.Sts2.Core.Rooms.AbstractRoom` |  |
| `PushRoom` | `System.Void` | `MegaCrit.Sts2.Core.Rooms.AbstractRoom room` |
| `RemoveCard` | `System.Void` | `MegaCrit.Sts2.Core.Models.CardModel card` |
| `RemoveStaleVisitedMapCoords` | `System.Void` | `MegaCrit.Sts2.Core.Map.ActMap map` |
| `SetActDebug` | `System.Void` | `MegaCrit.Sts2.Core.Models.ActModel act` |


