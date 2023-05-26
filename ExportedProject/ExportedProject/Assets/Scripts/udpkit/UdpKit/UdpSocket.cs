using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UdpKit.Protocol;

namespace UdpKit
{
	public class UdpSocket
	{
		private class BroadcastManager
		{
			private readonly UdpSocket udpSocket;

			private ProtocolService service;

			private UdpEndPoint broadcast;

			public bool IsEnabled => false;

			public BroadcastManager(UdpSocket s)
			{
			}

			public void Update(uint now)
			{
			}

			public void Enable(UdpEventLanBroadcastEnable args)
			{
			}

			private void OnBroadcastSearch(UdpKit.Protocol.BroadcastSearch search)
			{
			}

			private void OnBroadcastSession(UdpKit.Protocol.BroadcastSession session)
			{
			}

			public void Disable()
			{
			}
		}

		internal sealed class MasterClient : ProtocolService
		{
			private class NatProbeState
			{
				public uint Timeout;

				public ProtocolClient Hairpin;

				public UdpEndPoint Probe0;

				public UdpEndPoint Probe1;

				public UdpEndPoint Probe2;

				public UdpEndPoint Probe0WanResponse;

				public UdpEndPoint Probe1WanResponse;
			}

			private enum State
			{
				Disconnected = 0,
				Connected = 1
			}

			private class NatPunchTarget
			{
				public uint Time;

				public uint Count;

				public UdpEndPoint EndPoint;
			}

			private class NatPunchRequest
			{
				public uint Time;

				public uint Count;

				public byte[] Token;

				public UdpSession Target;
			}

			private uint ping;

			private uint keepalive;

			private State state;

			private UdpEndPoint endpoint;

			private NatFeatures natFeatures;

			private NatProbeState natProbeState;

			private NatPunchRequest natPunchRequest;

			private readonly UdpSocket socket;

			private readonly List<NatPunchTarget> natPunchTargets;

			internal UdpKit.Protocol.GetZeusInfoResult InfoResult;

			public bool IsConnected => false;

			public bool IsConnectedHost => false;

			public UdpEndPoint LocalWanEndPoint => default(UdpEndPoint);

			public MasterClient(UdpSocket s, ProtocolClient p)
				: base(null)
			{
			}

			public void Update(uint now)
			{
			}

			private void UpdateNatPunch(uint now)
			{
			}

			private void UpdateNatProbe(uint now)
			{
			}

			private void KeepAlive(uint now)
			{
			}

			public void RequestZeusInfo()
			{
			}

			public void RequestSessionList()
			{
			}

			public void Disconnect(string error, params object[] args)
			{
			}

			public void Disconnect()
			{
			}

			public void Connect(UdpEndPoint ep)
			{
			}

			private void OnPeerReconnect(UdpKit.Protocol.PeerReconnect perform)
			{
			}

			public void RegisterHost()
			{
			}

			public void ConnectToSession(UdpSession session, byte[] token)
			{
			}

			private void AckPeerConnect(UdpKit.Protocol.PeerConnect connect)
			{
			}

			private void AckProbeEndPoint(UdpKit.Protocol.ProbeEndPoint probe)
			{
			}

			private void StartHairpinTest()
			{
			}

			private void AckProbeFeatures(UdpKit.Protocol.ProbeFeatures features)
			{
			}

			private void AckHostRegister(UdpKit.Protocol.HostRegister obj)
			{
			}

			private void AckGetZeusInfo(UdpKit.Protocol.GetZeusInfo info)
			{
			}

			private void AckGetHostList(UdpKit.Protocol.GetHostList obj)
			{
			}

			private void OnProbeUnsolicited(UdpKit.Protocol.ProbeUnsolicited probe)
			{
			}

			private void OnProbeHairpin(UdpKit.Protocol.ProbeHairpin obj)
			{
			}

			private void OnHostInfo(UdpKit.Protocol.HostInfo obj)
			{
			}

			private void OnPunchOnce(UdpKit.Protocol.PunchOnce once)
			{
			}

			private void OnDirectConnectionLan(UdpKit.Protocol.DirectConnectionLan direct)
			{
			}

			private void OnDirectConnectionWan(UdpKit.Protocol.DirectConnectionWan direct)
			{
			}

			private void OnPunch(UdpKit.Protocol.Punch punch)
			{
			}

			private void ClearPunchRequest()
			{
			}

			private void OnError(UdpKit.Protocol.Error obj)
			{
			}

			private void UpdatePing(UdpKit.Protocol.Query query)
			{
			}
		}

		private class SessionManager
		{
			private const uint UPDATE_DELAY = 500u;

			private uint nextUpdate;

			private Map<Guid, UdpSession> sessions;

			private readonly UdpSessionImpl local;

			private Stopwatch timer;

			private UdpSocket UdpSocket
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

			public bool IsHostWithName => false;

			public SessionManager(UdpSocket udpSocket)
			{
			}

