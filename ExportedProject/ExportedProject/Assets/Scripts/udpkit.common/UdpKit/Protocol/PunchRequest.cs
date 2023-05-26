using System;

namespace UdpKit.Protocol
{
	internal class PunchRequest : Message
	{
		public Guid Host;

		protected override void OnSerialize()
		{
		}
	}
}
