using System;
using System.Collections.Generic;

namespace Bolt
{
	[Serializable]
	[Documentation]
	public struct TypeId
	{
		public class Comparer : IComparer<TypeId>
		{
			public static readonly Comparer Instance;

			private Comparer()
			{
			}

			private int System_002ECollections_002EGeneric_002EIComparer_003CBolt_002ETypeId_003E_002ECompare(TypeId x, TypeId y)
			{
				return 0;
			}
		}

		public class EqualityComparer : IEqualityComparer<TypeId>
		{
			public static readonly EqualityComparer Instance;

			private EqualityComparer()
			{
			}

			private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003CBolt_002ETypeId_003E_002EEquals(TypeId x, TypeId y)
			{
				return false;
			}

			private int System_002ECollections_002EGeneric_002EIEqualityComparer_003CBolt_002ETypeId_003E_002EGetHashCode(TypeId x)
			{
				return 0;
			}
		}

		public int Value;

		internal TypeId(int value)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public static bool operator ==(TypeId a, TypeId b)
		{
			return false;
		}

		public static bool operator !=(TypeId a, TypeId b)
		{
			return false;
		}
	}
}
