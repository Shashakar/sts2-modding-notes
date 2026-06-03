# `MegaCrit.Sts2.Core.Combat.CombatManager`

## Properties

| Name | Type |
|---|---|
| `CombatCt` | `System.Threading.CancellationToken` |
| `DebugForcedTopCardOnNextShuffle` | `MegaCrit.Sts2.Core.Models.CardModel` |
| `EndingPlayerTurnPhaseOne` | `System.Boolean` |
| `EndingPlayerTurnPhaseTwo` | `System.Boolean` |
| `History` | `MegaCrit.Sts2.Core.Combat.History.CombatHistory` |
| `Instance` | `MegaCrit.Sts2.Core.Combat.CombatManager` |
| `IsAboutToLose` | `System.Boolean` |
| `IsEnding` | `System.Boolean` |
| `IsEnemyTurnStarted` | `System.Boolean` |
| `IsInProgress` | `System.Boolean` |
| `IsOverOrEnding` | `System.Boolean` |
| `IsPaused` | `System.Boolean` |
| `IsPlayPhase` | `System.Boolean` |
| `PlayerActionsDisabled` | `System.Boolean` |
| `PlayersTakingExtraTurn` | `System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player>` |
| `StateTracker` | `MegaCrit.Sts2.Core.Combat.CombatStateTracker` |

## Methods

| Name | Return Type | Parameters |
|---|---|---|
| `AddCreature` | `System.Void` | `MegaCrit.Sts2.Core.Entities.Creatures.Creature creature` |
| `AfterAllPlayersReadyToBeginEnemyTurn` | `System.Threading.Tasks.Task` | `System.Func<System.Threading.Tasks.Task> actionDuringEnemyTurn` |
| `AfterAllPlayersReadyToEndTurn` | `System.Threading.Tasks.Task` | `System.Func<System.Threading.Tasks.Task> actionDuringEnemyTurn` |
| `AfterCombatRoomLoaded` | `System.Void` |  |
| `AfterCreatureAdded` | `System.Threading.Tasks.Task` | `MegaCrit.Sts2.Core.Entities.Creatures.Creature creature` |
| `AllPlayersReadyToEndTurn` | `System.Boolean` |  |
| `CheckForEmptyHand` | `System.Threading.Tasks.Task` | `MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext`, `MegaCrit.Sts2.Core.Entities.Players.Player player` |
| `CheckWinCondition` | `System.Threading.Tasks.Task<System.Boolean>` |  |
| `DebugClearForcedTopCardOnNextShuffle` | `System.Void` |  |
| `DebugForceTopCardOnNextShuffle` | `System.Void` | `MegaCrit.Sts2.Core.Models.CardModel card` |
| `DebugOnlyGetState` | `MegaCrit.Sts2.Core.Combat.CombatState` |  |
| `DoTurnEnd` | `System.Threading.Tasks.Task` | `MegaCrit.Sts2.Core.Entities.Players.Player player`, `MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext` |
| `EndCombatInternal` | `System.Threading.Tasks.Task` |  |
| `EndEnemyTurn` | `System.Threading.Tasks.Task` |  |
| `EndEnemyTurnInternal` | `System.Threading.Tasks.Task` |  |
| `EndPlayerTurnPhaseOneInternal` | `System.Threading.Tasks.Task` |  |
| `EndPlayerTurnPhaseTwoInternal` | `System.Threading.Tasks.Task` |  |
| `ExecuteEnemyTurn` | `System.Threading.Tasks.Task` | `System.Func<System.Threading.Tasks.Task> actionDuringEnemyTurn` |
| `HandlePlayerDeath` | `System.Threading.Tasks.Task` | `MegaCrit.Sts2.Core.Entities.Players.Player player` |
| `IsPartOfPlayerTurn` | `System.Boolean` | `MegaCrit.Sts2.Core.Entities.Players.Player player` |
| `IsPlayerReadyToEndTurn` | `System.Boolean` | `MegaCrit.Sts2.Core.Entities.Players.Player player` |
| `LoseCombat` | `System.Void` |  |
| `OnEndedTurnLocally` | `System.Void` |  |
| `Pause` | `System.Void` |  |
| `ProcessPendingLoss` | `System.Void` |  |
| `RemoveCreature` | `System.Void` | `MegaCrit.Sts2.Core.Entities.Creatures.Creature creature` |
| `Reset` | `System.Void` | `System.Boolean graceful` |
| `SetReadyToBeginEnemyTurn` | `System.Void` | `MegaCrit.Sts2.Core.Entities.Players.Player player`, `System.Func<System.Threading.Tasks.Task> actionDuringEnemyTurn` |
| `SetReadyToEndTurn` | `System.Void` | `MegaCrit.Sts2.Core.Entities.Players.Player player`, `System.Boolean canBackOut`, `System.Func<System.Threading.Tasks.Task> actionDuringEnemyTurn` |
| `SetUpCombat` | `System.Void` | `MegaCrit.Sts2.Core.Combat.CombatState state` |
| `SetupPlayerTurn` | `System.Threading.Tasks.Task` | `MegaCrit.Sts2.Core.Entities.Players.Player player`, `MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext playerChoiceContext` |
| `StartCombatInternal` | `System.Threading.Tasks.Task` |  |
| `StartTurn` | `System.Threading.Tasks.Task` | `System.Func<System.Threading.Tasks.Task> actionDuringEnemyTurn` |
| `SwitchFromPlayerToEnemySide` | `System.Threading.Tasks.Task` | `System.Func<System.Threading.Tasks.Task> actionDuringEnemyTurn` |
| `SwitchSides` | `System.Void` |  |
| `UndoReadyToEndTurn` | `System.Void` | `MegaCrit.Sts2.Core.Entities.Players.Player player` |
| `Unpause` | `System.Void` |  |
| `WaitForActionThenEndTurn` | `System.Threading.Tasks.Task` | `MegaCrit.Sts2.Core.GameActions.GameAction action`, `System.Func<System.Threading.Tasks.Task> actionDuringEnemyTurn` |
| `WaitForUnpause` | `System.Threading.Tasks.Task` |  |
| `WaitUntilQueueIsEmptyOrWaitingOnNonPlayerDrivenAction` | `System.Threading.Tasks.Task` |  |


