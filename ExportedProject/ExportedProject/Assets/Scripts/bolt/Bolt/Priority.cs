using System.Collections.Generic;

namespace Bolt
{
	public struct Priority
	{
		public class Comparer : IComparer<Priority>
		{
			public static readonly Comparer Instance;

			private Comparer()
			{
			}

			private int System_002ECollections_002EGeneric_002EIComparer_003CBolt_002EPriority_003E_002ECompare(Priority x, Priority y)
			{
				return 0;
			}
		}

		public int PropertyIndex;

		public int PropertyPriority;

		public int PropertyUpdated;
	}
}
