# `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby`

## Properties

| Name | Type |
|---|---|
| `Act1` | `System.String` |
| `Ascension` | `System.Int32` |
| `DailyTime` | `System.Nullable<MegaCrit.Sts2.Core.Daily.TimeServerResult>` |
| `GameMode` | `MegaCrit.Sts2.Core.Runs.GameMode` |
| `HandshakeTimeout` | `System.Int32` |
| `InputSynchronizer` | `MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.PeerInputSynchronizer` |
| `LobbyListener` | `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.IStartRunLobbyListener` |
| `LocalPlayer` | `MegaCrit.Sts2.Core.Entities.Multiplayer.LobbyPlayer` |
| `MaxAscension` | `System.Int32` |
| `MaxPlayers` | `System.Int32` |
| `Modifiers` | `System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel>` |
| `NetService` | `MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService` |
| `Players` | `System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Multiplayer.LobbyPlayer>` |
| `Seed` | `System.String` |

## Methods

| Name | Return Type | Parameters |
|---|---|---|
| `<get_LocalPlayer>b__51_0` | `System.Boolean` | `MegaCrit.Sts2.Core.Entities.Multiplayer.LobbyPlayer p` |
| `<SetReady>b__88_0` | `System.Boolean` | `MegaCrit.Sts2.Core.Entities.Multiplayer.LobbyPlayer p` |
| `AddLocalHostPlayer` | `System.Nullable<MegaCrit.Sts2.Core.Entities.Multiplayer.LobbyPlayer>` | `MegaCrit.Sts2.Core.Unlocks.UnlockState unlocks`, `System.Int32 maxMultiplayerAscension` |
| `AddLocalHostPlayerInternal` | `System.Nullable<MegaCrit.Sts2.Core.Entities.Multiplayer.LobbyPlayer>` | `MegaCrit.Sts2.Core.Unlocks.SerializableUnlockState unlockState`, `System.Int32 maxMultiplayerAscension` |
| `BeginHandshakeTimeout` | `System.Threading.Tasks.Task` | `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby+ConnectingPlayer connectingPlayer` |
| `BeginRunForAllPlayers` | `System.Void` | `System.String seed`, `System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers` |
| `BeginRunIfAllPlayersReady` | `System.Void` |  |
| `BeginRunLocally` | `System.Void` | `System.String seed`, `System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers` |
| `ChangeCharacter` | `System.Void` | `System.UInt64 playerId`, `MegaCrit.Sts2.Core.Models.CharacterModel character`, `System.Boolean isRandomCharacterResolution` |
| `CleanUp` | `System.Void` | `System.Boolean disconnectSession` |
| `GetAct` | `MegaCrit.Sts2.Core.Models.ActModel` | `System.String act1Key` |
| `GetMaxAscensionAcrossAllCharacters` | `System.Int32` |  |
| `GetUnlockState` | `MegaCrit.Sts2.Core.Unlocks.UnlockState` |  |
| `HandleAscensionChangedMessage` | `System.Void` | `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.LobbyAscensionChangedMessage message`, `System.UInt64 _` |
| `HandleClientLoadJoinRequestMessage` | `System.Void` | `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLoadJoinRequestMessage _`, `System.UInt64 senderId` |
| `HandleClientLobbyJoinRequestMessage` | `System.Void` | `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLobbyJoinRequestMessage message`, `System.UInt64 senderId` |
| `HandleClientRejoinRequestMessage` | `System.Void` | `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientRejoinRequestMessage _`, `System.UInt64 senderId` |
| `HandleLobbyBeginRunMessage` | `System.Void` | `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.LobbyBeginRunMessage message`, `System.UInt64 senderId` |
| `HandleLobbyPlayerChangedCharacterMessage` | `System.Void` | `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.LobbyPlayerChangedCharacterMessage message`, `System.UInt64 senderId` |
| `HandleModifiersChangedMessage` | `System.Void` | `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.LobbyModifiersChangedMessage message`, `System.UInt64 _` |
| `HandlePlayerJoinedMessage` | `System.Void` | `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.PlayerJoinedMessage message`, `System.UInt64 senderId` |
| `HandlePlayerLeftMessage` | `System.Void` | `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.PlayerLeftMessage message`, `System.UInt64 senderId` |
| `HandlePlayerReadyMessage` | `System.Void` | `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.LobbyPlayerSetReadyMessage message`, `System.UInt64 senderId` |
| `HandleSeedChangedMessage` | `System.Void` | `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.LobbySeedChangedMessage message`, `System.UInt64 _` |
| `InitializeFromMessage` | `System.Void` | `MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLobbyJoinResponseMessage message` |
| `IsAboutToBeginGame` | `System.Boolean` |  |
| `IsAscensionEpochRevealed` | `System.Boolean` | `MegaCrit.Sts2.Core.Models.ModelId characterId` |
| `OnConnectedToClientAsHost` | `System.Void` | `System.UInt64 playerId` |
| `OnDisconnected` | `System.Void` | `MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info` |
| `OnDisconnectedFromClientAsHost` | `System.Void` | `System.UInt64 playerId`, `MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info` |
| `RemoveConnectingPlayer` | `System.Void` | `System.UInt64 playerId` |
| `SetLocalCharacter` | `System.Void` | `MegaCrit.Sts2.Core.Models.CharacterModel character` |
| `SetModifiers` | `System.Void` | `System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers` |
| `SetReady` | `System.Void` | `System.Boolean ready` |
| `SetSeed` | `System.Void` | `System.String seed` |
| `SetSingleplayerAscensionAfterCharacterChanged` | `System.Void` | `MegaCrit.Sts2.Core.Models.ModelId characterId` |
| `SyncAscensionChange` | `System.Void` | `System.Int32 ascension` |
| `TryAddPlayerInFirstAvailableSlot` | `System.Nullable<MegaCrit.Sts2.Core.Entities.Multiplayer.LobbyPlayer>` | `MegaCrit.Sts2.Core.Unlocks.SerializableUnlockState unlockState`, `System.Int32 maxAscensionUnlocked`, `System.UInt64 playerId` |
| `UpdateMaxMultiplayerAscension` | `System.Void` |  |
| `UpdatePreferredAscension` | `System.Void` |  |


