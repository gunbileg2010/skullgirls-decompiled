using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using UdpKit;

internal class DotNetPlatform : UdpPlatform
{
	private class PrecisionTimer
	{
		private static readonly long start;

		private static readonly double freq;

		internal static uint GetCurrentTime()
		{
			return 0u;
		}
	}

	internal override bool SessionListProvidedExternally => false;

	internal override bool SupportsBroadcast => false;

	internal override bool SupportsMasterServer => false;

	internal override uint GetPrecisionTime()
	{
		return 0u;
	}

	internal override UdpSessionSource GetSessionSource()
	{
		return default(UdpSessionSource);
	}

	internal override UdpIPv4Address GetBroadcastAddress()
	{
		return default(UdpIPv4Address);
	}

	internal override UdpPlatformSocket CreateSocket(bool ipv6)
	{
		return null;
	}

	internal override List<UdpPlatformInterface> GetNetworkInterfaces()
	{
		return null;
	}

	internal override UdpIPv4Address[] ResolveHostAddresses(string host)
	{
		return null;
	}

	private List<UdpPlatformInterface> FindInterfaces()
	{
		return null;
	}

	private DotNetInterface ParseInterface(NetworkInterface n)
	{
		return null;
	}

	public static UdpEndPoint ConvertEndPoint(EndPoint endpoint)
	{
		return default(UdpEndPoint);
	}

	public static UdpEndPoint ConvertEndPoint(IPEndPoint endpoint)
	{
		return default(UdpEndPoint);
	}

	public static UdpIPv4Address ConvertAddress(IPAddress address)
	{
		return default(UdpIPv4Address);
	}

	public static IPEndPoint ConvertEndPoint(UdpEndPoint endpoint)
	{
		return null;
	}

	private static bool IsValidInterface(IPInterfaceProperties p)
	{
		return false;
	}

	private static IPAddress FindBroadcastAddress(bool strict)
	{
		return null;
	}
}
