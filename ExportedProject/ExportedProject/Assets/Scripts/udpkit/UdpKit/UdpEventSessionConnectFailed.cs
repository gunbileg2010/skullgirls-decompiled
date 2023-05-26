namespace UdpKit
{
	public class UdpEventSessionConnectFailed : UdpEventBase
	{
		public byte[] Token;

		public UdpSession Session;

		public override int Type => 0;
	}
}
