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
Seed=K0C8TK126Z
GameMode=Standard
Ascension=0
Players=2
Names=Shashakar, Logain Ablar
```

Lobby player objects:

```text
LobbyPlayer[0]: ToString=Player 76561198008501134, IRONCLAD
LobbyPlayer[1]: ToString=Player 76561198141181565, IRONCLAD
```

Run-state player identities:

```text
Player.NetId=76561198008501134
Player.NetId=76561198141181565
```

## Useful finding

`LobbyPlayer` did not expose obvious public properties in the initial reflection log, but `ToString()` contained useful player ID and character data.

Example:

```text
Player 76561198008501134, IRONCLAD
```

Parse this into:

```json
{
  "platformPlayerId": "76561198008501134",
  "character": "Ironclad",
  "raw": "Player 76561198008501134, IRONCLAD"
}
```

Display names were captured separately from lobby/platform context:

```text
Shashakar
Logain Ablar
```

The useful final join is:

```text
Player.NetId <-> LobbyPlayer platform id <-> display name
```
