using System;

namespace UdpKit
{
	public abstract class UdpSession
	{
		public abstract Guid Id { get; }

		public abstract UdpSessionSource Source { get; }

		public abstract UdpEndPoint WanEndPoint { get; }

		public abstract UdpEndPoint LanEndPoint { get; }

		public abstract byte[] HostData { get; }

		public abstract object HostObject { get; set; }

		public abstract int ConnectionsMax { get; }

		public abstract int ConnectionsCurrent { get; }

		public abstract string HostName { get; }

		public abstract bool IsDedicatedServer { get; }

		public abstract bool HasWan { get; }

		public abstract bool HasLan { get; }

		public abstract UdpSession Clone();
	}
}
