namespace UdpKit.Protocol
{
	internal class GetZeusInfo : Query<GetZeusInfoResult>
	{
		public override bool Resend => false;

		public override bool IsUnique => false;

		public GetZeusInfo()
		{
			((Query<>)(object)this)._002Ector();
		}
	}
}
