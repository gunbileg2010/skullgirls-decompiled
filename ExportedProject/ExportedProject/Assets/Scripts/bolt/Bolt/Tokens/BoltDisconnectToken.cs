using UdpKit;

namespace Bolt.Tokens
{
	public class BoltDisconnectToken : IProtocolToken
	{
		public string reason;

		public UdpConnectionDisconnectReason disconnectReason;

		public BoltDisconnectToken()
		{
		}

		public BoltDisconnectToken(string reason, UdpConnectionDisconnectReason disconnectReason = UdpConnectionDisconnectReason.Disconnected)
		{
		}

		public void Read(UdpPacket packet)
		{
		}

		public void Write(UdpPacket packet)
		{
		}
	}
}