			public void Update(uint now)
			{
			}

			public UdpSession GetLocalSession()
			{
				return null;
			}

			public void SetHostInfo(UdpEventSessionSetHostData sessionInfo)
			{
			}

			public void UpdateSession(UdpSession session, UdpSessionSource source = UdpSessionSource.None)
			{
			}

			public void SetSessions(List<UdpSession> sessionsList)
			{
			}

			public void ForgetSessionsAll()
			{
			}

			public void ForgetSessions(UdpSessionSource source)
			{
			}

			public void SetWanEndPoint(UdpEndPoint endpoint)
			{
			}

			public void SetLanEndPoint(UdpEndPoint endpoint)
			{
			}

			public void SetConnections(int current, int max)
			{
			}

			private void RaiseSessionCreatedEvent(bool success)
			{
			}

			private void RaiseSessionUpdatedEvent()
			{
			}
		}

		private struct DelayedPacket
		{
			public UdpEndPoint EndPoint;

			public byte[] Data;

			public int Size;

			public uint Time;
		}

		private readonly Queue<byte[]> delayedBuffers;

		private readonly Queue<DelayedPacket> delayedPackets;

		public static bool AllowConnectionRecycle;

		internal readonly UdpConfig Config;

		internal readonly UdpPipeConfig PacketPipeConfig;

		internal readonly UdpPipeConfig StreamPipeConfig;

		internal UdpEndPoint LANEndPoint;

		internal UdpEndPoint WANEndPoint;

		internal readonly Guid PeerId;

		internal readonly Guid GameId;

		private int frame;

		private int channelIdCounter;

		private uint connectionIdCounter;

		private UdpSocketMode mode;

		private UdpSocketState state;

		private readonly byte[] sendBuffer;

		private readonly byte[] recvBuffer;

		private readonly Thread networkLoopThread;

		private readonly UdpPlatform platform;

		private readonly UdpPlatformSocket platformSocket;

		private readonly UdpPacketPool packetPool;

		internal MasterClient masterClient;

		private SessionManager sessionManager;

		private BroadcastManager broadcastManager;

		private readonly Queue<UdpEvent> eventQueueIn;

		private readonly Queue<UdpEvent> eventQueueOut;

		private readonly List<UdpConnection> connectionList;

		private readonly Dictionary<UdpEndPoint, byte[]> pendingConnections;

		private readonly Dictionary<UdpEndPoint, UdpConnection> connectionLookup;

		private readonly Dictionary<UdpChannelName, UdpStreamChannel> streamChannels;

		private bool ShouldDelayPacket => false;

		private bool ShouldDropPacket => false;

		public UdpEndPoint SocketEndPoint => default(UdpEndPoint);

		public UdpEndPoint LanEndPoint => default(UdpEndPoint);

		public UdpEndPoint WanEndPoint => default(UdpEndPoint);

		public UdpSocketState State => default(UdpSocketState);

		public UdpSocketMode Mode => default(UdpSocketMode);

		public Guid SocketPeerId => default(Guid);

		public uint PrecisionTime => 0u;

		public UdpPacketPool PacketPool => null;

		public object UserToken
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

		internal int ZeusInfoHosts => 0;

		internal int ZeusInfoClientsInZeus => 0;

		internal int ZeusInfoClientsInGames => 0;

		internal bool ConnectedToMaster => false;

		public Func<int, byte[]> UnconnectedBufferProvider
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

		public UdpPlatformSocket PlatformSocket => null;

		public UdpChannelName StreamChannelCreate(string name, UdpChannelMode mode, int priority)
		{
			return default(UdpChannelName);
		}

		private bool PeekInternal(out UdpEvent ev)
		{
			ev = default(UdpEvent);
			return false;
		}

		private bool PollInternal(out UdpEvent ev)
		{
			ev = default(UdpEvent);
			return false;
		}

		private void ProcessStartEvent()
		{
		}

		private void ProcessInternalEvents()
		{
		}

		private void OnEventStart(UdpEvent ev)
		{
		}

		private void OnEventConnect(UdpEvent ev)
		{
		}

		private void OnEventConnectCancel(UdpEvent ev)
		{
		}

		private void OnEventAccept(UdpEvent ev)
		{
		}

		private void OnEventRefuse(UdpEvent ev)
		{
		}

		private void OnEventDisconnect(UdpEvent ev)
		{
		}

		private void OnEventClose(UdpEvent ev)
		{
		}

		private void OnEventSend(UdpEvent ev)
		{
		}

		private void OnEvent_MasterServer_Connect(UdpEvent ev)
		{
		}

		private void OnEvent_MasterServer_Disconnect()
		{
		}

		private void OnEvent_MasterServer_SessionListRequest()
		{
		}

		private void OnEvent_MasterServer_InfoRequest()
		{
		}

		private void OnEventSessionHostSetInfo(UdpEvent ev)
		{
		}

