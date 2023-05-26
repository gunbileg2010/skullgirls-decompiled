using UdpKit;

namespace udpkit.plataform.photon.puncher
{
	internal class PunchSocket : global::DotNetSocket
	{
		public PunchSocket(global::DotNetPlatform platform, bool ipv6)
			: base(null, ipv6: false)
		{
		}

		internal override int RecvFrom(byte[] buffer, int bufferSize, ref UdpEndPoint remoteEndpoint)
		{
			return 0;
		}

		internal override bool RecvPoll()
		{
			return false;
		}

		internal override bool RecvPoll(int timeout)
		{
			return false;
		}

		internal override int SendTo(byte[] buffer, int bytesToSend, UdpEndPoint endpoint)
		{
			return 0;
		}
	}
}
