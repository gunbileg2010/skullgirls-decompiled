using System.Collections;
using System.Collections.Generic;
using Bolt;

[Documentation]
public class BoltRingBuffer<T> : IEnumerable<T>, IEnumerable
{
	private int _head;

	private int _tail;

	private int _count;

	private bool _autofree;

	private readonly T[] array;

	public bool full => false;

	public bool empty => false;

	public bool autofree
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int count => 0;

	public T last
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	public T first
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

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

	public BoltRingBuffer(int size)
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

	public void CopyTo(BoltRingBuffer<T> other)
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
