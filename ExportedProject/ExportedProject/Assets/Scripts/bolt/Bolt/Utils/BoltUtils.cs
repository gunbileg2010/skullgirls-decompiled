using System;
using System.Collections.Generic;
using System.Text;
using UdpKit;
using UnityEngine;

namespace Bolt.Utils
{
	[Documentation]
	public static class BoltUtils
	{
		public static string ToStringDetailed(this Quaternion q)
		{
			return null;
		}

		public static IProtocolToken GetProtocolToken(this UdpSession session)
		{
			return null;
		}

		public static bool NullOrEmpty(this Array array)
		{
			return false;
		}

		public static bool Has<T>(this T[] array, int index) where T : class
		{
			return false;
		}

		public static bool Has<T>(this T[] array, uint index) where T : class
		{
			return false;
		}

		public static bool TryGetIndex<T>(this T[] array, int index, out T value) where T : class
		{
			value = null;
			return false;
		}

		public static bool TryGetIndex<T>(this T[] array, uint index, out T value) where T : class
		{
			value = null;
			return false;
		}

		public static T FindComponent<T>(this Component component) where T : Component
		{
			return null;
		}

		public static T FindComponent<T>(this GameObject gameObject) where T : Component
		{
			return null;
		}

		public static T FindComponent<T>(this Transform transform) where T : Component
		{
			return null;
		}

		public static BoltConnection GetBoltConnection(this UdpConnection self)
		{
			return null;
		}

		public static string Join<T>(this IEnumerable<T> items, string seperator)
		{
			return null;
		}

		public static bool ViewPointIsOnScreen(this Vector3 vp)
		{
			return false;
		}

		public static T[] CloneArray<T>(this T[] array)
		{
			return null;
		}

		public static T[] AddFirst<T>(this T[] array, T item)
		{
			return null;
		}

		public static void WriteUniqueId(this UdpPacket stream, UniqueId id)
		{
		}

		public static UniqueId ReadUniqueId(this UdpPacket stream)
		{
			return default(UniqueId);
		}

		public static void WriteByteArraySimple(this UdpPacket stream, byte[] array, int maxLength)
		{
		}

		public static byte[] ReadByteArraySimple(this UdpPacket stream)
		{
			return null;
		}

		public static void WriteColor32RGBA(this UdpPacket stream, Color32 value)
		{
		}

		public static Color32 ReadColor32RGBA(this UdpPacket stream)
		{
			return default(Color32);
		}

		public static void WriteColor32RGB(this UdpPacket stream, Color32 value)
		{
		}

		public static Color32 ReadColor32RGB(this UdpPacket stream)
		{
			return default(Color32);
		}

		public static void WriteVector2(this UdpPacket stream, Vector2 value)
		{
		}

		public static Vector2 ReadVector2(this UdpPacket stream)
		{
			return default(Vector2);
		}

		public static void WriteVector3(this UdpPacket stream, Vector3 value)
		{
		}

		public static Vector3 ReadVector3(this UdpPacket stream)
		{
			return default(Vector3);
		}

		public static void WriteColorRGB(this UdpPacket stream, Color value)
		{
		}

		public static Color ReadColorRGB(this UdpPacket stream)
		{
			return default(Color);
		}

		public static void WriteVector4(this UdpPacket stream, Vector4 value)
		{
		}

		public static Vector4 ReadVector4(this UdpPacket stream)
		{
			return default(Vector4);
		}

		public static void WriteColorRGBA(this UdpPacket stream, Color value)
		{
		}

		public static Color ReadColorRGBA(this UdpPacket stream)
		{
			return default(Color);
		}

		public static void WriteQuaternion(this UdpPacket stream, Quaternion value)
		{
		}

		public static Quaternion ReadQuaternion(this UdpPacket stream)
		{
			return default(Quaternion);
		}

		public static void WriteTransform(this UdpPacket stream, Transform transform)
		{
		}

		public static void ReadTransform(this UdpPacket stream, Transform transform)
		{
		}

