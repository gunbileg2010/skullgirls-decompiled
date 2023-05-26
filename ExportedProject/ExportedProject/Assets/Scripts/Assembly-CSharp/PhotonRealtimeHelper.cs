using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Realtime;
using UdpKit;

public class PhotonRealtimeHelper : LoadBalancingClient
{
	public delegate void FetchedRegionsDelegate(string regionCode, string errorCode = null);

	public delegate void ConnectedToServerDelegate(bool success, string errorCode = null);

	public delegate void ErrorWhileWaitingForOpponentDelegate(string errorCode);

	public delegate void OpponentConnectedDelegate(bool success, bool canRetryMatchmaking = false, string errorCode = null);

	public delegate void OpponentHandshakeProgressDelegate(string messageLocKey, bool intentionalDisconnect = false);

	private enum InternalState
	{
		Idle = 0,
		FetchingRegions = 1,
		ConnectingToRegion = 2,
		EnteringMatchmaking = 3,
		WaitingForOpponent = 4,
		ConnectingToOpponent = 5,
		HostingPrivateMatch = 6,
		JoiningPrivateMatch = 7
	}

	private struct BlacklistedUser
	{
		public string userPublicId;

		public long blacklistTimestamp;

		public BlacklistedUser(string publicUserId, long blacklistTimestamp)
		{
		}
	}

	public const string kXsProfileKey = "XsProfile";

	public const byte kGGPODataEventCode = 1;

	public const byte kMidMatchChecksumEventCode = 2;

	public const byte kPingMeasurementSend = 4;

	public const byte kPingMeasurementReply = 5;

	public const byte kHtC_InitialDataReady = 10;

	public const byte kCtH_InitialDataReady = 11;

	public const byte kMutual_InitialDataSend = 12;

	public const byte kHtC_ConnectionDiscoveryComplete = 13;

	public const byte kCtH_ConnectionDiscoveryComplete = 14;

	public const byte kHtC_FightAccepted = 15;

	public const byte kHtC_FightRejected = 16;

	public const byte kCtH_FightApprovedConfirmed = 17;

	public const byte kCtH_FightRejectionConfirmed = 18;

	public const byte kHtC_PrivateMatchRejected = 19;

	public const byte kHtC_WantRematchEventCode = 20;

	public const byte kCtH_WantRemathEventCode = 21;

	public const byte kHtC_ConfirmRematch = 22;

	public const string kFailedInitialNetworkCallErrorCode = "p001";

	public const string kMissingParametersErrorCode = "p002";

	public const string kPrivateMatchConnectErrorCode = "p003";

	public const string kLeavingRoomError = "p004";

	public const string kConnectionRejectedByDebugSettings = "p005";

	public const string kPrivateMatchInvalidCodeLength = "p006";

	public const string kPrivateMatchMismatchEventId = "p007";

	public const string kPrivateMatchFailedToJoinRoom = "p008";

	public const string kPrivateMatchInvalidRegionCode = "p009";

	public const string kMidHandshakeLocKeyWaitingInRoom = "SyncPvp_Photon_Status_WaitingInRoom";

	public const string kMidHandshakeLocKeySendingData = "SyncPvp_Photon_Status_SendingData";

	public const string kMidHandshakeLocKeyDiscoveringDirectConnections = "SyncPvp_Photon_Status_DirectConnectDiscovery";

	public const string kMidHandshakeLocKeySentConnectionResults = "SyncPvp_Photon_Status_SendingConnectResults";

	public const string kMidHandshakeLocKeyPrivateMatchAccepted = "SyncPvp_Photon_Status_PrivateMatchAccepted";

	public const string kMidHandshakeLocKeyPublicMatchAccepted = "SyncPvp_Photon_Status_PublicMatchAccepted";

	public const string kMidHandshakeLocKeyPublicMatchRejected = "SyncPvp_Photon_Status_PublicMatchRejected";

	private static readonly Dictionary<string, string> kPhotonRelayServerCharMap;

	private static byte[] scratchBytes;

	private static byte[] tinyScratchBytes;

	private InternalState internalState;

	private char eventLobbyId;

	private int playerFS;

	private int myPingThresholdMs;

	private bool myAllowRelayConnection;

	private bool isPrivateMatch;

	private string privateMatchRoomCode;

	private string privateMatchRegionCode;

	private int lastEstimatedPingMs;

	private Player opponent;

	private DirectConnectHelper directConnectionHelper;

	private bool recievedInitialConnectionData;

	private bool recievedClientConnectionData;

	private bool localPlayerWantsRematch;

	private bool isConnectionTest;

	private static List<BlacklistedUser> blacklistedUsers;

	private const int kRoomCodeRandomPortionLength = 3;

	private const string kBase36Digits = "0123456789abcdefghijklmnopqrstuvwxyz";

	private long lastSentPingTimestamp;

