using System;
using System.Runtime.InteropServices;

namespace UdpKit
{
	public static class Blit
	{
		[StructLayout(2)]
		private struct BitUnion
		{
			[FieldOffset(0)]
			public ushort UInt16;

			[FieldOffset(0)]
			public short Int16;

			[FieldOffset(0)]
			public uint UInt32;

			[FieldOffset(0)]
			public int Int32;

			[FieldOffset(0)]
			public float Float32;

			[FieldOffset(0)]
			public byte Byte0;

			[FieldOffset(1)]
			public byte Byte1;

			[FieldOffset(2)]
			public byte Byte2;

			[FieldOffset(3)]
			public byte Byte3;
		}

		[StructLayout(2)]
		private struct BitUnion64
		{
			[FieldOffset(0)]
			public ulong UInt64;

			[FieldOffset(0)]
			public byte Byte0;

			[FieldOffset(1)]
			public byte Byte1;

			[FieldOffset(2)]
			public byte Byte2;

			[FieldOffset(3)]
			public byte Byte3;

			[FieldOffset(4)]
			public byte Byte4;

			[FieldOffset(5)]
			public byte Byte5;

			[FieldOffset(6)]
			public byte Byte6;

			[FieldOffset(7)]
			public byte Byte7;
		}

		[StructLayout(2)]
		private struct BitUnion128
		{
			[FieldOffset(0)]
			public Guid Guid;

			[FieldOffset(0)]
			public byte Byte0;

			[FieldOffset(1)]
			public byte Byte1;

			[FieldOffset(2)]
			public byte Byte2;

			[FieldOffset(3)]
			public byte Byte3;

			[FieldOffset(4)]
			public byte Byte4;

			[FieldOffset(5)]
			public byte Byte5;

			[FieldOffset(6)]
			public byte Byte6;

			[FieldOffset(7)]
			public byte Byte7;

			[FieldOffset(8)]
			public byte Byte8;

			[FieldOffset(9)]
			public byte Byte9;

			[FieldOffset(10)]
			public byte Byte10;

			[FieldOffset(11)]
			public byte Byte11;

			[FieldOffset(12)]
			public byte Byte12;

			[FieldOffset(13)]
			public byte Byte13;

			[FieldOffset(14)]
			public byte Byte14;

			[FieldOffset(15)]
			public byte Byte15;
		}

		public static bool PackBool(byte[] bytes, ref int offset, bool value)
		{
			return false;
		}

		public static bool ReadBool(byte[] bytes, ref int offset)
		{
			return false;
		}

		public static void PackByte(byte[] bytes, ref int offset, byte value)
		{
		}

		public static byte ReadByte(byte[] bytes, ref int offset)
		{
			return 0;
		}

		public static int GetBytesPrefixSize(byte[] bytes)
		{
			return 0;
		}

		public static void PackBytesPrefix(byte[] bytes, ref int offset, byte[] from)
		{
		}

		public static byte[] ReadBytesPrefix(byte[] bytes, ref int offset)
		{
			return null;
		}

		public static void PackBytes(byte[] bytes, int offset, byte[] from, int length)
		{
		}

		public static void ReadBytes(byte[] bytes, int offset, byte[] into, int length)
		{
		}

		public static void PackBytes(byte[] bytes, ref int bytesOffset, byte[] from, int fromOffset, int length)
		{
		}

		public static void ReadBytes(byte[] bytes, ref int bytesOffset, byte[] into, int intoOffset, int length)
		{
		}

		public static void PackU16(byte[] bytes, ref int offset, ushort value)
		{
		}

		public static ushort ReadU16(byte[] bytes, ref int offset)
		{
			return 0;
		}

		public static void PackI32(byte[] bytes, ref int offset, int value)
		{
		}

		public static int ReadI32(byte[] bytes, ref int offset)
		{
			return 0;
		}

		public static void PackU32(byte[] bytes, ref int offset, uint value)
		{
		}

		public static void PackU32(byte[] bytes, ref int offset, uint value, int byteCount)
		{
		}

		public static uint ReadU32(byte[] bytes, ref int offset)
		{
			return 0u;
		}

		public static uint ReadU32(byte[] bytes, ref int offset, int byteCount)
		{
			return 0u;
		}

		public static void PackF32(byte[] bytes, int offset, float value)
		{
		}

		public static float ReadF32(byte[] bytes, int offset)
		{
			return 0f;
		}

		public static void PackU64(byte[] bytes, ref int offset, ulong value)
		{
		}

		public static ulong ReadU64(byte[] bytes, ref int offset)
		{
			return 0uL;
		}

		public static int GetStringSize(string value)
		{
			return 0;
		}

		public static void PackString(byte[] bytes, ref int offset, string value)
		{
		}

		public static string ReadString(byte[] bytes, ref int offset)
		{
			return null;
		}

		public static UdpEndPoint ReadEndPoint(byte[] bytes, ref int offset)
		{
			return default(UdpEndPoint);
		}

		public static void PackEndPoint(byte[] bytes, ref int offset, UdpEndPoint endpoint)
		{
		}

		public static void PackGuid(byte[] bytes, ref int offset, Guid value)
		{
		}

		public static Guid ReadGuid(byte[] bytes, ref int offset)
		{
			return default(Guid);
		}
	}
}
