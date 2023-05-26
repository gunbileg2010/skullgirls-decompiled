using System.Collections;
using System.Collections.Generic;

namespace Bolt
{
	public class EntityList : IEnumerable<BoltEntity>, IEnumerable
	{
		private readonly List<Entity> _list;

		public int Count => 0;

		internal EntityList(List<Entity> l)
		{
		}

		public IEnumerator<BoltEntity> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}
}
