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
| Run save | `MegaCrit.Sts2.Core.Saves.Managers.RunSaveManager` | `SaveRun` | Potential | Could fire repeatedly. Needs runtime testing before relying on it. |
| UI embark | Character select screen methods | `OnEmbarkPressed` / `BeginRun` | Possibility | UI-level start methods may exist, but more research is needed before treating them as durable hooks. |
