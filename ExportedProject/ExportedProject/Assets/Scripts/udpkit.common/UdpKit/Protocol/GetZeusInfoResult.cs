namespace UdpKit.Protocol
{
	internal class GetZeusInfoResult : Result
	{
		public int Hosts;

		public int ClientsInZeus;

		public int ClientsInGames;

		protected override void OnSerialize()
		{
		}
	}
}
