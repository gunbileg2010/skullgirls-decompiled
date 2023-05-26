using System.Collections.Generic;

public class Achievement
{
	public enum Status
	{
		Incomplete = 0,
		Completed = 1,
		Claimed = 2
	}

	public string id;

	public string guid;

	public Status status;

	private AchievementData achievementData;

	private int count;

	public Achievement(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}

	public AchievementData GetAchievementData()
	{
		return null;
	}

	public int GetProgress()
	{
		return 0;
	}

	public Status GetStatus()
	{
		return default(Status);
	}
}
