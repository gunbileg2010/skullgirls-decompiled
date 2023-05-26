using System;
using UnityEngine;

public class GameObjectPool<T> : ObjectPool<T> where T : new()
{
	private Transform poolParentTransform;

	public GameObjectPool(int initialCapacity, Func<T> createFunction, bool dontDestroyOnLoad)
	{
		((ObjectPool<>)(object)this)._002Ector();
	}

	public override T Take()
	{
		return default(T);
	}

	public override void Return(T obj)
	{
	}

	private GameObject GetPoolObjectGO(T obj)
	{
		return null;
	}
}
