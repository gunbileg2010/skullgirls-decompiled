using UdpKit;

namespace Bolt
{
	internal struct PropertyFloatCompressionSettings
	{
		private int _bits;

		private float _pack;

		private float _read;

		private float _shift;

		public int BitsRequired => 0;

		public static PropertyFloatCompressionSettings Create()
		{
			return default(PropertyFloatCompressionSettings);
		}

		public static PropertyFloatCompressionSettings Create(int bits, float shift, float pack, float read)
		{
			return default(PropertyFloatCompressionSettings);
		}

		public void Pack(UdpPacket stream, float value)
		{
		}

		public float Read(UdpPacket stream)
		{
			return 0f;
		}
	}
}
