using System.Collections.Generic;

namespace UdpKit
{
	public struct UdpChannelName
	{
		public class Comparer : IComparer<UdpChannelName>
		{
			public static readonly Comparer Instance;

			private Comparer()
			{
			}

			private int System_002ECollections_002EGeneric_002EIComparer_003CUdpKit_002EUdpChannelName_003E_002ECompare(UdpChannelName x, UdpChannelName y)
			{
				return 0;
			}
		}

		public class EqualityComparer : IEqualityComparer<UdpChannelName>
		{
			public static readonly EqualityComparer Instance;

			private EqualityComparer()
			{
			}

			private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003CUdpKit_002EUdpChannelName_003E_002EEquals(UdpChannelName x, UdpChannelName y)
			{
				return false;
			}

			private int System_002ECollections_002EGeneric_002EIEqualityComparer_003CUdpKit_002EUdpChannelName_003E_002EGetHashCode(UdpChannelName obj)
			{
				return 0;
			}
		}

		internal int Id;

		internal string Name;

		internal UdpChannelName(int id)
		{
		}

		internal UdpChannelName(int id, string name)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
