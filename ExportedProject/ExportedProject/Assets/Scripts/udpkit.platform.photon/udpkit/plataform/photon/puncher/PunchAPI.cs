using System.Net.Sockets;
using UdpKit;

namespace udpkit.plataform.photon.puncher
{
	internal static class PunchAPI
	{
		public enum PunchStatus
		{
			STUN_PROCESSING = 0,
			STUN_OK = 1,
			STUN_FAIL = 2
		}

		private static Puncher puncher;

		internal static bool Initiated => false;

		internal static void InitSocket(Socket socket)
		{
		}

		public static void RegisterPhotonClient(IPunchLoadBalancingClient loadBalancingClient, UdpEndPoint localEndPoint)
		{
		}

		public static void HandlerPhotonEvent(byte evtCode, int remotePlayerId, string evtData)
		{
		}

		public static void Clear()
		{
		}

		public static void Service()
		{
		}

		public static void RecvFrom(byte[] buffer, int bufferSize, UdpEndPoint endpoint)
		{
		}
	}
}
