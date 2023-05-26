using System.Collections.Generic;

public static class ListPool<T>
{
	public static readonly ObjectPool<List<T>> pool;

	public static List<T> Take()
	{
		return null;
	}

	public static List<T> Take(int capacity)
	{
		return null;
	}

	public static void Return(List<T> list)
	{
	}
}
