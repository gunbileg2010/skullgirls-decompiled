namespace UdpKit.Protocol
{
	internal class PeerConnect : Query<PeerConnectResult>
	{
		public override bool Resend => false;

		public override bool IsUnique => false;

		public PeerConnect()
		{
			((Query<>)(object)this)._002Ector();
		}
	}
}
