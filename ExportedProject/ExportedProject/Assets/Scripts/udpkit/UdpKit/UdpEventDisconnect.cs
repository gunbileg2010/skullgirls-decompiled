namespace UdpKit
{
	internal class UdpEventDisconnect : UdpEventBase
	{
		public byte[] Token;

		public UdpConnection Connection;

		public UdpConnectionDisconnectReason DisconnectReason;

		public override int Type => 0;
	}
}
