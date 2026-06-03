# `MegaCrit.Sts2.Core.Saves.Managers.RunSaveManager`

## Properties

| Name | Type |
|---|---|
| `CurrentMultiplayerRunSavePath` | `System.String` |
| `CurrentRunSavePath` | `System.String` |
| `HasMultiplayerRunSave` | `System.Boolean` |
| `HasRunSave` | `System.Boolean` |
| `SchemaVersion` | `System.Int32` |

## Methods

| Name | Return Type | Parameters |
|---|---|---|
| `DeleteCurrentMultiplayerRun` | `System.Void` |  |
| `DeleteCurrentRun` | `System.Void` |  |
| `GetRunSavePath` | `System.String` | `System.Int32 profileId`, `System.String fileName` |
| `LoadAndCanonicalizeMultiplayerRunSave` | `MegaCrit.Sts2.Core.Saves.ReadSaveResult<MegaCrit.Sts2.Core.Saves.SerializableRun>` | `System.UInt64 localPlayerId` |
| `LoadMultiplayerRunSave` | `MegaCrit.Sts2.Core.Saves.ReadSaveResult<MegaCrit.Sts2.Core.Saves.SerializableRun>` |  |
| `LoadRunSave` | `MegaCrit.Sts2.Core.Saves.ReadSaveResult<MegaCrit.Sts2.Core.Saves.SerializableRun>` |  |
| `RenameBrokenMultiplayerRunSave` | `System.Void` | `MegaCrit.Sts2.Core.Saves.ReadSaveStatus status` |
| `SaveRun` | `System.Threading.Tasks.Task` | `MegaCrit.Sts2.Core.Rooms.AbstractRoom preFinishedRoom` |


