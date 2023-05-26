using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Open.Nat
{
	internal class PmpSearcher : Searcher
	{
		private readonly IIPAddressesProvider _ipprovider;

		private Dictionary<UdpClient, IEnumerable<IPEndPoint>> _gatewayLists;

		private int _timeout;

		internal PmpSearcher(IIPAddressesProvider ipprovider)
		{
		}

		private void CreateSocketsAndAddGateways()
		{
		}

		protected override void Discover(UdpClient client, CancellationToken cancelationToken)
		{
		}

		private bool IsSearchAddress(IPAddress address)
		{
			return false;
		}

		public override NatDevice AnalyseReceivedResponse(IPAddress localAddress, byte[] response, IPEndPoint endpoint)
		{
			return null;
		}
	}
}
