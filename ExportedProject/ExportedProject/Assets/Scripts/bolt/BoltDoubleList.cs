using System.Collections;
using System.Collections.Generic;
using Bolt;

[Documentation]
public class BoltDoubleList<T> : IEnumerable<T>, IEnumerable where T : class, IBoltListNode<T>
{
	private T _first;

	private int _count;

	public int count => 0;

	public T first => null;

	public T firstOrDefault => null;

	public T last => null;

	public T lastOrDefault => null;

	public T Item => null;

	public BoltIterator<T> GetIterator()
	{
		return default(BoltIterator<T>);
	}

	public bool Contains(T node)
	{
		return false;
	}

	public bool IsFirst(T node)
	{
		return false;
	}

	public void AddLast(T node)
	{
	}

	public void AddFirst(T node)
	{
	}

	public T Remove(T node)
	{
		return null;
	}

	public T RemoveFirst()
	{
		return null;
	}

	public T RemoveLast()
	{
		return null;
	}

	public void Clear()
	{
	}

	public T Prev(T node)
	{
		return null;
	}

	public T Next(T node)
	{
		return null;
	}

	public void Replace(T node, T newNode)
	{
	}

	private void VerifyCanInsert(T node)
	{
	}

	private void VerifyInList(T node)
	{
	}

	private void InsertBefore(T node, T before)
	{
	}

	private void InsertEmpty(T node)
	{
	}

	private void RemoveNode(T node)
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

	public static implicit operator bool(BoltDoubleList<T> list)
	{
		return false;
	}
}
