namespace UdpKit.Protocol
{
	internal class ProbeEndPoint : Query<ProbeEndPointResult>
	{
		public override bool Resend => false;

		public override bool IsUnique => false;

		public ProbeEndPoint()
		{
			((Query<>)(object)this)._002Ector();
		}
	}
}
