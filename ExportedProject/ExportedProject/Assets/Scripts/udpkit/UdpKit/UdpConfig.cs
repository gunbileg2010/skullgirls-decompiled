using System;

namespace UdpKit
{
	[Serializable]
	public class UdpConfig
	{
		public bool MasterServerAutoDisconnect;

		public int PacketWindow;

		public int PacketDatagramSize;

		public int StreamWindow;

		public int StreamDatagramSize;

		public uint NatPunchOnceDelay;

		public int NatPunchOnceCount;

		public uint NatPunchOnceInterval;

		public int NatPunchRequestCount;

		public uint NatPunchRequestInterval;

		public uint NatProbeEndPointTimeout;

		public uint NatProbeHairpinTimeout;

		public uint HostKeepAliveInterval;

		public uint BroadcastInterval;

		public bool IPv6;

		public float DefaultNetworkPing;

		public float DefaultAliasedPing;

		public bool AllowPacketOverflow;

		public uint ConnectRequestTimeout;

		public uint ConnectRequestAttempts;

		public uint ConnectionTimeout;

		public uint PingTimeout;

		public uint RecvWithoutAckLimit;

		public float SimulatedLoss;

		public int SimulatedPingMin;

		public int SimulatedPingMax;

		public int ConnectionLimit;

		public bool AllowIncommingConnections;

		public bool AutoAcceptIncommingConnections;

		public bool AllowImplicitAccept;

		public Func<float> NoiseFunction;

		internal UdpConfig Duplicate()
		{
			return null;
		}
	}
}
