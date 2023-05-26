using System;
using System.Collections;
using System.Collections.Generic;

namespace UdpKit
{
	public sealed class Map<K, V> : IEquatable<Map<K, V>>, IEnumerable<KeyValuePair<K, V>>, IEnumerable where K : IEquatable<K>, IComparable<K>
	{
		private static readonly Map<K, V> _empty;

		private readonly K _key;

		private readonly V _value;

		private readonly int _count;

		private readonly int _height;

		private readonly Map<K, V> _left;

		private readonly Map<K, V> _right;

		private K Key => default(K);

		private V Value => default(V);

		private Map<K, V> Left => null;

		private Map<K, V> Right => null;

		private int Balance => 0;

		public int Count => 0;

		public V Item => default(V);

		public Map()
		{
		}

		private Map(K key, V value)
		{
		}

		private Map(K key, V value, Map<K, V> left, Map<K, V> right)
		{
		}

		public Map<K, V> Add(K key, V value)
		{
			return null;
		}

		public Map<K, V> Update(K key, V value)
		{
			return null;
		}

		public Map<K, V> Remove(K key)
		{
			return null;
		}

		public V Find(K key)
		{
			return default(V);
		}

		public bool TryFind(K key, out V value)
		{
			value = default(V);
			return false;
		}

		public bool Equals(Map<K, V> other)
		{
			return false;
		}

		public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		private Map<K, V> Search(K key)
		{
			return null;
		}

		private static Map<K, V> RotateLeft(Map<K, V> map)
		{
			return null;
		}

		private static Map<K, V> RotateRight(Map<K, V> map)
		{
			return null;
		}

		private static Map<K, V> Rebalance(Map<K, V> map)
		{
			return null;
		}
	}
}
