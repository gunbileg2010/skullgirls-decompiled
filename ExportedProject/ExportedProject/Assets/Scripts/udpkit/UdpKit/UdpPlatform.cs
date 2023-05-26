using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UdpKit
{
	public abstract class UdpPlatform
	{
		internal object Token
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal virtual bool IsNull => false;

		internal virtual bool SessionListProvidedExternally => false;

		internal virtual bool ShutdownOnConnectFailure => false;

		internal abstract bool SupportsBroadcast { get; }

		internal abstract bool SupportsMasterServer { get; }

		internal virtual float SessionListUpdateRate => 0f;

		internal abstract UdpSessionSource GetSessionSource();

		internal abstract uint GetPrecisionTime();

		internal abstract UdpIPv4Address GetBroadcastAddress();

		internal abstract UdpIPv4Address[] ResolveHostAddresses(string host);

		internal abstract UdpPlatformSocket CreateSocket(bool ipv6);

		internal abstract List<UdpPlatformInterface> GetNetworkInterfaces();

		internal virtual List<UdpSession> GetSessionList()
		{
			return null;
		}

		internal virtual bool HandleConnectToSession(UdpSession session, object protocolToken, Action<bool> result = null)
		{
			return false;
		}

		internal virtual bool HandleSetHostInfo(UdpSession session, Action<bool> result = null)
		{
			return false;
		}

		[Obsolete]
		internal virtual bool HandleSetHostInfo(string servername, bool dedicated, object protocolToken, byte[] protocolTokenData)
		{
			return false;
		}

		internal virtual void OnStartBegin()
		{
		}

		internal virtual void OnStartDone()
		{
		}

		internal virtual void OnStartupFailed()
		{
		}

		internal UdpPlatformSocket CreateSocket(UdpEndPoint endpoint)
		{
			return null;
		}

		internal virtual UdpPlatformSocket CreateBroadcastSocket(UdpEndPoint endpoint, bool bind = true)
		{
			return null;
		}
	}
}
