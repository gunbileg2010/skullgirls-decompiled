using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Open.Nat
{
	internal sealed class PmpNatDevice : NatDevice
	{
		private readonly IPAddress _publicAddress;

		internal IPAddress LocalAddress
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal PmpNatDevice(IPAddress localAddress, IPAddress publicAddress)
		{
		}

		public override Task CreatePortMapAsync(Mapping mapping)
		{
			return null;
		}

		public override Task DeletePortMapAsync(Mapping mapping)
		{
			return null;
		}

		public override Task<IEnumerable<Mapping>> GetAllMappingsAsync()
		{
			return null;
		}

		public override Task<IPAddress> GetExternalIPAsync()
		{
			return null;
		}

		public override Task<Mapping> GetSpecificMappingAsync(Protocol protocol, int port)
		{
			return null;
		}

		private Task<Mapping> InternalCreatePortMapAsync(Mapping mapping, bool create)
		{
			return null;
		}

		private void CreatePortMapListen(UdpClient udpClient, Mapping mapping)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
