using System.Collections.Generic;
using Bolt;

[Documentation]
internal class BoltObjectPool<T> where T : BoltObject, new()
{
	private readonly Stack<T> _pool;

	public T Acquire()
	{
		return null;
	}

	public void Release(T obj)
	{
	}
}
