namespace UdpKit
{
	public class UdpEventMasterServerConnectFailed : UdpEventBase
	{
		public UdpEndPoint EndPoint;

		public override int Type => 0;
	}
}
