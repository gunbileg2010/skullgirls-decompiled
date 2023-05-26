using System;
using System.Runtime.CompilerServices;

namespace UdpKit.Protocol
{
	internal class ProtocolService
	{
		private ProtocolClient client;

		public ProtocolClient Client => null;

		public uint SendTime
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

		public ProtocolService(ProtocolClient p)
		{
		}

		public void Send<T>(UdpEndPoint endpoint) where T : UdpKit.Protocol.Message
		{
		}

		public void Send(UdpEndPoint endpoint, UdpKit.Protocol.Message msg)
		{
		}

		public void Send<T>(UdpEndPoint endpoint, Action<T> setup) where T : UdpKit.Protocol.Message
		{
		}
	}
}
