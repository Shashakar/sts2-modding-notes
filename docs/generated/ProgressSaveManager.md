# `MegaCrit.Sts2.Core.Saves.Managers.ProgressSaveManager`

## Properties

| Name | Type |
|---|---|
| `Progress` | `MegaCrit.Sts2.Core.Saves.ProgressState` |

## Methods

| Name | Return Type | Parameters |
|---|---|---|
| `<UpdateEpochsPostRun>b__20_0` | `System.Boolean` | `MegaCrit.Sts2.Core.Models.AncientEventModel a` |
| `CheckAscensionOneCompleted` | `System.Void` | `MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer serializablePlayer`, `MegaCrit.Sts2.Core.Saves.SerializableRun serializableRun` |
| `CheckFifteenBossesDefeatedEpoch` | `System.Void` | `MegaCrit.Sts2.Core.Entities.Players.Player localPlayer` |
| `CheckFifteenElitesDefeatedEpoch` | `System.Void` | `MegaCrit.Sts2.Core.Entities.Players.Player localPlayer` |
| `GenerateUnlockState` | `MegaCrit.Sts2.Core.Unlocks.UnlockState` |  |
| `GetEliteEncounters` | `System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.ModelId>` |  |
| `GetProgressPathForProfile` | `System.String` | `System.Int32 profileId` |
| `GetRevealableEpochs` | `System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.SerializableEpoch>` |  |
| `IncrementEncounterLoss` | `System.Void` | `MegaCrit.Sts2.Core.Models.ModelId characterId`, `MegaCrit.Sts2.Core.Models.ModelId encounterId` |
| `IncrementEnemyFightLoss` | `System.Void` | `MegaCrit.Sts2.Core.Models.ModelId characterId`, `MegaCrit.Sts2.Core.Models.ModelId monster` |
| `IncrementMultiplayerAscension` | `System.Void` | `MegaCrit.Sts2.Core.Saves.SerializableRun run` |
| `IncrementSingleplayerAscension` | `System.Void` | `MegaCrit.Sts2.Core.Saves.SerializableRun run`, `MegaCrit.Sts2.Core.Saves.CharacterStats charStats` |
| `LoadProgress` | `MegaCrit.Sts2.Core.Saves.ReadSaveResult<MegaCrit.Sts2.Core.Saves.SerializableProgress>` |  |
| `MarkCardAsSeen` | `System.Void` | `MegaCrit.Sts2.Core.Models.CardModel card` |
| `MarkFtueAsComplete` | `System.Void` | `System.String ftueId` |
| `MarkPotionAsSeen` | `System.Void` | `MegaCrit.Sts2.Core.Models.PotionModel potion` |
| `MarkRelicAsSeen` | `System.Void` | `MegaCrit.Sts2.Core.Models.RelicModel relic` |
| `ObtainCharUnlockEpoch` | `System.Void` | `MegaCrit.Sts2.Core.Entities.Players.Player localPlayer`, `System.Int32 act` |
| `PostRunCharacterEpochChecks` | `System.Void` | `MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer serializablePlayer`, `MegaCrit.Sts2.Core.Saves.SerializableRun serializableRun`, `System.Boolean victory` |
| `PostRunUnlockCharacterEpochCheck` | `System.Void` | `MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer serializablePlayer`, `MegaCrit.Sts2.Core.Saves.SerializableRun serializableRun` |
| `ResetFtues` | `System.Void` |  |
| `SaveProgress` | `System.Void` |  |
| `SeenFtue` | `System.Boolean` | `System.String ftueKey` |
| `SetFtuesEnabled` | `System.Void` | `System.Boolean enabled` |
| `TryObtainEpochInternal` | `System.Boolean` | `MegaCrit.Sts2.Core.Timeline.EpochModel epoch` |
| `TryObtainEpochMidRun` | `System.Boolean` | `MegaCrit.Sts2.Core.Timeline.EpochModel epoch`, `MegaCrit.Sts2.Core.Entities.Players.Player localPlayer` |
| `TryObtainEpochPostRun` | `System.Boolean` | `MegaCrit.Sts2.Core.Timeline.EpochModel epoch`, `MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer serializablePlayer`, `MegaCrit.Sts2.Core.Saves.SerializableRun serializableRun` |
| `UpdateAfterCombatWon` | `System.Void` | `MegaCrit.Sts2.Core.Entities.Players.Player localPlayer`, `MegaCrit.Sts2.Core.Rooms.CombatRoom room` |
| `UpdateEpochsPostRun` | `System.Void` | `MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer serializablePlayer`, `MegaCrit.Sts2.Core.Saves.SerializableRun serializableRun`, `System.Boolean victory` |
| `UpdateWithRunData` | `System.Void` | `MegaCrit.Sts2.Core.Saves.SerializableRun serializableRun`, `System.Boolean victory` |

