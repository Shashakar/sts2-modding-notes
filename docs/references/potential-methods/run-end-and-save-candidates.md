# Run-End and Save Candidates

These methods were found through metadata inspection from `E:\Programming\first-mod\.tmp\inspect-sts2`.

Status: mostly metadata-discovered only. They show API shape, not runtime semantics unless a note explicitly says runtime testing has now confirmed behavior.

## Run completion and combat-end hooks

Potential hook dispatcher methods:

```csharp
Task Hook.AfterCombatVictory(
  IRunState runState,
  CombatState combatState,
  CombatRoom room
)

Task Hook.AfterCombatEnd(
  IRunState runState,
  CombatState combatState,
  CombatRoom room
)
```

`AfterCombatVictory` may be useful for combat victory tracking. `AfterCombatEnd` may fire more broadly than victory and needs runtime testing for losses, interrupted combat, and room transitions.

## Death-related hooks

Potential hook dispatcher methods:

```csharp
Task Hook.BeforeDeath(
  IRunState runState,
  CombatState combatState,
  Creature creature
)

Task Hook.AfterDeath(
  IRunState runState,
  CombatState combatState,
  Creature creature,
  bool wasRemovalPrevented,
  float deathAnimLength
)
```

These may help detect player death or death-prevention flows, but they are creature-level hooks and need testing to distinguish player, monster, summon, and prevented-removal cases.

## Progress and run history save surface

Runtime-confirmed save/progress methods:

```csharp
Task SaveManager.SaveRun(
  AbstractRoom preFinishedRoom,
  bool saveProgress
)

void SaveManager.UpdateProgressWithRunData(
  SerializableRun serializableRun,
  bool victory
)
```

`SaveRun` is confirmed patchable with a Harmony postfix. For save-and-quit/current-run saves, wait for the returned `Task` before reading saved data. After the task completes, `SaveManager.LoadRunSave()` can return `ReadSaveResult<SerializableRun>` with `Success=true` and populated `SaveData`. In observed single-player flow, `preFinishedRoom` may be `null`.

`UpdateProgressWithRunData` is confirmed patchable with a Harmony postfix. `victory=true` represents successful run completion. `victory=false` was observed when abandoning/giving up after continuing a saved run. The `serializableRun` argument can be used as the final run snapshot.

Potential post-run/progression methods:

```csharp
void ProgressSaveManager.UpdateWithRunData(
  SerializableRun serializableRun,
  bool victory
)

void ProgressSaveManager.UpdateAfterCombatWon(
  Player localPlayer,
  CombatRoom room
)

void RunHistorySaveManager.SaveHistory(
  RunHistory history
)
```

`UpdateWithRunData` is especially interesting because it receives both serialized run data and a `victory` boolean.

## Abandon and game-over surface

Potential abandon/game-over methods:

```csharp
void RunLobby.AbandonRun()

void IRunLobbyListener.RunAbandoned()

void NRun.ShowGameOverScreen(
  SerializableRun serializableRun
)
```

These may be useful for run-abandon or game-over detection, but they are likely UI or multiplayer-state surfaces rather than universal run-end hooks.

`RunLobby.AbandonRun()` has been patched successfully, but it has not yet been observed as the successful abandon path. In a tested save-quit-continue-give-up flow, the observed successful finish event came from `SaveManager.UpdateProgressWithRunData(..., victory: false)`.
