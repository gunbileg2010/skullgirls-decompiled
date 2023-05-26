using System.Net.NetworkInformation;
using UdpKit;

public class DotNetInterface : UdpPlatformInterface
{
	private string name;

	private UdpLinkType linkType;

	private byte[] physicalAddress;

	private UdpIPv4Address[] gatewayAddresses;

	private UdpIPv4Address[] unicastAddresses;

	private UdpIPv4Address[] multicastAddresses;

	internal override string Name => null;

	internal override UdpLinkType LinkType => default(UdpLinkType);

	internal override byte[] PhysicalAddress => null;

	internal override UdpIPv4Address[] GatewayAddresses => null;

	internal override UdpIPv4Address[] UnicastAddresses => null;

	internal override UdpIPv4Address[] MulticastAddresses => null;

	public DotNetInterface(NetworkInterface n, UdpIPv4Address[] gw, UdpIPv4Address[] uni, UdpIPv4Address[] multi)
	{
	}

	private static string ParseName(NetworkInterface n)
	{
		return null;
	}

	private static byte[] ParsePhysicalAddress(NetworkInterface n)
	{
		return null;
	}

	private static UdpLinkType ParseLinkType(NetworkInterface n)
	{
		return default(UdpLinkType);
	}
}
