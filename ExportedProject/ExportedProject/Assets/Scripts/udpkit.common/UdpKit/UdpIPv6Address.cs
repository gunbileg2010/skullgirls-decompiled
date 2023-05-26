using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UdpKit
{
	[StructLayout(2, Pack = 1, Size = 16)]
	public struct UdpIPv6Address : IEquatable<UdpIPv6Address>, IComparable<UdpIPv6Address>
	{
		public class Comparer : IComparer<UdpIPv6Address>, IEqualityComparer<UdpIPv6Address>
		{
			public static readonly Comparer Instance;

			private Comparer()
			{
			}

			private int System_002ECollections_002EGeneric_002EIComparer_003CUdpKit_002EUdpIPv6Address_003E_002ECompare(UdpIPv6Address x, UdpIPv6Address y)
			{
				return 0;
			}

			private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003CUdpKit_002EUdpIPv6Address_003E_002EEquals(UdpIPv6Address x, UdpIPv6Address y)
			{
				return false;
			}

			private int System_002ECollections_002EGeneric_002EIEqualityComparer_003CUdpKit_002EUdpIPv6Address_003E_002EGetHashCode(UdpIPv6Address obj)
			{
				return 0;
			}
		}

		[FieldOffset(0)]
		public static readonly UdpIPv6Address Any;

		[FieldOffset(16)]
		public static readonly UdpIPv6Address Mask;

		[FieldOffset(32)]
		public static readonly UdpIPv6Address Localhost;

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

		[FieldOffset(0)]
		public readonly ulong Packed0;

		[FieldOffset(8)]
		public readonly ulong Packed1;

		public bool IsAny => false;

		public bool IsLocalHost => false;

		public bool IsBroadcast => false;

		public bool IsWan => false;

		public bool IsPrivate => false;

		public byte[] Bytes => null;

		public UdpIPv6Address(byte[] address)
		{
		}

		public UdpIPv6Address(ulong packed0, ulong packed1)
		{
		}

		public bool Equals(UdpIPv6Address other)
		{
			return false;
		}

		public int CompareTo(UdpIPv6Address other)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public static bool operator ==(UdpIPv6Address x, UdpIPv6Address y)
		{
			return false;
		}

		public static bool operator !=(UdpIPv6Address x, UdpIPv6Address y)
		{
			return false;
		}

		public static UdpIPv6Address Parse(string address)
		{
			return default(UdpIPv6Address);
		}

		public static UdpIPv6Address operator &(UdpIPv6Address a, UdpIPv6Address b)
		{
			return default(UdpIPv6Address);
		}

		private static int CompareOrder(UdpIPv6Address x, UdpIPv6Address y)
		{
			return 0;
		}
	}
}
