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

Prefer exposing this externally as a platform player ID rather than a Steam-specific name until other platforms are tested.
