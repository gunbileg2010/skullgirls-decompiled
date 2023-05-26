using UdpKit;
using UnityEngine;

namespace Bolt
{
	internal struct PropertyVectorCompressionSettings
	{
		public bool StrictComparison;

		public PropertyFloatCompressionSettings X;

		public PropertyFloatCompressionSettings Y;

		public PropertyFloatCompressionSettings Z;

		public int BitsRequired => 0;

		public static PropertyVectorCompressionSettings Create(PropertyFloatCompressionSettings x, PropertyFloatCompressionSettings y, PropertyFloatCompressionSettings z)
		{
			return default(PropertyVectorCompressionSettings);
		}

		public static PropertyVectorCompressionSettings Create(PropertyFloatCompressionSettings x, PropertyFloatCompressionSettings y, PropertyFloatCompressionSettings z, bool strict)
		{
			return default(PropertyVectorCompressionSettings);
		}

		public void Pack(UdpPacket stream, Vector3 value)
		{
		}

		public Vector3 Read(UdpPacket stream)
		{
			return default(Vector3);
		}
	}
}
