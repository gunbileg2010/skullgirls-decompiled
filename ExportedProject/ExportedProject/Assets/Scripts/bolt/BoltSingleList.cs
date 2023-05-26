using System.Collections;
using System.Collections.Generic;
using Bolt;

[Documentation]
public class BoltSingleList<T> : IEnumerable<T>, IEnumerable where T : class, IBoltListNode<T>
{
	private T _head;

	private T _tail;

	private int _count;

	public int count => 0;

	public T first => null;

	public T last => null;

	public BoltIterator<T> GetIterator()
	{
		return default(BoltIterator<T>);
	}

	public void AddFirst(T item)
	{
	}

	public void AddLast(T item)
	{
	}

	public T PeekFirst()
	{
		return null;
	}

	public T RemoveFirst()
	{
		return null;
	}

	public void Clear()
	{
	}

	public T Next(T item)
	{
		return null;
	}

	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	private void VerifyNotEmpty()
	{
	}

	private void VerifyCanInsert(T node)
	{
	}

	private void VerifyInList(T node)
	{
	}

	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	public static implicit operator bool(BoltSingleList<T> list)
	{
		return false;
	}
}
