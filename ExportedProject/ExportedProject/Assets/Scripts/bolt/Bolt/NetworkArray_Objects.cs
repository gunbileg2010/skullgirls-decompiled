using System.Collections;
using System.Collections.Generic;

namespace Bolt
{
	[Documentation]
	public class NetworkArray_Objects<T> : NetworkObj, IEnumerable<T>, IEnumerable where T : NetworkObj
	{
		private int _length;

		private int _stride;

		public int Length => 0;

		internal override NetworkStorage Storage => null;

		public new T Item => null;

		internal NetworkArray_Objects(int length, int stride)
			: base(null)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}
}
