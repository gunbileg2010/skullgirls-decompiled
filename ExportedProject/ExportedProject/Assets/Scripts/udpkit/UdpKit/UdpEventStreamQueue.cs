namespace UdpKit
{
	internal class UdpEventStreamQueue : UdpEventBase
	{
		public UdpConnection Connection;

		public UdpStreamOp StreamOp;

		public override int Type => 0;
	}
}
