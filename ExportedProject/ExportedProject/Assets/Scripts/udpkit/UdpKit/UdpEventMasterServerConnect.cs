namespace UdpKit
{
	internal class UdpEventMasterServerConnect : UdpEventBase
	{
		public UdpEndPoint EndPoint;

		public override int Type => 0;
	}
}