		public static void ReadTransform(this UdpPacket stream, out Vector3 position, out Quaternion rotation)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
		}

		public static void WriteRigidbody(this UdpPacket stream, Rigidbody rigidbody)
		{
		}

		public static void ReadRigidbody(this UdpPacket stream, Rigidbody rigidbody)
		{
		}

		public static void ReadRigidbody(this UdpPacket stream, out Vector3 position, out Quaternion rotation, out Vector3 velocity, out Vector3 angularVelocity)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
			velocity = default(Vector3);
			angularVelocity = default(Vector3);
		}

		public static void WriteBounds(this UdpPacket stream, Bounds b)
		{
		}

		public static Bounds ReadBounds(this UdpPacket stream)
		{
			return default(Bounds);
		}

		public static void WriteRect(this UdpPacket stream, Rect rect)
		{
		}

		public static Rect ReadRect(this UdpPacket stream)
		{
			return default(Rect);
		}

		public static void WriteRay(this UdpPacket stream, Ray ray)
		{
		}

		public static Ray ReadRay(this UdpPacket stream)
		{
			return default(Ray);
		}

		public static void WritePlane(this UdpPacket stream, Plane plane)
		{
		}

		public static Plane ReadPlane(this UdpPacket stream)
		{
			return default(Plane);
		}

		public static void WriteLayerMask(this UdpPacket stream, LayerMask mask)
		{
		}

		public static LayerMask ReadLayerMask(this UdpPacket stream)
		{
			return default(LayerMask);
		}

		public static void WriteMatrix4x4(this UdpPacket stream, Matrix4x4 m)
		{
		}

		public static Matrix4x4 ReadMatrix4x4(this UdpPacket stream)
		{
			return default(Matrix4x4);
		}

		public static void WriteIntVB(this UdpPacket packet, int v)
		{
		}

		public static int ReadIntVB(this UdpPacket packet)
		{
			return 0;
		}

		public static void WriteUIntVB(this UdpPacket packet, uint v)
		{
		}

		public static uint ReadUIntVB(this UdpPacket packet)
		{
			return 0u;
		}

		public static void WriteLongVB(this UdpPacket p, long v)
		{
		}

		public static long ReadLongVB(this UdpPacket p)
		{
			return 0L;
		}

		public static void WriteULongVB(this UdpPacket p, ulong v)
		{
		}

		public static ulong ReadULongVB(this UdpPacket p)
		{
			return 0uL;
		}

		public static void WriteBoltEntity(this UdpPacket packet, BoltEntity entity)
		{
		}

		public static BoltEntity ReadBoltEntity(this UdpPacket packet)
		{
			return null;
		}

		internal static void WriteEntity(this UdpPacket packet, Entity entity)
		{
		}

		internal static Entity ReadEntity(this UdpPacket packet)
		{
			return null;
		}

		public static void WriteNetworkId(this UdpPacket packet, NetworkId id)
		{
		}

		public static NetworkId ReadNetworkId(this UdpPacket packet)
		{
			return default(NetworkId);
		}

		internal static void WriteContinueMarker(this UdpPacket stream)
		{
		}

		internal static void WriteStopMarker(this UdpPacket stream)
		{
		}

		internal static bool ReadStopMarker(this UdpPacket stream)
		{
			return false;
		}

		private static void ByteToString(byte value, StringBuilder sb)
		{
		}

		private static void ByteToString(byte value, int bits, StringBuilder sb)
		{
		}

		public static string ByteToString(byte value, int bits)
		{
			return null;
		}

		public static string ByteToString(byte value)
		{
			return null;
		}

		public static string UShortToString(ushort value)
		{
			return null;
		}

		public static string IntToString(int value)
		{
			return null;
		}

		public static string UIntToString(uint value)
		{
			return null;
		}

		public static string ULongToString(ulong value)
		{
			return null;
		}

		public static string BytesToString(byte[] values)
		{
			return null;
		}
	}
}
