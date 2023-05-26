using System;

namespace UdpKit.Protocol
{
	internal class DirectConnectionWan : Message
	{
		public Guid RemotePeerId;

		public UdpEndPoint RemoteEndPoint;

		protected override void OnSerialize()
		{
		}
	}
}
