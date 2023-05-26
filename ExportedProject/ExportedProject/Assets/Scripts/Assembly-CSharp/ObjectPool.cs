using System;
using System.Collections.Generic;

public class ObjectPool<T> where T : new()
{
	private Stack<T> pool;

	private Func<T> createNewObject;

	private Action<T> actionOnTake;

	private Action<T> actionOnReturn;

	private int createCount;

	private bool enabled;

	public ObjectPool()
	{
	}

	public ObjectPool(int initialCapacity)
	{
	}

	public ObjectPool(Action<T> actionOnTake, Action<T> actionOnReturn)
	{
	}

	public ObjectPool(int initialCapacity, Action<T> actionOnTake, Action<T> actionOnReturn)
	{
	}

	public ObjectPool(int initialCapacity, Func<T> createFunction)
	{
	}

	public virtual T Take()
	{
		return default(T);
	}

	public virtual void Return(T obj)
	{
	}

	public int GetTotalCount()
	{
		return 0;
	}

	public int GetActiveCount()
	{
		return 0;
	}

	public int GetInactiveCount()
	{
		return 0;
	}

	public void SetEnabled(bool enabled)
	{
	}
}
