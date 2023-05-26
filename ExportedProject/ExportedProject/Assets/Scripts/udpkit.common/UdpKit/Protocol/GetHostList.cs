namespace UdpKit.Protocol
{
	internal class GetHostList : Query
	{
		public override bool Resend => false;

		public override bool IsUnique => false;
	}
}
