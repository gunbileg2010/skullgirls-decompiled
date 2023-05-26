using System.Threading;

namespace UdpKit
{
	public class UdpEventStartFailed : UdpEventBase
	{
		public ManualResetEvent ResetEvent;

		public override int Type => 0;
	}
}
