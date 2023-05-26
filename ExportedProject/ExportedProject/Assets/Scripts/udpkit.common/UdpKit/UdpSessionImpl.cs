using System;

namespace UdpKit
{
	public class UdpSessionImpl : UdpSession
	{
		internal uint _lastSeen;

		internal Guid _id;

		internal UdpEndPoint _wanEndPoint;

		internal UdpEndPoint _lanEndPoint;

		internal UdpSessionSource _source;

		internal int _connectionsMax;

		internal int _connectionsCurrent;

		internal string _hostName;

		internal byte[] _hostData;

		internal object _hostObject;

		internal bool _hostIsDedicated;

		public override Guid Id => default(Guid);

		public override UdpSessionSource Source => default(UdpSessionSource);

		public override UdpEndPoint WanEndPoint => default(UdpEndPoint);

		public override UdpEndPoint LanEndPoint => default(UdpEndPoint);

		public override int ConnectionsMax => 0;

		public override int ConnectionsCurrent => 0;

		public override string HostName => null;

		public override bool IsDedicatedServer => false;

		public override bool HasWan => false;

		public override bool HasLan => false;

		public override byte[] HostData => null;

		public override object HostObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override UdpSession Clone()
		{
			return null;
		}
	}
}
