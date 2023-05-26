using System.Collections;
using System.Collections.Generic;

namespace UdpKit
{
	public class UdpRingBuffer<T> : IEnumerable<T>, IEnumerable
	{
		private int _head;

		private int _tail;

		private int _count;

		private bool _autofree;

		private readonly T[] array;

		public bool Full => false;

		public float FillRatio => 0f;

		public bool Empty => false;

		public bool AutoFree
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int Count => 0;

		public T First
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public T FirstOrDefault => default(T);

		public T Last
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public T LastOrDefault => default(T);

		public T Item
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public UdpRingBuffer(int size)
		{
		}

		public void Enqueue(T item)
		{
		}

		public T Dequeue()
		{
			return default(T);
		}

		public T Peek()
		{
			return default(T);
		}

		public void Clear()
		{
		}

		public void CopyTo(UdpRingBuffer<T> other)
		{
		}

		private void VerifyNotEmpty()
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
