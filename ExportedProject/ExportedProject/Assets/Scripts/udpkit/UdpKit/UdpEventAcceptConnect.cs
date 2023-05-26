namespace UdpKit
{
	internal class UdpEventAcceptConnect : UdpEventBase
	{
		public byte[] Token;

		public object UserObject;

		public UdpEndPoint EndPoint;

		public override int Type => 0;
	}
}
