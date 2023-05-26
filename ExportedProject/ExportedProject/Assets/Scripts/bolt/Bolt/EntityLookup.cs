using System.Collections;
using System.Collections.Generic;

namespace Bolt
{
	public class EntityLookup : IEnumerable<BoltEntity>, IEnumerable
	{
		private readonly Dictionary<NetworkId, EntityProxy> _dict;

		public int Count => 0;

		internal EntityLookup(Dictionary<NetworkId, EntityProxy> d)
		{
		}

		public bool TryGet(NetworkId id, out BoltEntity entity)
		{
			entity = null;
			return false;
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
