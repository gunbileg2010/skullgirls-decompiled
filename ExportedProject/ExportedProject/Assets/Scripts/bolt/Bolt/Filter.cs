using System.Collections.Generic;

namespace Bolt
{
	[Documentation]
	public struct Filter
	{
		[Documentation]
		public class EqualityComparer : IEqualityComparer<Filter>
		{
			public static readonly EqualityComparer Instance;

			private EqualityComparer()
			{
			}

			private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003CBolt_002EFilter_003E_002EEquals(Filter a, Filter b)
			{
				return false;
			}

			private int System_002ECollections_002EGeneric_002EIEqualityComparer_003CBolt_002EFilter_003E_002EGetHashCode(Filter f)
			{
				return 0;
			}
		}

		internal readonly int Bits;

		internal static string[] Names;

		internal Filter(int bits)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator bool(Filter a)
		{
			return false;
		}

		public static Filter operator &(Filter a, Filter b)
		{
			return default(Filter);
		}

		public static Filter operator |(Filter a, Filter b)
		{
			return default(Filter);
		}
	}
}
