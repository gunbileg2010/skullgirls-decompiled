using System;

namespace UdpKit.Protocol
{
	internal class DirectConnectionLan : Message
	{
		public Guid RemotePeerId;

		public UdpEndPoint RemoteEndPoint;

		protected override void OnSerialize()
		{
		}
	}
}
