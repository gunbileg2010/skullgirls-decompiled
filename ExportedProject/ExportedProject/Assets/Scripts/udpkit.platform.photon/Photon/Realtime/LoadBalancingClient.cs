using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	public class LoadBalancingClient : IPhotonPeerListener
	{
		private bool didAuthenticate;

		public AuthModeOption AuthMode;

		public EncryptionMode EncryptionMode;

		public ConnectionProtocol ExpectedProtocol;

		private string tokenCache;

		public string NameServerHost;

		public string NameServerHttp;

		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		private ClientState state;

		public ConnectionCallbacksContainer ConnectionCallbackTargets;

		public MatchMakingCallbacksContainer MatchMakingCallbackTargets;

		internal InRoomCallbacksContainer InRoomCallbackTargets;

		internal LobbyCallbacksContainer LobbyCallbackTargets;

		internal WebRpcCallbacksContainer WebRpcCallbackTargets;

		public bool EnableLobbyStatistics;

		private readonly List<TypedLobbyInfo> lobbyStatistics;

		private JoinType lastJoinType;

		private EnterRoomParams enterRoomParamsCache;

		private OperationResponse failedRoomEntryOperation;

		private const int FriendRequestListMax = 512;

		private string[] friendListRequested;

		public RegionHandler RegionHandler;

		public LoadBalancingPeer LoadBalancingPeer
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string AppVersion
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string AppId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public AuthenticationValues AuthValues
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private string TokenForInit => null;

		public bool IsUsingNameServer
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string NameServerAddress => null;

		public bool UseAlternativeUdpPorts
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public string CurrentServerAddress => null;

		public string MasterServerAddress
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string GameServerAddress
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		public ServerConnection Server
		{
			[CompilerGenerated]
			get
			{
				return default(ServerConnection);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ClientState State
		{
			get
			{
				return default(ClientState);
			}
			set
			{
			}
		}

		public bool IsConnected => false;

		public bool IsConnectedAndReady => false;

		public DisconnectCause DisconnectedCause
		{
			[CompilerGenerated]
			get
			{
				return default(DisconnectCause);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool InLobby => false;

		public TypedLobby CurrentLobby
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public Player LocalPlayer
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public string NickName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string UserId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Room CurrentRoom
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool InRoom => false;

		internal int PlayersOnMasterCount
		{
			[CompilerGenerated]
			set
			{
			}
		}

		internal int PlayersInRoomsCount
		{
			[CompilerGenerated]
			set
			{
			}
		}

		internal int RoomsCount
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public string CloudRegion
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public event Action<ClientState, ClientState> StateChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<EventData> EventReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<OperationResponse> OpResponseReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public LoadBalancingClient(ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		private string GetNameServerAddress()
		{
			return null;
		}

		public virtual bool Connect()
		{
			return false;
		}

		public bool ConnectToNameServer()
		{
			return false;
		}

		public bool ConnectToRegionMaster(string region)
		{
			return false;
		}

		private bool ConnectToGameServer()
		{
			return false;
		}

		public void Disconnect()
		{
		}

		private void DisconnectToReconnect()
		{
		}

		private bool CallAuthenticate()
		{
			return false;
		}

		public void Service()
		{
		}

		private bool OpGetRegions()
		{
			return false;
		}

		public bool OpJoinLobby(TypedLobby lobby)
		{
			return false;
		}

		public bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams = null)
		{
			return false;
		}

		public bool OpCreateRoom(EnterRoomParams enterRoomParams)
		{
			return false;
		}

		public bool OpJoinRoom(EnterRoomParams enterRoomParams)
		{
			return false;
		}

		public bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return false;
		}

		public bool OpSetPropertiesOfRoom(Hashtable gameProperties, Hashtable expectedProperties = null, WebFlags webFlags = null)
		{
			return false;
		}

		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return false;
		}

		private void ReadoutProperties(Hashtable gameProperties, Hashtable actorProperties, int targetActorNr)
		{
		}

		private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr)
		{
			return null;
		}

		public void ChangeLocalID(int newID)
		{
		}

		private void GameEnteredOnGameServer(OperationResponse operationResponse)
		{
		}

		private void UpdatedActorList(int[] actorsInGame)
		{
		}

		protected internal virtual Player CreatePlayer(string actorName, int actorNumber, bool isLocal, Hashtable actorProperties)
		{
			return null;
		}

		protected internal virtual Room CreateRoom(string roomName, RoomOptions opt)
		{
			return null;
		}

		public virtual void DebugReturn(DebugLevel level, string message)
		{
		}

		private void CallbackRoomEnterFailed(OperationResponse operationResponse)
		{
		}

		public virtual void OnOperationResponse(OperationResponse operationResponse)
		{
		}

		public virtual void OnStatusChanged(StatusCode statusCode)
		{
		}

		public virtual void OnEvent(EventData photonEvent)
		{
		}

		private void SetupEncryption(Dictionary<byte, object> encryptionData)
		{
		}

		public void AddCallbackTarget(object target)
		{
		}

		public void RemoveCallbackTarget(object target)
		{
		}
	}
}
