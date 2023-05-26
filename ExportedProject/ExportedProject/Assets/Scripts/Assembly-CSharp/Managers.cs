using System;
using System.Collections.Generic;
using HVS;

public static class Managers
{
	private static Dictionary<Type, object> managers;

	private static GameStateManager gameStateManager;

	public static EventManager Events => null;

	public static CoroutineManager Coroutines => null;

	public static IRunOnMainThread RunOnMainThread => null;

	public static GameStateManager GameState
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static InputManager Input => null;

	public static PopupManager Popups => null;

	public static WWWManager WWW => null;

	public static void Set<T>(T concreteInstance)
	{
	}

	public static void Set(Type interfaceType, object concreteInstance)
	{
	}

	public static T Get<T>()
	{
		return default(T);
	}

	public static void Remove(Type managerType)
	{
	}

	public static void Remove<T>()
	{
	}

	public static bool Exists<T>()
	{
		return false;
	}
}
