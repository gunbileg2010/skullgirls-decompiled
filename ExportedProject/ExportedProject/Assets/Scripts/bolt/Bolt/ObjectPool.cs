using System.Collections.Generic;

namespace Bolt
{
	public class ObjectPool<T> where T : new()
	{
		private Stack<T> _pool;

		public void Return(T obj)
		{
		}

		public T Get()
		{
			return default(T);
		}
	}
}
