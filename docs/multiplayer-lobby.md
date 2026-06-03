# Multiplayer Lobby

## Confirmed lobby hooks

**Status:** Confirmed

```text
Type:   MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby
Method: BeginRunLocally

Type:   MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby
Method: BeginRunForAllPlayers
```

Both methods were patchable.

## Duplicate capture behavior

Both lobby methods can fire for the same run start path.

Confirmed duplicate log pattern:

```text
Captured lobby roster...
Captured lobby roster...
```

Use a short dedupe guard keyed by:

```text
seed + gameMode + ascension + playerCount
```

Skip duplicate captures within about 3 seconds.

## Confirmed multiplayer lobby example

```text
Seed=<seed>
GameMode=Standard
Ascension=0
Players=2
Names=<player one>, <player two>
```

Lobby player objects:

```text
LobbyPlayer[0]: ToString=Player <platform id>, IRONCLAD
LobbyPlayer[1]: ToString=Player <platform id>, IRONCLAD
```

Run-state player identities:

```text
Player.NetId=<platform id>
Player.NetId=<platform id>
```

## Useful finding

`LobbyPlayer` did not expose obvious public properties in the initial reflection log, but `ToString()` contained useful player ID and character data.

Example:

```text
Player <platform id>, IRONCLAD
```

Parse this into:

```json
{
  "platformPlayerId": "<platform id>",
  "character": "Ironclad",
  "raw": "Player <platform id>, IRONCLAD"
}
```

Display names were captured separately from lobby/platform context:

```text
<player one>
<player two>
```

The useful final join is:

```text
Player.NetId <-> LobbyPlayer platform id <-> display name
```
