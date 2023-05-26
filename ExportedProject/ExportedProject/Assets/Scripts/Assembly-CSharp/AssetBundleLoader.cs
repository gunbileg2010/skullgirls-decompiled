using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AssetBundleLoader
{
	private const int kAssetBundleLoadRetriesBeforeReDownload = 3;

	private static Dictionary<string, AssetBundle> loadedAssetBundles;

	public static bool IsAssetBundleLoaded(string name)
	{
		return false;
	}

	public static bool LoadAssetBundle(string name, string path)
	{
		return false;
	}

	public static void UnloadAssetBundle(string name)
	{
	}

	public static void UnloadAllAssetBundles()
	{
	}

	public static T LoadAsset<T>(string assetPath, string assetBundleNameOverride = "") where T : UnityEngine.Object
	{
		return null;
	}

	public static IEnumerator LoadAssetAsync<T>(string assetPath, Action<T> callback, string assetBundleNameOverride = "") where T : UnityEngine.Object
	{
		return null;
	}

	public static TextAsset LoadLocalizationFromBundle(string languageFilename)
	{
		return null;
	}

	private static AssetBundle GetAssetBundle(string name)
	{
		return null;
	}
}
