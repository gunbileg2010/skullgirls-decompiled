namespace UdpKit
{
	internal class UdpEventStreamCreateChannel : UdpEventBase
	{
		public UdpChannelConfig ChannelConfig;

		public override int Type => 0;
	}
}
