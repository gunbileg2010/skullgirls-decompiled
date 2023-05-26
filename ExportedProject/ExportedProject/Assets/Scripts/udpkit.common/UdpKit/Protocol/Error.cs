namespace UdpKit.Protocol
{
	internal class Error : Message
	{
		public string Text;

		protected override void OnSerialize()
		{
		}
	}
}
