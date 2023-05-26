namespace UdpKit.Protocol
{
	internal class ProbeFeatures : Query
	{
		public NatFeatures NatFeatures;

		public override bool IsUnique => false;

		public override bool Resend => false;

		protected override void OnSerialize()
		{
		}
	}
}
