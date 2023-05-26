using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace Open.Nat
{
	internal class IPAddressesProvider : IIPAddressesProvider
	{
		public IEnumerable<IPAddress> UnicastAddresses()
		{
			return null;
		}

		public IEnumerable<IPAddress> DnsAddresses()
		{
			return null;
		}

		public IEnumerable<IPAddress> GatewayAddresses()
		{
			return null;
		}

		private static IEnumerable<IPAddress> IPAddresses(Func<IPInterfaceProperties, IEnumerable<IPAddress>> ipExtractor)
		{
			return null;
		}
	}
}
