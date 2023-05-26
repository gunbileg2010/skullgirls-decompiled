using UnityEngine;

public abstract class GuidScriptableObject : ScriptableObject
{
	[SerializeField]
	[Lockable]
	protected string guid;

	[SerializeField]
	protected string humanReadableGuid;

	public string GetGuid()
	{
		return null;
	}

	public string GetHumanReadableGuid()
	{
		return null;
	}

	public virtual bool HasIssues()
	{
		return false;
	}

	public static T CreateInstanceWithHumanReadibleGUID<T>(string humanReadibleGuid) where T : GuidScriptableObject
	{
		return null;
	}
}
