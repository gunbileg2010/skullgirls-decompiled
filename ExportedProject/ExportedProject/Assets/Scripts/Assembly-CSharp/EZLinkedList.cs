using System.Collections.Generic;

public class EZLinkedList<T> where T : IEZLinkedListItem<T>
{
	private List<EZLinkedListIterator<T>> iters;

	private List<EZLinkedListIterator<T>> freeIters;

	protected T head;

	protected T cur;

	protected T nextItem;

	protected int count;

	public int Count => 0;

	public bool Empty => false;

	public T Head => default(T);

	public T Current
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	public EZLinkedListIterator<T> Begin()
	{
		return null;
	}

	public void End(EZLinkedListIterator<T> it)
	{
	}

	public bool Rewind()
	{
		return false;
	}

	public bool MoveNext()
	{
		return false;
	}

	public void Add(T item)
	{
	}

	public void Remove(T item)
	{
	}

	public void Clear()
	{
	}
}
