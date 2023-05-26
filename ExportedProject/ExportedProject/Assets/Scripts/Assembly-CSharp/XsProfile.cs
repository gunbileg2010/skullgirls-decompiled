using System.Collections.Generic;

public class XsProfile
{
	public string publicUserId;

	public string playerHandle;

	public float playerLevel;

	public RiftTier riftTier;

	public int riftRating;

	public XsCharacter repCharacter;

	public bool isDeveloper;

	public XsProfile()
	{
	}

	public XsProfile(Profile profile)
	{
	}

	public XsProfile(Dictionary<string, object> dataDict)
	{
	}

	public void Populate(Profile profile)
	{
	}

	public void Populate(Dictionary<string, object> dataDict)
	{
	}

	public int GetPlayerLevel()
	{
		return 0;
	}

	public float GetPlayerLevelProgress()
	{
		return 0f;
	}

	public Dictionary<string, object> ToDictionary()
	{
		return null;
	}

	private void FromDictionary(Dictionary<string, object> dataDict)
	{
	}
}