		private void OnEventSessionConnect(UdpEvent ev)
		{
		}

		private void OnEventLanBroadcastEnable(UdpEvent ev)
		{
		}

		private void OnEventLanBroadcastDisable()
		{
		}

		private void OnEventStreamSetBandwidth(UdpEvent ev)
		{
		}

		private void OnEventStreamQueue(UdpEvent ev)
		{
		}

		private void OnEventStreamCreateChannel(UdpEvent ev)
		{
		}

		private void FindLanInterfaceIP()
		{
		}

		private UdpEndPoint BuildLocalIPAddress(ushort port)
		{
			return default(UdpEndPoint);
		}

		private void ConnectToEndPoint(UdpEndPoint endpoint, byte[] connectToken)
		{
		}

		private void DelayPacket(UdpEndPoint ep, byte[] data, int size)
		{
		}

		private void RecvDelayedPackets()
		{
		}

		public UdpSocket(Guid gameId, UdpPlatform platform)
		{
		}

		public UdpSocket(Guid gameId, UdpPlatform p, UdpConfig cfg)
		{
		}

		public void Start(UdpEndPoint endpoint, ManualResetEvent resetEvent, UdpSocketMode mode)
		{
		}

		public void Close(ManualResetEvent resetEvent)
		{
		}

		public void Connect(UdpSession session, byte[] token)
		{
		}

		public void Connect(UdpEndPoint endpoint, byte[] token)
		{
		}

		public void CancelConnect(UdpEndPoint endpoint)
		{
		}

		public void Accept(UdpEndPoint endpoint, object userObject, byte[] token)
		{
		}

		public void Refuse(UdpEndPoint endpoint, byte[] token)
		{
		}

		public UdpSession[] GetSessions()
		{
			return null;
		}

		public bool Poll(out UdpEvent ev)
		{
			ev = default(UdpEvent);
			return false;
		}

		public void MasterServerDisconnect()
		{
		}

		public void MasterServerConnect(UdpEndPoint endpoint)
		{
		}

		public void MasterServerRequestInfo()
		{
		}

		public void MasterServerRequestSessionList()
		{
		}

		public void LanBroadcastEnable(UdpIPv4Address localAddresss, UdpIPv4Address broadcastAddress, ushort port)
		{
		}

		public void LanBroadcastDisable()
		{
		}

		public void SetHostInfo(string name, bool dedicated, object tokenObject, byte[] token)
		{
		}

		internal bool FindChannel(int id, out UdpStreamChannel channel)
		{
			channel = null;
			return false;
		}

		internal byte[] GetSendBuffer()
		{
			return null;
		}

		internal byte[] GetRecvBuffer()
		{
			return null;
		}

		internal uint GetCurrentTime()
		{
			return 0u;
		}

		internal void Raise(int type, UdpConnection c, UdpPacket p)
		{
		}

		internal void Raise(UdpEvent ev)
		{
		}

		internal bool Send(UdpEndPoint endpoint, byte[] buffer, int length)
		{
			return false;
		}

		internal void SendCommand(UdpEndPoint endpoint, byte cmd)
		{
		}

		internal void SendCommand(UdpEndPoint endpoint, byte cmd, byte[] data)
		{
		}

		private bool ChangeState(UdpSocketState from, UdpSocketState to)
		{
			return false;
		}

		private bool CheckState(UdpSocketState s)
		{
			return false;
		}

		private void NetworkLoop()
		{
		}

		private bool CreatePhysicalSocket(UdpEndPoint ep, UdpSocketState s)
		{
			return false;
		}

		private void AcceptConnection(UdpEndPoint ep, object userToken, byte[] acceptToken, byte[] connectToken)
		{
		}

		private void ProcessTimeouts()
		{
		}

		private void RecvNetworkData()
		{
		}

		private void RecvNetworkPacket(UdpEndPoint ep, byte[] buffer, int bytes)
		{
		}

		private void RecvStreamUnreliable(UdpEndPoint ep, byte[] buffer, int bytes)
		{
		}

		private void RecvProtocol(UdpEndPoint endpoint, byte[] buffer, int bytes)
		{
		}

		private void RecvCommand(UdpEndPoint ep, byte[] buffer, int size)
		{
		}

		private void RecvStream(UdpEndPoint ep, byte[] buffer, int bytes)
		{
		}

		private void RecvPacket(UdpEndPoint ep, byte[] buffer, int size)
		{
		}

		private void AddPendingConnection(UdpEndPoint endpoint, byte[] token)
		{
		}

		private UdpConnection CreateConnection(UdpEndPoint endpoint, UdpConnectionMode connectionMode, byte[] connectToken)
		{
			return null;
		}

		private bool DestroyConnection(UdpConnection cn)
		{
			return false;
		}

		private void RecvConnectionCommand_Unconnected(UdpEndPoint endpoint, byte[] buffer, int size)
		{
		}
	}
}
