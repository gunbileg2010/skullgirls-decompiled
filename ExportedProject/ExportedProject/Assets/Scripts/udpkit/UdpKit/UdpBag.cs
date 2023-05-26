using System.Collections.Generic;

namespace UdpKit
{
	internal class UdpBag<T>
	{
		public delegate T Modifier(T item);

		public delegate bool Predicate(T item);

		private List<T> list;

		public void Add(T item)
		{
		}

		public void Remove(T item)
		{
		}

		public T[] ToArray()
		{
			return null;
		}

		public void Map(Modifier func)
		{
		}

		public void Filter(Predicate func)
		{
		}

		public bool Update(Predicate predicate, Modifier modifier)
		{
			return false;
		}
	}
}
