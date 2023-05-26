namespace UdpKit
{
	internal class UdpEventSessionConnect : UdpEventBase
	{
		public byte[] Token;

		public UdpSession Session;

		public override int Type => 0;
	}
}
