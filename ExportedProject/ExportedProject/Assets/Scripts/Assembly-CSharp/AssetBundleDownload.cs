using System;

[Serializable]
public class AssetBundleDownload : IComparable<AssetBundleDownload>
{
	public string name;

	public int priority;

	public AssetBundleDownload()
	{
	}

	public AssetBundleDownload(string name, int priority)
	{
	}

	public string GetRelativeUrl()
	{
		return null;
	}

	public string GetLocalPath(bool useEditorPaths)
	{
		return null;
	}

	public int CompareTo(AssetBundleDownload other)
	{
		return 0;
	}
}
