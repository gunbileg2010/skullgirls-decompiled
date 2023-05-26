using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UdpKit
{
	public class UdpConnection
	{
		private bool ignore_next_disconnect;

		internal const byte COMMAND_CONNECT = 1;

		internal const byte COMMAND_ACCEPTED = 2;

		internal const byte COMMAND_REFUSED = 3;

		internal const byte COMMAND_DISCONNECTED = 4;

		internal const byte COMMAND_RECONNECT_LATER = 6;

		internal const byte COMMAND_PING = 5;

		private float NetworkRtt;

		private float AliasedRtt;

		private uint ConnectTimeout;

		private uint ConnectAttempts;

		private uint CreateTime;

		private uint StreamSendInterval;

		private Dictionary<UdpChannelName, UdpChannelStreamer> StreamChannels;

		internal UdpPipe PacketPipe;

		internal UdpPipe StreamPipe;

		private readonly UdpEndPoint EndPoint;

		private readonly UdpConnectionMode Mode;

		internal UdpSocket Socket;

		internal UdpConnectionState State;

		internal uint ConnectionId;

		internal byte[] ConnectToken;

		internal byte[] DisconnectToken;

		internal byte[] AcceptToken;

		internal byte[] AcceptTokenWithPrefix;

		internal uint SendTime
		{
			[CompilerGenerated]
			get
			{
				return 0u;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal uint RecvTime
		{
			[CompilerGenerated]
			get
			{
				return 0u;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

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

		public UdpConnectionDisconnectReason DisconnectReason
		{
			[CompilerGenerated]
			get
			{
				return default(UdpConnectionDisconnectReason);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public float NetworkPing => 0f;

		public float AliasedPing => 0f;

		public bool IsClient => false;

		public bool IsServer => false;

		public bool IsConnected => false;

		public UdpEndPoint RemoteEndPoint => default(UdpEndPoint);

		public float WindowFillRatio => 0f;

		internal void OnCommandReceived(byte[] buffer, int size)
		{
		}

		private void OnCommandReconnectLater()
		{
		}

		internal void SendCommand(byte cmd)
		{
		}

		internal void SendCommand(byte cmd, byte[] data)
		{
		}

		private bool SendCommandConnect()
		{
			return false;
		}

		private void OnCommandConnect()
		{
		}

		private void OnCommandAccepted(byte[] buffer, int size)
		{
		}

		private void OnCommandRefused(byte[] buffer, int size)
		{
		}

		private void OnCommandDisconnected(byte[] buffer, int size)
		{
		}

		private void OnCommandPing()
		{
		}

		internal void OnPacketSend(UdpPacket packet)
		{
		}

		internal void OnPacketReceived(byte[] buffer, int bytes)
		{
		}

		internal UdpConnection(UdpSocket socket, UdpConnectionMode mode, UdpEndPoint endPoint)
		{
		}

		public void Send(UdpPacket packet)
		{
		}

		public void Disconnect(byte[] token, UdpConnectionDisconnectReason disconnectReason = UdpConnectionDisconnectReason.Disconnected)
		{
		}

		internal void Lost(UdpPipe pipe, object obj)
		{
		}

		internal void Delivered(UdpPipe pipe, object obj)
		{
		}

		internal void ProcessConnectingTimeouts(uint now)
		{
		}

		internal void ProcessConnectedTimeouts(uint now)
		{
		}

		internal void ChangeState(UdpConnectionState newState)
		{
		}

		internal void ChangeState(UdpConnectionState newState, byte[] token)
		{
		}

		internal bool CheckState(UdpConnectionState stateValue)
		{
			return false;
		}

		internal void UpdatePing(uint recvTime, uint sendTime, uint ackTime)
		{
		}

		internal void ConnectionError(UdpConnectionError error)
		{
		}

		internal void ConnectionError(UdpConnectionError error, string message)
		{
		}

		internal void UpdateSendTime()
		{
		}

		internal void Destroy()
		{
		}

		private void OnStateConnected(UdpConnectionState oldState)
		{
		}

		private void OnStateDisconnected(UdpConnectionState oldState, byte[] token)
		{
		}

		public void StreamSetBandwidth(int bytesPerSecond)
		{
		}

		internal void OnStreamSetBandwidth(int byteRate)
		{
		}

		public void StreamBytes(UdpChannelName channel, byte[] data)
		{
		}

		internal void OnStreamQueue(UdpStreamChannel c, UdpStreamOp op)
		{
		}

		internal void OnStreamReceived_Unreliable(byte[] buffer, int size)
		{
		}

		internal void OnStreamReceived(byte[] buffer, int bytes)
		{
		}

		private void OnStreamLost(UdpStreamOpBlock block)
		{
		}

		private void OnStreamDelivered(UdpStreamOpBlock block)
		{
		}

		private void SendStream()
		{
		}
	}
}
