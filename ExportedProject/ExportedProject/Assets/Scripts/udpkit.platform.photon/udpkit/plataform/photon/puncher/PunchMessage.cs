using UdpKit;

namespace udpkit.plataform.photon.puncher
{
	internal class PunchMessage
	{
		public UdpEndPoint target;

		internal StunMsgHeader msg;

		internal byte[] buffer;

		public PunchMessage(UdpEndPoint target, byte[] buffer)
		{
		}

		public int GetRemoteId()
		{
			return 0;
		}

		public bool IsPunch()
		{
			return false;
		}

		public bool IsPing()
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
