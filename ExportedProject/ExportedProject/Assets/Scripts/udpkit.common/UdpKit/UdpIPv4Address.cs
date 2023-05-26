using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UdpKit
{
	[StructLayout(2, Pack = 1, Size = 4)]
	public struct UdpIPv4Address : IEquatable<UdpIPv4Address>, IComparable<UdpIPv4Address>
	{
		public class Comparer : IComparer<UdpIPv4Address>, IEqualityComparer<UdpIPv4Address>
		{
			public static readonly Comparer Instance;

			private Comparer()
			{
			}

			private int System_002ECollections_002EGeneric_002EIComparer_003CUdpKit_002EUdpIPv4Address_003E_002ECompare(UdpIPv4Address x, UdpIPv4Address y)
			{
				return 0;
			}

			private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003CUdpKit_002EUdpIPv4Address_003E_002EEquals(UdpIPv4Address x, UdpIPv4Address y)
			{
				return false;
			}

			private int System_002ECollections_002EGeneric_002EIEqualityComparer_003CUdpKit_002EUdpIPv4Address_003E_002EGetHashCode(UdpIPv4Address obj)
			{
				return 0;
			}
		}

		[FieldOffset(0)]
		public static readonly UdpIPv4Address Any;

		[FieldOffset(4)]
		public static readonly UdpIPv4Address Localhost;

		[FieldOffset(8)]
		public static readonly UdpIPv4Address Broadcast;

		[FieldOffset(0)]
		public readonly uint Packed;

		[FieldOffset(0)]
		public byte Byte0;

		[FieldOffset(1)]
		public byte Byte1;

		[FieldOffset(2)]
		public byte Byte2;

		[FieldOffset(3)]
		public byte Byte3;

		public bool IsAny => false;

		public bool IsLocalHost => false;

		public bool IsBroadcast => false;

		public bool IsPrivate => false;

		public bool IsWan => false;

		public UdpIPv4Address(uint packed)
		{
		}

		public UdpIPv4Address(long addr)
		{
		}

		public UdpIPv4Address(byte a, byte b, byte c, byte d)
		{
		}

		public bool Equals(UdpIPv4Address other)
		{
			return false;
		}

		public int CompareTo(UdpIPv4Address other)
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

		public override string ToString()
		{
			return null;
		}

		public static bool operator ==(UdpIPv4Address x, UdpIPv4Address y)
		{
			return false;
		}

		public static bool operator !=(UdpIPv4Address x, UdpIPv4Address y)
		{
			return false;
		}

		public static UdpIPv4Address operator &(UdpIPv4Address a, UdpIPv4Address b)
		{
			return default(UdpIPv4Address);
		}

		private static int CompareOrder(UdpIPv4Address x, UdpIPv4Address y)
		{
			return 0;
		}

		public static UdpIPv4Address Parse(string address)
		{
			return default(UdpIPv4Address);
		}
	}
}