	private long lastFrameTimestamp;

	private const long kTimeInMsBetweenPingsWhileFindingOpponent = 50L;

	private const long kTimeInMsBetweenPignsDefault = 500L;

	private static RingBuffer<int> measuredPings;

	private static XsProfile xsProfile;

	private const string kJoinRandomRoomSQLLobbyFilterBase = "(C0 BETWEEN {1} AND {2}) AND C1 <= {0} AND C2 >= {0} AND C4 == '{3}' AND C5 == {4}";

	private static readonly string[] kSQLLobbyCustomRoomPropertiesForLobby;

	public event FetchedRegionsDelegate FetchedRegions
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

	public event ConnectedToServerDelegate ConnectedToMasterServer
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

	public event ConnectedToServerDelegate ConnectedToGameServer
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

	public event ErrorWhileWaitingForOpponentDelegate ErrorWhileWaitingForOpponent
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

	public event OpponentConnectedDelegate OpponentConnected
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

	public event OpponentHandshakeProgressDelegate MidMatchmakingHandshakeCallback
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

	public event SyncFightManager.MidMatchChecksum OnOpponentSentMidMatchChecksum
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

	public event SyncFightManager.WantsRematch OnOpponentSentWantRematch
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

	public event Action OpponentDisconnected
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

	public event Action Disconnected
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

	public PhotonRealtimeHelper(string appId, string appVersion, bool isConnectionTest = false)
	{
	}

	public void FetchRegionsAndConnectToBest()
	{
	}

	public void ConnectToRegion(string regionCode)
	{
	}

	public void FindOpponent(char eventLobbyId, int playerFS, int pingThreshold, bool allowRelay)
	{
	}

	public void HostPrivateMatch(char eventLobbyId, bool allowRelay)
	{
	}

	public bool ParseRegionCodeForPrivateMatch(string roomName, out string regionCode)
	{
		regionCode = null;
		return false;
	}

	public void JoinPrivateMatch(char eventLobbyId, string roomCode, bool allowRelay)
	{
	}

	public void CallDisconnect()
	{
	}

	public bool IsHost()
	{
		return false;
	}

	public Player GetOpponent()
	{
		return null;
	}

	public bool CanUDPConnect()
	{
		return false;
	}

	public int GetUDPListenPort()
	{
		return 0;
	}

	public string GetUDPOpponentIP()
	{
		return null;
	}

	public int GetUDPOpponentPort()
	{
		return 0;
	}

	public string GetDebugConsoleConnectionStatus()
	{
		return null;
	}

	public string GetRoomCode()
	{
		return null;
	}

	public string GetOpponentPublicId()
	{
		return null;
	}

	public string GetOpponentDisplayName()
	{
		return null;
	}

	public object GetOpponentCustomProperty(object key)
	{
		return null;
	}

	public int GetEstimatedPingMs()
	{
		return 0;
	}

	public void GetAllPings(out int direct, out int relay, out int matchmaking)
	{
		direct = default(int);
		relay = default(int);
		matchmaking = default(int);
	}

	public int GetRelayPingMs()
	{
		return 0;
	}

	public void InternalUpdate()
	{
	}

	public bool SendMidMatchChecksum(int frame, int checksum)
	{
		return false;
	}

	public bool SendWantRematch(bool wantRematch)
	{
		return false;
	}

	public override void OnOperationResponse(OperationResponse operationResponse)
	{
	}

	public override void OnEvent(ExitGames.Client.Photon.EventData photonEvent)
	{
	}

	private void DisconnectFromRoom()
	{
	}

	public override void OnStatusChanged(StatusCode statusCode)
	{
	}

	private void OnStateChanged(ClientState fromState, ClientState toState)
	{
	}

	private void SendInitialSyncDataToOpponent()
	{
	}

	private void SendClientConnectionDataToHost()
	{
	}

	private ClientDataToken CreateClientDataToken()
	{
		return null;
	}

	private ServerDataToken CreateServerDataToken()
	{
		return null;
	}

	private void ParseClientDataToken(ClientDataToken clientDataToken)
	{
	}

	private void ParseServerDataToken(ServerDataToken serverDataToken)
	{
	}

	private bool DebugIsConnectionAllowed()
	{
		return false;
	}

	private string BuildSQLLobbyFilterString(int playerFS)
	{
		return null;
	}

	private Hashtable BuildSQLLobbyCustomRoomProperties(int playerFS)
	{
		return null;
	}

	private int GetMinFSThreshold(int playerFS)
	{
		return 0;
	}

	private int GetMaxFSThreshold(int playerFS)
	{
		return 0;
	}

	private int GetBuildType()
	{
		return 0;
	}

	private static char PickRandomRoomCodeChar()
	{
		return '\0';
	}

	private void DebugLogUdpPacketSize(UdpPacket packet)
	{
	}
}
