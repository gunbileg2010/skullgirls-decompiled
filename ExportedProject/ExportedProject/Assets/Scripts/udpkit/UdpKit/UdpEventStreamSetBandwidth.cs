namespace UdpKit
{
	internal class UdpEventStreamSetBandwidth : UdpEventBase
	{
		public UdpConnection Connection;

		public int BytesPerSecond;

		public override int Type => 0;
	}
}
