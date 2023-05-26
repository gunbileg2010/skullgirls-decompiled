using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Xml;

namespace Open.Nat
{
	internal class UpnpSearcher : Searcher
	{
		private readonly IIPAddressesProvider _ipprovider;

		private readonly IDictionary<Uri, NatDevice> _devices;

		private readonly Dictionary<IPAddress, DateTime> _lastFetched;

		private static readonly string[] ServiceTypes;

		internal UpnpSearcher(IIPAddressesProvider ipprovider)
		{
		}

		private List<UdpClient> CreateUdpClients()
		{
			return null;
		}

		protected override void Discover(UdpClient client, CancellationToken cancelationToken)
		{
		}

		private void Discover(UdpClient client, IPAddress address, CancellationToken cancelationToken)
		{
		}

		private bool IsValidClient(Socket socket, IPAddress address)
		{
			return false;
		}

		public override NatDevice AnalyseReceivedResponse(IPAddress localAddress, byte[] response, IPEndPoint endpoint)
		{
			return null;
		}

		private static bool IsValidControllerService(string serviceType)
		{
			return false;
		}

		private UpnpNatDeviceInfo BuildUpnpNatDeviceInfo(IPAddress localAddress, Uri location)
		{
			return null;
		}

		private static XmlDocument ReadXmlResponse(WebResponse response)
		{
			return null;
		}
	}
}
