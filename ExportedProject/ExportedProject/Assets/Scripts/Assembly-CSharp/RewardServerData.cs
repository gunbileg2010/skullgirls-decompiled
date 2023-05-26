using System.Collections.Generic;

public class RewardServerData
{
	public RewardOrigin origin;

	public string associatedId;

	public List<Reward> rewards;

	public List<XpRewardServerData> characterProgress;

	public XpRewardServerData playerProgress;

	public RewardServerData()
	{
	}

	public RewardServerData(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}
}
