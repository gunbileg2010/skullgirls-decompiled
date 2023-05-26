using System;
using System.Collections.Generic;

namespace Bolt
{
	[Serializable]
	[Documentation]
	public struct PrefabId
	{
		public class Comparer : IComparer<PrefabId>
		{
			public static readonly Comparer Instance;

			private Comparer()
			{
			}

			private int System_002ECollections_002EGeneric_002EIComparer_003CBolt_002EPrefabId_003E_002ECompare(PrefabId x, PrefabId y)
			{
				return 0;
			}
		}

		public class EqualityComparer : IEqualityComparer<PrefabId>
		{
			public static readonly EqualityComparer Instance;

			private EqualityComparer()
			{
			}

			private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003CBolt_002EPrefabId_003E_002EEquals(PrefabId x, PrefabId y)
			{
				return false;
			}

			private int System_002ECollections_002EGeneric_002EIEqualityComparer_003CBolt_002EPrefabId_003E_002EGetHashCode(PrefabId x)
			{
				return 0;
			}
		}

		public int Value;

		internal PrefabId(int value)
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

		public static bool operator ==(PrefabId a, PrefabId b)
		{
			return false;
		}

		public static bool operator !=(PrefabId a, PrefabId b)
		{
			return false;
		}
	}
}
