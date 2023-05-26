using System.Collections;
using System.Collections.Generic;

namespace Bolt
{
	public abstract class NetworkArray_Values<T> : NetworkObj, IEnumerable<T>, IEnumerable
	{
		private int _length;

		private int _stride;

		public int Length => 0;

		internal override NetworkStorage Storage => null;

		public new T Item
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		internal NetworkArray_Values(int length, int stride)
			: base(null)
		{
		}

		protected abstract T GetValue(int index);

		protected abstract bool SetValue(int index, T value);

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
