namespace UdpKit.Protocol
{
	internal class HostRegister : Query
	{
		public UdpSession Host;

		public override bool Resend => false;

		public override bool IsUnique => false;

		protected override void OnSerialize()
		{
		}
	}
}
