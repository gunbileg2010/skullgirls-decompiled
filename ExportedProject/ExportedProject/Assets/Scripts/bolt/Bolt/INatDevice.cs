using System.Collections.Generic;
using UdpKit;

namespace Bolt
{
	public interface INatDevice
	{
		string DeviceType { get; }

		IEnumerable<IPortMapping> Ports { get; }

		UdpIPv4Address PublicAddress { get; }

		UdpIPv4Address LocalAddress { get; }
	}
}
