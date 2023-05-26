namespace UdpKit
{
	internal class UdpEventConnectEndPoint : UdpEventBase
	{
		public byte[] Token;

		public UdpEndPoint EndPoint;

		public override int Type => 0;
	}
}
