using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SyncFightManager : MonoBehaviour
{
	public delegate void OnMatchmakingStatusChange(MatchmakingStatus status, string statusLoc, bool isError = false, string errorCode = "", string errorMessage = "", string errorDetail = "");

	public enum ConnectionMode
	{
		DirectConnection = 0,
		RelayServer = 1
	}

	public enum ClientState
	{
		Idle = 0,
		Matchmaking = 1,
		Connected = 2
	}

	public enum MatchmakingMode
	{
		HostPrivate = 0,
		JoinPrivate = 1,
		FindOpponent = 2
	}

	public enum MatchmakingStatus
	{
		Initialzing = 0,
		WaitingForOpponent = 1,
		Handshaking = 2,
		OpponentConnected = 3,
		MatchRejected = 4
	}

	public delegate void MidMatchChecksum(int frame, int checksum);

	public delegate void WantsRematch(bool wantRematch, bool startRematch);

	[SerializeField]
	private int disconnectNotifyAfterSecs;

	[SerializeField]
	private int disconnectAfterSecs;

	private PhotonRealtimeService photon;

	private ClientState clientState;

	private ConnectionMode connectionMode;

	private bool cachedIsHost;

	private bool isPrivateMatch;

	private int failureCount;

	private DateTime matchmakingStart;

	private DateTime lastSeenTime;

	private static XsProfile opponentProfile;

	public event Action<string> ConnectedToGameServer
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

	public event Action ReadyToBeginFight
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

	public event MidMatchChecksum OnOpponentSentMidMatchChecksum
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

	public event WantsRematch OnOpponentSentWantsRematch
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

	public event OnMatchmakingStatusChange OnMatchmakingStatusChanged
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

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnApplicationQuit()
	{
	}

	public void HostPrivateMatch(SyncPvpEventData syncPvpEventData, Action<bool> callback)
	{
	}

	public void JoinPrivateMatch(SyncPvpEventData syncPvpEventData, string roomCode, Action<bool> callback)
	{
	}

	public void FindOpponent(SyncPvpEventData syncPvpEventData, int myFighterScore, Action<bool> callback)
	{
	}

	public void Disconnect()
	{
	}

	public void PrepareGGPO(bool runSyncTest = false)
	{
	}

	public string GetOpponentPublicId()
	{
		return null;
	}

	public string GetOpponentDisplayName()
	{
		return null;
	}

	public string GetRoomCode()
	{
		return null;
	}

	public XsProfile GetOpponentXsProfile()
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

	public bool IsDirectConnect()
	{
		return false;
	}

	public int GetPingMs()
	{
		return 0;
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

	public ConnectionMode GetConnectionMode()
	{
		return default(ConnectionMode);
	}

	public ClientState GetState()
	{
		return default(ClientState);
	}

	public int GetFailureCount()
	{
		return 0;
	}

	public int GetMatchmakingDuration()
	{
		return 0;
	}

	public bool IsPrivateMatch()
	{
		return false;
	}

	public bool IsHost()
	{
		return false;
	}

	public bool SendMidMatchChecksum(int frame, int checksum)
	{
		return false;
	}

	public bool SendWantRematch(bool wantRematch)
	{
		return false;
	}

	private void OnConnectedToServer(bool success)
	{
	}

	private void OnDisconnectedFromServer()
	{
	}

	private void OnOpponentConnected()
	{
	}

	private void OnOpponentDisconnected()
	{
	}

	private void OnSendGGPOData(byte[] bytes, int length)
	{
	}

	private void InternalOnMatchmakingStatusChanged(MatchmakingStatus status, string statusLoc, bool isError = false, string errorCode = "", string errorMessage = "", string errorDetail = "")
	{
	}

	private void InternalOnMidMatchChecksum(int frame, int checksum)
	{
	}

	private void InternalOnWantRematch(bool wantRematch, bool startRematch)
	{
	}
}
