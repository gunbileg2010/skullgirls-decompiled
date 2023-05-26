using UdpKit;

namespace udpkit.plataform.photon.puncher
{
	internal class PunchPlatform : global::DotNetPlatform
	{
		internal override UdpPlatformSocket CreateSocket(bool ipv6)
		{
			return null;
		}

		internal override UdpSessionSource GetSessionSource()
		{
			return default(UdpSessionSource);
		}
	}
}
