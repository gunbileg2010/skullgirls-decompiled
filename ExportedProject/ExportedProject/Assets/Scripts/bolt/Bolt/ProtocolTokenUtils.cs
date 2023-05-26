using UdpKit;

namespace Bolt
{
	public static class ProtocolTokenUtils
	{
		private static byte[] tempBytes;

		private static UdpPacket tempPacket;

		public static byte[] ToByteArray(this IProtocolToken token)
		{
			return null;
		}

		public static IProtocolToken ToToken(this byte[] bytes)
		{
			return null;
		}

		public static void WriteToken(this UdpPacket packet, IProtocolToken token)
		{
		}

		public static IProtocolToken ReadToken(this UdpPacket packet)
		{
			return null;
		}

		public static void SerializeToken(this UdpPacket packet, ref IProtocolToken token)
		{
		}
	}
}
