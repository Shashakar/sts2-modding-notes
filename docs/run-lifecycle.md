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
Seed=<seed>
Players=1
Acts=3
Modifiers=0
```

Multiplayer example:

```text
GameMode=Standard
Ascension=0
Seed=<seed>
Players=2
Acts=3
Modifiers=0
```

## Confirmed current-run save hook

**Status:** Confirmed

```text
Type:   MegaCrit.Sts2.Core.Saves.SaveManager
Method: SaveRun
```

Confirmed signature:

```csharp
Task SaveRun(AbstractRoom preFinishedRoom, bool saveProgress)
```

Harmony postfix patches work on this method.

For save-and-quit or other current-run saves, wait for the returned `Task` before reading saved run data. After the task completes, `SaveManager.LoadRunSave()` can return a `ReadSaveResult<SerializableRun>` where `Success=true` and `SaveData` is populated.

Observed single-player behavior:

- `preFinishedRoom` may be `null`.
- Saved run snapshots can be read after the returned task completes.
- `SerializablePlayer.Deck`, `Relics`, and `Potions` counts were reliable in the saved snapshot.

## Confirmed run progress and finish hook

**Status:** Confirmed

```text
Type:   MegaCrit.Sts2.Core.Saves.SaveManager
Method: UpdateProgressWithRunData
```

Confirmed signature:

```csharp
void UpdateProgressWithRunData(SerializableRun serializableRun, bool victory)
```

Harmony postfix patches work on this method. The `serializableRun` argument can be used as the final run snapshot.

Observed outcomes:

- `victory=true` represents successful run completion.
- `victory=false` was observed when abandoning/giving up after continuing a saved run.
- `SerializablePlayer.Deck`, `Relics`, and `Potions` counts were reliable in progressed and finished snapshots.

## Save-and-quit lifecycle note

If a mod stores current-run context only in memory, save-and-quit followed by continue loses that state. Recovering the active unfinished run from prior local events keyed by `runKey` worked for lifecycle continuation.

In the tested save-quit-continue-give-up flow, the successful finish event was observed through `SaveManager.UpdateProgressWithRunData(..., victory: false)`.

## Candidate abandon hook

```text
Type:   MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.RunLobby
Method: AbandonRun
```

Harmony patches apply successfully to `RunLobby.AbandonRun()`, but this method has not yet been observed as the successful abandon path. In the tested save-quit-continue-give-up flow, `SaveManager.UpdateProgressWithRunData(..., victory: false)` was the observed completion event instead.
