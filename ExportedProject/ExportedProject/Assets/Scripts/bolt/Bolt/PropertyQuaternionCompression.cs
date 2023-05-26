using UdpKit;
using UnityEngine;

namespace Bolt
{
	internal struct PropertyQuaternionCompression
	{
		private bool QuaternionMode;

		private bool QuaternionStrictComparison;

		public PropertyVectorCompressionSettings Euler;

		public PropertyFloatCompressionSettings Quaternion;

		public int BitsRequired => 0;

		public bool StrictComparison => false;

		public static PropertyQuaternionCompression Create(PropertyVectorCompressionSettings euler)
		{
			return default(PropertyQuaternionCompression);
		}

		public static PropertyQuaternionCompression Create(PropertyFloatCompressionSettings quaternion)
		{
			return default(PropertyQuaternionCompression);
		}

		public static PropertyQuaternionCompression Create(PropertyFloatCompressionSettings quaternion, bool strict)
		{
			return default(PropertyQuaternionCompression);
		}

		public void Pack(UdpPacket stream, Quaternion value)
		{
		}

		public Quaternion Read(UdpPacket stream)
		{
			return default(Quaternion);
		}
	}
}
