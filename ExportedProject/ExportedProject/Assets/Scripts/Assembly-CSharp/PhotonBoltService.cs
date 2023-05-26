using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Bolt;
using UdpKit;

public class PhotonBoltService : GlobalEventListener
{
	private enum BoltRequestState
	{
		Waiting = 0,
		Success = 1,
		Failure = 2
	}

	private Map<Guid, UdpSession> sessionList;

	private BoltRequestState startRequestState;

	private BoltRequestState createSessionRequestState;

	private BoltRequestState connectRequestState;

	private BoltRequestState getOpponentDataState;

	private UdpChannelName dataSync;

	private UdpChannelName ggpoPackets;

	private string opponentDisplayName;

	private BoltConnection opponentConnection;

	private bool matchIsFull;

	private static byte[] scratchBytes;

	public event Action ConnectedToServer
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

	private void Awake()
	{
	}

	public void FindOpponent(Action<bool> callback)
	{
	}

	public void Disconnect()
	{
	}

	public bool IsActingAsHost()
	{
		return false;
	}

	public int GetPingMs()
	{
		return 0;
	}

	public bool UsingRelayServers()
	{
		return false;
	}

	public int GetPrivatePort()
	{
		return 0;
	}

	public string GetPublicIp()
	{
		return null;
	}

	public int GetPublicPort()
	{
		return 0;
	}

	public string GetOpponentIp()
	{
		return null;
	}

	public int GetOpponentPort()
	{
		return 0;
	}

	public string GetOpponentDisplayName()
	{
		return null;
	}

	public void SendGGPODataToOpponent(byte[] bytes, int length)
	{
	}

	public override void BoltStartBegin()
	{
	}

	public override void BoltStartDone()
	{
	}

	public override void BoltStartFailed()
	{
	}

	public override void BoltShutdownBegin(AddCallback registerDoneCallback, UdpConnectionDisconnectReason disconnectReason)
	{
	}

	public override void SessionListUpdated(Map<Guid, UdpSession> sessionList)
	{
	}

	public override void SessionCreated(UdpSession session)
	{
	}

	public override void SessionCreationFailed(UdpSession session)
	{
	}

	public override void SessionConnectFailed(UdpSession session, IProtocolToken token)
	{
	}

	public override void ConnectAttempt(UdpEndPoint endpoint, IProtocolToken token)
	{
	}

	public override void ConnectFailed(UdpEndPoint endpoint, IProtocolToken token)
	{
	}

	public override void ConnectRequest(UdpEndPoint endpoint, IProtocolToken token)
	{
	}

	public override void Connected(BoltConnection connection)
	{
	}

	public override void ConnectRefused(UdpEndPoint endpoint, IProtocolToken token)
	{
	}

	public override void Disconnected(BoltConnection connection)
	{
	}

	public override void StreamDataReceived(BoltConnection connection, UdpStreamData data)
	{
	}

	private IEnumerator DoFindSyncPvpOpponent(Action<bool> matchmakingCallback)
	{
		return null;
	}

	private ClientDataToken CreateClientDataToken()
	{
		return null;
	}

	private void ParseClientDataToken(ClientDataToken clientDataToken)
	{
	}

	private ServerDataToken CreateServerDataToken()
	{
		return null;
	}

	private void ParseServerDataToken(ServerDataToken serverDataToken)
	{
	}
}
