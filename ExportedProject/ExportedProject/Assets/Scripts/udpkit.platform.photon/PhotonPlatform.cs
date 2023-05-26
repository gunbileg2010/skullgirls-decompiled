using System;
using System.Collections.Generic;
using UdpKit;
using udpkit.plataform.photon.puncher;

public class PhotonPlatform : UdpPlatform
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

	private PhotonPlatformConfig _config;

	private PunchPlatform _punchPlatform;

	internal override bool SupportsBroadcast => false;

	internal override bool ShutdownOnConnectFailure => false;

	internal override bool SupportsMasterServer => false;

	internal override float SessionListUpdateRate => 0f;

	internal override bool SessionListProvidedExternally => false;

	public PhotonPlatform()
	{
	}

	public PhotonPlatform(PhotonPlatformConfig config)
	{
	}

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

	internal override bool HandleConnectToSession(UdpSession session, object protocolToken, Action<bool> result = null)
	{
		return false;
	}

	internal override bool HandleSetHostInfo(UdpSession session, Action<bool> result = null)
	{
		return false;
	}

	internal override UdpIPv4Address[] ResolveHostAddresses(string host)
	{
		return null;
	}

	internal override UdpPlatformSocket CreateBroadcastSocket(UdpEndPoint endpoint, bool bind = true)
	{
		return null;
	}

	internal override List<UdpSession> GetSessionList()
	{
		return null;
	}

	internal override void OnStartupFailed()
	{
	}

	internal override void OnStartBegin()
	{
	}

	internal override void OnStartDone()
	{
	}
}
