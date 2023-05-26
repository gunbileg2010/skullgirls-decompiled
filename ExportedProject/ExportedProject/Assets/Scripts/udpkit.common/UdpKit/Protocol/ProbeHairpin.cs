namespace UdpKit.Protocol
{
	internal class ProbeHairpin : Query
	{
		public override bool IsUnique => false;

		public override bool Resend => false;
	}
}
