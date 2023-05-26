using UnityEngine;

namespace Bolt
{
	[Documentation]
	internal static class Math
	{
		internal static float InterpolateFloat(BoltDoubleList<NetworkStorage> frames, int offset, int frame, bool angle)
		{
			return 0f;
		}

		internal static Vector3 InterpolateVector(BoltDoubleList<NetworkStorage> frames, int offset, int frame, float snapLimit)
		{
			return default(Vector3);
		}

		internal static Vector3 InterpolateVector(BoltDoubleList<NetworkStorage> frames, int offset, int frame, float snapLimit, ref bool snapped)
		{
			return default(Vector3);
		}

		internal static Quaternion InterpolateQuaternion(BoltDoubleList<NetworkStorage> frames, int offset, int frame)
		{
			return default(Quaternion);
		}

		internal static Vector3 ExtrapolateVector(Vector3 cpos, Vector3 rpos, Vector3 rvel, int recievedFrame, int entityFrame, PropertyExtrapolationSettings settings, ref bool snapped)
		{
			return default(Vector3);
		}

		internal static Quaternion ExtrapolateQuaternion(Quaternion cquat, Quaternion rquat, int recievedFrame, int entityFrame, PropertyExtrapolationSettings settings)
		{
			return default(Quaternion);
		}

		internal static int SequenceDistance(uint from, uint to, int shift)
		{
			return 0;
		}

		public static int HighBit(uint v)
		{
			return 0;
		}

		public static int BytesRequired(int bits)
		{
			return 0;
		}

		public static int BitsRequired(int number)
		{
			return 0;
		}

		public static int PopCount(ulong value)
		{
			return 0;
		}
	}
}
