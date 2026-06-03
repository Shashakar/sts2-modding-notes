# Glossary

## RunState

The central run object created when a run begins. `RunState.CreateForNewRun` is currently the best confirmed run-start hook.

## Player

Runtime player object in `MegaCrit.Sts2.Core.Entities.Players.Player`.

Useful for character, platform ID, deck, relics, potions, and gold.

## LobbyPlayer

Multiplayer lobby player object. Initial reflection did not show obvious public properties, but `ToString()` exposed platform ID and character.

## NetId

Observed `UInt64` player identity. In multiplayer testing, it matched Steam-style IDs.

Prefer exposing this externally as `platformPlayerId`.

## RunKey

A stable dedupe key for an actual run. Suggested shape:

```text
seed|gameMode|ascension|platformPlayerId1,platformPlayerId2
```

## EventId

Unique ID for a local event write. Useful for tracing, but not stable across retries if events are regenerated.

## JSONL

JSON Lines format. One JSON object per line. Useful for append-only event logs.
