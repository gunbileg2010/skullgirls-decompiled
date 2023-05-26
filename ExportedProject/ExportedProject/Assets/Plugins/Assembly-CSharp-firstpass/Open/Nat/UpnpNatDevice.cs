using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Open.Nat
{
	internal sealed class UpnpNatDevice : NatDevice
	{
		internal readonly UpnpNatDeviceInfo DeviceInfo;

		private readonly SoapClient _soapClient;

		internal UpnpNatDevice(UpnpNatDeviceInfo deviceInfo)
		{
		}

		public override Task<IPAddress> GetExternalIPAsync()
		{
			return null;
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

		public override Task<Mapping> GetSpecificMappingAsync(Protocol protocol, int publicPort)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
