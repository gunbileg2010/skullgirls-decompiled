using System;
using UnityEngine;

public static class HvsGameObjectExtensions
{
	public static T GetOrAddComponent<T>(this GameObject go) where T : Component
	{
		return null;
	}

	public static T GetOrAddComponentInChildren<T>(this GameObject go) where T : Component
	{
		return null;
	}

	[Obsolete]
	public static T GetComponentInParents<T>(this GameObject go) where T : Component
	{
		return null;
	}

	public static void SetLayerRecursively(this GameObject go, string layerName)
	{
	}

	public static void SetLayerRecursively(this GameObject go, int layer)
	{
	}
}
