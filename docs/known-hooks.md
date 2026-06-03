# Known Hooks

## Certainty labels

- **Confirmed**: verified in a running mod
- **Candidate**: found via reflection but not runtime-tested
- **Speculative**: inferred but not proven
- **Rejected**: considered but not recommended

| Purpose | Type | Method | Status | Notes |
|---|---|---|---|---|
| Run started | `MegaCrit.Sts2.Core.Runs.RunState` | `CreateForNewRun` | Confirmed | Best durable run-start hook. Provides players, acts, modifiers, game mode, ascension, seed. |
| Local lobby start | `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby` | `BeginRunLocally` | Confirmed | Captures lobby context before run state creation. Can duplicate with `BeginRunForAllPlayers`. |
| All-player lobby start | `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby` | `BeginRunForAllPlayers` | Confirmed | Useful for multiplayer roster capture. Can fire in same start path as local method. |
| Player creation | `MegaCrit.Sts2.Core.Entities.Players.Player` | `CreateForNewRun` | Candidate | Potential lower-level per-player hook. Not needed for current run tracker. |
| Combat start | `MegaCrit.Sts2.Core.Combat.CombatManager` | `StartCombatInternal` | Candidate | Useful for future combat tracking; too late for run-start tracking. |
| Run save | `MegaCrit.Sts2.Core.Saves.Managers.RunSaveManager` | `SaveRun` | Candidate / likely noisy | Could fire repeatedly. Not recommended for initial run-start tracking. |
| UI embark | Character select screen methods | `OnEmbarkPressed` / `BeginRun` | Rejected | UI intent, not as durable as `RunState.CreateForNewRun`. |
