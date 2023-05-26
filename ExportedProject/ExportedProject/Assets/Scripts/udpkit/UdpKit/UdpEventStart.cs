using System.Threading;

namespace UdpKit
{
	internal class UdpEventStart : UdpEventBase
	{
		public UdpSocketMode Mode;

		public UdpEndPoint EndPoint;

		public ManualResetEvent ResetEvent;

		public override int Type => 0;
	}
}
