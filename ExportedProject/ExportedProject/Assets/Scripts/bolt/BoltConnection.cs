using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Bolt;
using Bolt.Channel;
using UdpKit;

[Documentation]
public class BoltConnection : BoltObject, IBoltListNode<BoltConnection>
{
	private UdpConnection _udpConnection;

	private BoltChannel[] _channels;

	private int _framesToStep;

	private int _packetsReceived;

	private int _packetCounter;

	private int _remoteFrameDiff;

	private int _remoteFrameActual;

	private int _remoteFrameEstimated;

	private bool _remoteFrameAdjust;

	private int _bitsSecondIn;

	private int _bitsSecondInAcc;

	private int _bitsSecondOut;

	private int _bitsSecondOutAcc;

	internal PacketTypeStats _commandStats;

	internal PacketTypeStats _stateStats;

	internal PacketTypeStats _eventsStats;

	internal BinaryDataChannel _binaryDataChannel;

	internal EventChannel _eventChannel;

	internal SceneLoadChannel _sceneLoadChannel;

	internal EntityChannel _entityChannel;

	internal EntityChannel.CommandChannel _commandChannel;

	internal List<Entity> _controlling;

	internal EntityList _controllingList;

	internal BoltRingBuffer<PacketStats> _packetStatsIn;

	internal BoltRingBuffer<PacketStats> _packetStatsOut;

	internal bool _canReceiveEntities;

	internal SceneLoadState _remoteSceneLoading;

	private BoltConnection IBoltListNode_003CBoltConnection_003E_002Eprev
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

	private BoltConnection IBoltListNode_003CBoltConnection_003E_002Enext
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

	private object IBoltListNode_003CBoltConnection_003E_002Elist
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

	public bool IsLoadingMap => false;

	public EntityLookup ScopedTo => null;

	public EntityLookup SourceOf => null;

	public EntityList HasControlOf => null;

	public int RemoteFrame => 0;

	public IProtocolToken ConnectToken
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

	public IProtocolToken DisconnectToken
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

	public IProtocolToken AcceptToken
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

	public float PingNetwork => 0f;

	public int DejitterFrames => 0;

	public float PingAliased => 0f;

	internal UdpConnection udpConnection => null;

	internal int remoteFrameLatest => 0;

	internal int remoteFrameDiff => 0;

	public int BitsPerSecondIn => 0;

	public int BitsPerSecondOut => 0;

	public uint ConnectionId => 0u;

	public UdpEndPoint RemoteEndPoint => default(UdpEndPoint);

	public object UserData
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

	public PacketTypeStats CommandsStats => null;

	public PacketTypeStats EventsStats => null;

	public PacketTypeStats StatesStats => null;

	public UdpConnectionDisconnectReason DisconnectReason => default(UdpConnectionDisconnectReason);

	internal int SendRateMultiplier => 0;

	public void SetCanReceiveEntities(bool v)
	{
	}

	internal BoltConnection(UdpConnection udpConnection)
	{
	}

	public ExistsResult ExistsOnRemote(BoltEntity entity)
	{
		return default(ExistsResult);
	}

	public ExistsResult ExistsOnRemote(BoltEntity entity, bool allowMaybe)
	{
		return default(ExistsResult);
	}

	public void StreamBytes(UdpChannelName channel, byte[] data)
	{
	}

	public void SetStreamBandwidth(int bytesPerSecond)
	{
	}

	public void SendData(byte[] data)
	{
	}

	public bool ReceiveData(out byte[] data)
	{
		data = null;
		return false;
	}

	public void Disconnect()
	{
	}

	public void Disconnect(IProtocolToken token, UdpConnectionDisconnectReason disconnectReason = UdpConnectionDisconnectReason.Disconnected)
	{
	}

	public int GetSkippedUpdates(BoltEntity en)
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	internal void DisconnectedInternal()
	{
	}

	internal bool StepRemoteEntities()
	{
		return false;
	}

	internal void AdjustRemoteFrame()
	{
	}

	internal void SwitchPerfCounters()
	{
	}

	internal void Send()
	{
	}

	internal void PacketReceived(UdpPacket udpPacket)
	{
	}

	internal void PacketDelivered(Packet packet)
	{
	}

	internal void PacketLost(Packet packet)
	{
	}

	public static implicit operator bool(BoltConnection cn)
	{
		return false;
	}
}
