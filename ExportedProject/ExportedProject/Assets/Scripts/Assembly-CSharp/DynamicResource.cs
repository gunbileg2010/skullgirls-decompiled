using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DynamicResource
{
	public enum LoadType : byte
	{
		Resources = 0,
		AssetBundle = 1
	}

	public static bool debug;

	[SerializeField]
	private string resourcePath;

	[SerializeField]
	private LoadType resourceLoadType;

	[SerializeField]
	private string bundleName;

	private static Dictionary<string, int> referenceCounters;

	private static bool needUnloadUnusedAssets;

	[NonSerialized]
	private UnityEngine.Object resourceObject;

	public static void CheckNeedsUnloadUnusedAssets()
	{
	}

	public static Dictionary<string, int> GetReferenceCounters()
	{
		return null;
	}

	public DynamicResource(string path, LoadType loadType, string loadTypeContext = null)
	{
	}

	public void SetPath(string path)
	{
	}

	public string GetPath()
	{
		return null;
	}

	public LoadType GetLoadType()
	{
		return default(LoadType);
	}

	public void SetLoadType(LoadType loadType)
	{
	}

	public string GetBundleName()
	{
		return null;
	}

	public void SetBundleName(string name)
	{
	}

	public void UpdateResource(DynamicResource dynamicResource)
	{
	}

	public void UpdateResource(string path, LoadType loadType, string bundleName)
	{
	}

	public bool IsValid()
	{
		return false;
	}

	public T Take<T>() where T : UnityEngine.Object
	{
		return null;
	}

	public bool Return()
	{
		return false;
	}
}
