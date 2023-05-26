namespace UdpKit
{
	internal class UdpEventSessionCreated : UdpEventBase
	{
		public UdpSession Session;

		public bool Success;

		public override int Type => 0;
	}
}
