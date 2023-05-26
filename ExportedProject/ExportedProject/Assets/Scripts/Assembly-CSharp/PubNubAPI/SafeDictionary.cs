using System;
using System.Collections;
using System.Collections.Generic;

namespace PubNubAPI
{
	public class SafeDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		private readonly object syncRoot;

		private readonly Dictionary<TKey, TValue> d;

		public ICollection<TKey> Keys => null;

		public ICollection<TValue> Values => null;

		public TValue Item
		{
			get
			{
				return default(TValue);
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool IsReadOnly => false;

		public void Add(TKey key, TValue value)
		{
		}

		public TValue AddOrUpdate(TKey key, TValue value, Func<TKey, TValue, TValue> f)
		{
			return default(TValue);
		}

		public TValue GetOrAdd(TKey key, TValue value)
		{
			return default(TValue);
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		public bool Remove(TKey key)
		{
			return false;
		}

		public bool TryRemove(TKey key, out TValue value)
		{
			value = default(TValue);
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default(TValue);
			return false;
		}

		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}
}
