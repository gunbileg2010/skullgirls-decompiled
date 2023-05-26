using UdpKit;

namespace Bolt
{
	internal struct PropertyIntCompressionSettings
	{
		private int _bits;

		private int _shift;

		public int BitsRequired => 0;

		public static PropertyIntCompressionSettings Create()
		{
			return default(PropertyIntCompressionSettings);
		}

		public static PropertyIntCompressionSettings Create(int bits, int shift)
		{
			return default(PropertyIntCompressionSettings);
		}

		public void Pack(UdpPacket stream, int value)
		{
		}

		public int Read(UdpPacket stream)
		{
			return 0;
		}
	}
}
