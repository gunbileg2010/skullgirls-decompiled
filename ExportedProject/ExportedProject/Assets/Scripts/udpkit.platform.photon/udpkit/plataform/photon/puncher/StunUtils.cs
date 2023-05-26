using System.Net;

namespace udpkit.plataform.photon.puncher
{
	internal static class StunUtils
	{
		public static int REQUEST_ID;

		public static int RESPONSE_ID;

		public static byte[] REQUEST_ID_DATA;

		public static byte[] RESPONSE_ID_DATA;

		public static StunMsgHeader SIGNALING_REQUEST;

		public static StunMsgHeader SIGNALING_RESPONSE;

		public static byte[] SIGNALING_REQUEST_DATA;

		public static byte[] SIGNALING_RESPONSE_DATA;

		private static readonly byte[] SIGNALING_BINDING;

		public static bool IsSignalingMsg(byte[] msg)
		{
			return false;
		}

		public static byte[] BuildPingRequest(int localId)
		{
			return null;
		}

		public static byte[] BuildPongResponse(int localId)
		{
			return null;
		}

		public static StunMsgHeader BuildSignalingRequest()
		{
			return null;
		}

		public static StunMsgHeader BuildSignalingResponse()
		{
			return null;
		}

		public static StunMsgHeader BuildStunInfoRequest(int id)
		{
			return null;
		}

		public static IPEndPoint GetIpEndPoint(PunchMessage pm)
		{
			return null;
		}

		public static bool ValidStunMsg(StunMsgHeader msg, StunMsgType type)
		{
			return false;
		}

		public static bool ValidStunMsg(StunMsgHeader msg, StunMsgType type, int id)
		{
			return false;
		}

		public static IPEndPoint BuildEndPoint(string data)
		{
			return null;
		}

		private static void GetBytes(byte[] src, byte[] dst, int start)
		{
		}

		private static byte[] BuildID(int id)
		{
			return null;
		}
	}
}
