namespace UdpKit
{
	internal class UdpEventConnectEndPointCancel : UdpEventBase
	{
		public UdpEndPoint EndPoint;

		public override int Type => 0;
	}
}
