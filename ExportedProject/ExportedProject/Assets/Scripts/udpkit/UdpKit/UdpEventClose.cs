using System.Threading;

namespace UdpKit
{
	internal class UdpEventClose : UdpEventBase
	{
		public ManualResetEvent ResetEvent;

		public override int Type => 0;
	}
}
