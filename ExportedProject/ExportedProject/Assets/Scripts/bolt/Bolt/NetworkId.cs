using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Bolt
{
	[StructLayout(2)]
	public struct NetworkId : IEquatable<NetworkId>
	{
		public class EqualityComparer : IEqualityComparer<NetworkId>
		{
			public static readonly EqualityComparer Instance;

			private EqualityComparer()
			{
			}

			private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003CBolt_002ENetworkId_003E_002EEquals(NetworkId x, NetworkId y)
			{
				return false;
			}

			private int System_002ECollections_002EGeneric_002EIEqualityComparer_003CBolt_002ENetworkId_003E_002EGetHashCode(NetworkId x)
			{
				return 0;
			}
		}

		[FieldOffset(0)]
		internal ulong Packed;

		[FieldOffset(0)]
		internal readonly uint Connection;

		[FieldOffset(4)]
		internal readonly uint Entity;

		public bool IsZero => false;

		public ulong PackedValue => 0uL;

		public NetworkId(ulong packed)
		{
		}

		internal NetworkId(uint connection, uint entity)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool operator ==(NetworkId a, NetworkId b)
		{
			return false;
		}

		public static bool operator !=(NetworkId a, NetworkId b)
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

		private bool System_002EIEquatable_003CBolt_002ENetworkId_003E_002EEquals(NetworkId other)
		{
			return false;
		}
	}
}
