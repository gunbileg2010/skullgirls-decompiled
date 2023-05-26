using System.Collections.Generic;

namespace UdpKit
{
	internal class UdpSet<T>
	{
		private readonly Dictionary<T, object> set;

		public int Count => 0;

		public bool Remove(T value)
		{
			return false;
		}

		public void Clear()
		{
		}

		public UdpSet(IEqualityComparer<T> comparer)
		{
		}

		public bool Add(T value)
		{
			return false;
		}

		public bool Contains(T value)
		{
			return false;
		}
	}
}
