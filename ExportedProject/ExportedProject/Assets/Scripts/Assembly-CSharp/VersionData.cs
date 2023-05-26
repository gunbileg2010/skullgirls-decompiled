using UnityEngine;

public class VersionData : ScriptableObject
{
	[SerializeField]
	private int major;

	[SerializeField]
	private int minor;

	[SerializeField]
	private int patch;

	[SerializeField]
	private int versionCode;

	[SerializeField]
	[HideInInspector]
	private int vcsRevision;

	[SerializeField]
	[HideInInspector]
	private string commitIdentifier;

	private static VersionData versionData;

	public int Major => 0;

	public int Minor => 0;

	public int Patch => 0;

	public int VersionCode => 0;

	public static VersionData GetVersionData()
	{
		return null;
	}

	public string GetReleaseVersionString()
	{
		return null;
	}

	public string GetDevelopmentVersionString()
	{
		return null;
	}
}
