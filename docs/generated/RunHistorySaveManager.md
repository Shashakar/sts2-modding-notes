# `MegaCrit.Sts2.Core.Saves.Managers.RunHistorySaveManager`

## Properties

| Name | Type |
|---|---|
| `HistoryPath` | `System.String` |

## Methods

| Name | Return Type | Parameters |
|---|---|---|
| `CreateRunHistoryDirectory` | `System.Void` |  |
| `GetHistoryCount` | `System.Int32` |  |
| `GetHistoryPath` | `System.String` | `System.Int32 profileId` |
| `LoadAllRunHistoryNames` | `System.Collections.Generic.List<System.String>` |  |
| `LoadHistory` | `MegaCrit.Sts2.Core.Saves.ReadSaveResult<MegaCrit.Sts2.Core.Runs.RunHistory>` | `System.String fileName` |
| `SaveHistory` | `System.Void` | `MegaCrit.Sts2.Core.Runs.RunHistory history` |
| `SaveHistoryInternal` | `System.Void` | `System.String path`, `System.String content` |

