using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UdpKit
{
	[StructLayout(2, Pack = 1, Size = 24)]
	public struct UdpEndPoint : IEquatable<UdpEndPoint>, IComparable<UdpEndPoint>
	{
		[StructLayout(0, Pack = 1, Size = 6)]
		public struct Native
		{
			public UdpIPv4Address Address;

			public ushort Port;

			public UdpEndPoint AsManaged => default(UdpEndPoint);
		}

		public class Comparer : IEqualityComparer<UdpEndPoint>
		{
			private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003CUdpKit_002EUdpEndPoint_003E_002EEquals(UdpEndPoint x, UdpEndPoint y)
			{
				return false;
			}

			private int System_002ECollections_002EGeneric_002EIEqualityComparer_003CUdpKit_002EUdpEndPoint_003E_002EGetHashCode(UdpEndPoint obj)
			{
				return 0;
			}
		}

		[FieldOffset(0)]
		public static readonly UdpEndPoint Any;

		[FieldOffset(24)]
		public static readonly UdpEndPoint AnyIPv6;

		[FieldOffset(0)]
		public readonly ushort Port;

		[FieldOffset(0)]
		public readonly UdpSteamID SteamId;

		[FieldOffset(4)]
		public readonly bool IPv6;

		[FieldOffset(8)]
		public readonly UdpIPv4Address Address;

		[FieldOffset(8)]
		public readonly UdpIPv6Address AddressIPv6;

		public bool IsWan => false;

		public bool IsLan => false;

		public Native AsNative => default(Native);

		public UdpEndPoint(UdpIPv4Address address, ushort port)
		{
		}

		public UdpEndPoint(UdpIPv6Address address, ushort port)
		{
		}

		public UdpEndPoint(UdpSteamID steamId)
		{
		}

		public int CompareTo(UdpEndPoint other)
		{
			return 0;
		}

		public bool Equals(UdpEndPoint other)
		{
			return false;
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

		public static UdpEndPoint Parse(string endpoint)
		{
			return default(UdpEndPoint);
		}

		public static bool operator ==(UdpEndPoint x, UdpEndPoint y)
		{
			return false;
		}

		public static bool operator !=(UdpEndPoint x, UdpEndPoint y)
		{
			return false;
		}

		public static UdpEndPoint operator &(UdpEndPoint a, UdpEndPoint b)
		{
			return default(UdpEndPoint);
		}

		private static int Compare(UdpEndPoint x, UdpEndPoint y)
		{
			return 0;
		}
	}
}
