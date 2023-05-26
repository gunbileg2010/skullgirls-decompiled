using System;
using System.Collections.Generic;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Preserve]
	internal class ThreadSafeStore<TKey, TValue>
	{
		private readonly object _lock;

		private Dictionary<TKey, TValue> _store;

		private readonly Func<TKey, TValue> _creator;

		[Preserve]
		public ThreadSafeStore(Func<TKey, TValue> creator)
		{
		}

		[Preserve]
		public TValue Get(TKey key)
		{
			return default(TValue);
		}

		[Preserve]
		private TValue AddValue(TKey key)
		{
			return default(TValue);
		}
	}
}
