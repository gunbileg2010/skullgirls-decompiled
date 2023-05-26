namespace UdpKit
{
	public class UdpEventMasterServerConnected : UdpEventBase
	{
		public UdpEndPoint EndPoint;

		public override int Type => 0;
	}
}
