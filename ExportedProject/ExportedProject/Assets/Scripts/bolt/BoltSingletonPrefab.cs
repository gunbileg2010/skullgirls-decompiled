using Bolt;
using UnityEngine;

[Documentation]
public abstract class BoltSingletonPrefab<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T _instance;

	protected static string _resourcePath;

	public static T instance => null;

	public static void Instantiate()
	{
	}
}
