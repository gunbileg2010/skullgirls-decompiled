using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PhotonRealtimeService : MonoBehaviour
{
	public const string kInitialConnectionErrorLocKey = "SyncPvp_Photon_Error_InitialConnection";

	public const string kCreateJoinRoomErrorLocKey = "SyncPvp_Photon_Error_CreateJoinRoom";

	public const string kWaitingForOpponentErrorLocKey = "SyncPvp_Photon_Error_WaitingForOpponent";

	public const string kFindOpponentConnectionErrorLocKey = "SyncPvp_Photon_Error_ConnectingToOpponent";

	public const string kPrivateMatchConnectionErrorLocKey = "SyncPvp_Photon_Error_ConnectingToPrivateMatch";

	public const string kPrivateMatchRegionCodeErrorLocKey = "SyncPvp_Photon_Error_RegionCodeError";

	public const string kPrivateMatchEventIdMismatch = "SyncPvp_Photon_Error_EventIdMismatch";

	public const string kPrivateMatchRoomCodeInvalidLength = "SyncPvp_Photon_Error_RoomCodeInvalidLength";

	private SyncFightManager.MatchmakingMode matchmakingMode;

	private const string kAppId = "4faf5ba4-6f5e-4ce6-b471-77d1b6d805ca";

	private const string kAppVersion = "1.0";

	private PhotonRealtimeHelper helper;

	private SyncPvpEventData syncPvpEventData;

	private int playerFS;

	private string privateMatchRoomCode;

	private bool intentionalPrivateDisconnect;

	private Action<bool> initializeAndConnectCallback;

	public event Action<bool> ConnectedToGameServer
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

	public event Action DisconnectedFromServer
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

	public event Action OpponentConnected
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

	public event SyncFightManager.OnMatchmakingStatusChange OnMatchmakingStatusChanged
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

	private void Update()
	{
	}

	public void HostPrivateMatch(SyncPvpEventData syncPvpEventData, Action<bool> callback, bool isConnectionTest = false)
	{
	}

	public void JoinPrivateMatch(SyncPvpEventData syncPvpEventData, string roomCode, Action<bool> callback, bool isConnectionTest = false)
	{
	}

	public void FindOpponent(SyncPvpEventData syncPvpEventData, int playerFS, Action<bool> callback, bool isConnectionTest = false)
	{
	}

	public void Disconnect()
	{
	}

	public bool IsActingAsHost()
	{
		return false;
	}

	public int GetEstimatedPingMs()
	{
		return 0;
	}

	public int GetPingMs()
	{
		return 0;
	}

	public void GetAllPings(out int direct, out int relay, out int matchmaking)
	{
		direct = default(int);
		relay = default(int);
		matchmaking = default(int);
	}

	public bool UsingRelayServers()
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

	public string GetRoomCode()
	{
		return null;
	}

	public string GetDebugConsoleConnectionStatus()
	{
		return null;
	}

	public void SendGGPODataToOpponent(byte[] bytes, int length)
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

	private void InitializeAndConnect(Action<bool> callback, bool isConnectionTest = false)
	{
	}

	private void InternalOnFetchedRegions(string bestRegionCode, string errorCode)
	{
	}

	private void InternalOnConnectedToMasterServer(bool success, string errorCode)
	{
	}

	private void InternalOnConnectedToGameServer(bool success, string errorCode)
	{
	}

	private void ErrorWhileWaitingForOpponent(string errorCode)
	{
	}

	private void InternalOnOpponentConnected(bool success, bool canRetryMatchmaking = false, string errorCode = null)
	{
	}

	private void OnMidMatchmakingHandshakeCallback(string messageLocKey, bool intentionalDisconnect = false)
	{
	}

	private void InternalOnMidMatchChecksum(int frame, int checksum)
	{
	}

	private void InternalOnWantRematch(bool wantRematch, bool startRematch)
	{
	}
}
