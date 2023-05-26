using System.Collections.Generic;

public class XpRewardServerData
{
	public string backendId;

	public long experience;

	public int level;

	public long experienceGained;

	public float fromLevelProgress;

	public float toLevelProgress;

	public XpRewardServerData()
	{
	}

	public XpRewardServerData(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}
}
