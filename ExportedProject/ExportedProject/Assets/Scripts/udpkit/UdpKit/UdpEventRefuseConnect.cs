namespace UdpKit
{
	internal class UdpEventRefuseConnect : UdpEventBase
	{
		public byte[] Token;

		public UdpEndPoint EndPoint;

		public override int Type => 0;
	}
}
