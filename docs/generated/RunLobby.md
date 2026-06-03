# `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.RunLobby`

## Properties

| Name | Type |
|---|---|
| `ConnectedPlayerIds` | `System.Collections.Generic.IReadOnlyCollection<System.UInt64>` |
| `GameMode` | `MegaCrit.Sts2.Core.Runs.GameMode` |

## Methods

| Name | Return Type | Parameters |
|---|---|---|
| `AbandonRun` | `System.Void` |  |
| `Dispose` | `System.Void` |  |
| `HandleClientLoadJoinRequestMessage` | `System.Void` | `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLoadJoinRequestMessage _`, `System.UInt64 senderId` |
| `HandleClientLobbyJoinRequestMessage` | `System.Void` | `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLobbyJoinRequestMessage _`, `System.UInt64 senderId` |
| `HandleClientRejoinRequestMessage` | `System.Void` | `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientRejoinRequestMessage message`, `System.UInt64 senderId` |
| `HandlePlayerLeftMessage` | `System.Void` | `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.PlayerLeftMessage message`, `System.UInt64 _` |
| `HandlePlayerRejoinedMessage` | `System.Void` | `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.PlayerRejoinedMessage message`, `System.UInt64 _` |
| `HandleRunAbandonedMessage` | `System.Void` | `MegaCrit.Sts2.Core.Multiplayer.Messages.Game.RunAbandonedMessage message`, `System.UInt64 _` |
| `OnConnectedToClientAsHost` | `System.Void` | `System.UInt64 playerId` |
| `OnDisconnected` | `System.Void` | `MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info` |
| `OnDisconnectedFromClientAsHost` | `System.Void` | `System.UInt64 playerId`, `MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info` |

