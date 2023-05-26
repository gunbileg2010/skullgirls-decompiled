using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Bolt
{
	[StructLayout(2)]
	[Documentation]
	public struct UniqueId : IEquatable<UniqueId>
	{
		public class EqualityComparer : IEqualityComparer<UniqueId>
		{
			public static readonly EqualityComparer Instance;

			private EqualityComparer()
			{
			}

			private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003CBolt_002EUniqueId_003E_002EEquals(UniqueId x, UniqueId y)
			{
				return false;
			}

			private int System_002ECollections_002EGeneric_002EIEqualityComparer_003CBolt_002EUniqueId_003E_002EGetHashCode(UniqueId x)
			{
				return 0;
			}
		}

		[FieldOffset(0)]
		internal Guid guid;

		[FieldOffset(0)]
		internal uint uint0;

		[FieldOffset(4)]
		internal uint uint1;

		[FieldOffset(8)]
		internal uint uint2;

		[FieldOffset(12)]
		internal uint uint3;

		[FieldOffset(0)]
		private byte byte0;

		[FieldOffset(1)]
		private byte byte1;

		[FieldOffset(2)]
		private byte byte2;

		[FieldOffset(3)]
		private byte byte3;

		[FieldOffset(4)]
		private byte byte4;

		[FieldOffset(5)]
		private byte byte5;

		[FieldOffset(6)]
		private byte byte6;

		[FieldOffset(7)]
		private byte byte7;

		[FieldOffset(8)]
		private byte byte8;

		[FieldOffset(9)]
		private byte byte9;

		[FieldOffset(10)]
		private byte byte10;

		[FieldOffset(11)]
		private byte byte11;

		[FieldOffset(12)]
		private byte byte12;

		[FieldOffset(13)]
		private byte byte13;

		[FieldOffset(14)]
		private byte byte14;

		[FieldOffset(15)]
		private byte byte15;

		public string IdString => null;

		public bool IsNone => false;

		public static UniqueId None => default(UniqueId);

		public UniqueId(string guid)
		{
		}

		public UniqueId(byte[] bytes)
		{
		}

		public UniqueId(byte byte0, byte byte1, byte byte2, byte byte3, byte byte4, byte byte5, byte byte6, byte byte7, byte byte8, byte byte9, byte byte10, byte byte11, byte byte12, byte byte13, byte byte14, byte byte15)
		{
		}

		public byte[] ToByteArray()
		{
			return null;
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

		public static UniqueId New()
		{
			return default(UniqueId);
		}

		public static UniqueId Parse(string text)
		{
			return default(UniqueId);
		}

		private bool System_002EIEquatable_003CBolt_002EUniqueId_003E_002EEquals(UniqueId other)
		{
			return false;
		}

		public static bool operator ==(UniqueId a, UniqueId b)
		{
			return false;
		}

		public static bool operator !=(UniqueId a, UniqueId b)
		{
			return false;
		}
	}
}
