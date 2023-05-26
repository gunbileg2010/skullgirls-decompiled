namespace UdpKit
{
	public class UdpEventMasterServerDisconnected : UdpEventBase
	{
		public UdpEndPoint EndPoint;

		public override int Type => 0;
	}
}
