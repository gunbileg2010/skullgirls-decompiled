using System.Collections.Generic;
using UdpKit;

public sealed class NullPlatform : UdpPlatform
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

	internal override bool SupportsBroadcast => false;

	internal override bool SupportsMasterServer => false;

	internal override bool IsNull => false;

	internal override UdpPlatformSocket CreateSocket(bool ipv6)
	{
		return null;
	}

	internal override UdpSessionSource GetSessionSource()
	{
		return default(UdpSessionSource);
	}

	internal override UdpIPv4Address GetBroadcastAddress()
	{
		return default(UdpIPv4Address);
	}

	internal override List<UdpPlatformInterface> GetNetworkInterfaces()
	{
		return null;
	}

	internal override uint GetPrecisionTime()
	{
		return 0u;
	}

	internal override UdpIPv4Address[] ResolveHostAddresses(string host)
	{
		return null;
	}
}
