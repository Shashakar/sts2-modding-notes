# Known Hooks

## Certainty labels

- **Confirmed**: known to be usable, working, and documented.
- **Potential**: found through inspection or discovery, but not yet tested.
- **Possibility**: inferred that something like this may exist, but more research is needed.

| Purpose | Type | Method | Status | Notes |
|---|---|---|---|---|
| Run started | `MegaCrit.Sts2.Core.Runs.RunState` | `CreateForNewRun` | Confirmed | Best durable run-start hook. Provides players, acts, modifiers, game mode, ascension, seed. |
| Local lobby start | `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby` | `BeginRunLocally` | Confirmed | Captures lobby context before run state creation. Can duplicate with `BeginRunForAllPlayers`. |
| All-player lobby start | `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby` | `BeginRunForAllPlayers` | Confirmed | Useful for multiplayer roster capture. Can fire in same start path as local method. |
| Player creation | `MegaCrit.Sts2.Core.Entities.Players.Player` | `CreateForNewRun` | Potential | Potential lower-level per-player hook. Found through inspection, but not yet tested as a general hook. |
| Combat start | `MegaCrit.Sts2.Core.Combat.CombatManager` | `StartCombatInternal` | Potential | Useful for future combat tracking, but not yet tested. Too late for run-start tracking. |
| Combat victory | `MegaCrit.Sts2.Core.Hooks.Hook` | `AfterCombatVictory` | Potential | Metadata-discovered hook dispatcher. Needs runtime testing for timing and whether it is practical to patch directly. |
| Combat end | `MegaCrit.Sts2.Core.Hooks.Hook` | `AfterCombatEnd` | Potential | Metadata-discovered hook dispatcher. May fire more broadly than victory; test loss, victory, and room-transition behavior. |
| Creature before death | `MegaCrit.Sts2.Core.Hooks.Hook` | `BeforeDeath` | Potential | Creature-level hook. Needs runtime testing to distinguish player death, monster death, summons, and prevention flows. |
| Creature after death | `MegaCrit.Sts2.Core.Hooks.Hook` | `AfterDeath` | Potential | Creature-level hook with `wasRemovalPrevented` and animation length. Needs runtime testing before using as a run-loss signal. |
| Run save | `MegaCrit.Sts2.Core.Saves.Managers.RunSaveManager` | `SaveRun` | Potential | Could fire repeatedly. Needs runtime testing before relying on it. |
| Progress save update | `MegaCrit.Sts2.Core.Saves.Managers.ProgressSaveManager` | `UpdateWithRunData` | Potential | Receives serialized run data and a `victory` boolean. Promising post-run candidate, but not runtime-confirmed. |
| Run history save | `MegaCrit.Sts2.Core.Saves.Managers.RunHistorySaveManager` | `SaveHistory` | Potential | Receives a `RunHistory`. Promising archival/post-run candidate, but not runtime-confirmed. |
| Multiplayer abandon | `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.RunLobby` | `AbandonRun` | Potential | Multiplayer/lobby abandon surface found by inspection. Needs testing for local-only and multiplayer paths. |
| Game-over screen | `MegaCrit.Sts2.Core.Nodes.NRun` | `ShowGameOverScreen` | Potential | UI-level game-over surface taking `SerializableRun`. Useful lead, but likely too UI-specific for durable run-end tracking. |
| UI embark | Character select screen methods | `OnEmbarkPressed` / `BeginRun` | Possibility | UI-level start methods may exist, but more research is needed before treating them as durable hooks. |
