namespace UdpKit.Protocol
{
	internal class ProbeEndPointResult : Result
	{
		public UdpEndPoint WanEndPoint;

		protected override void OnSerialize()
		{
		}
	}
}
