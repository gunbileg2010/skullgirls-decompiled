using UnityEngine;

public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private class SingletonFactory
	{
		public static T instance;

		static SingletonFactory()
		{
		}

		private SingletonFactory()
		{
		}

		public static T GetInstance(bool create = false)
		{
			return null;
		}

		public static void SetInstance(T theInstance)
		{
		}

		public static bool HasInstance()
		{
			return false;
		}

		public static void ClearInstance()
		{
		}
	}

	public bool dontDestroyOnLoad;

	public static T I => null;

	public static T IC => null;

	protected virtual void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public static bool Exists()
	{
		return false;
	}
}
