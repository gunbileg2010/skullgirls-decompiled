using System.Collections.Generic;

public class FightResultServerData
{
	public List<RewardServerData> characterLevelUpBundles;

	private List<RewardServerData> rewardBundles;

	private Dictionary<RewardOrigin, List<Reward>> fightRewardsDictionary;

	private EventResultsServerData eventResultData;

	private byte matchChallengesResults;

	public FightResultServerData()
	{
	}

	public FightResultServerData(Dictionary<string, object> dataDict)
	{
	}

	public virtual void ParseData(Dictionary<string, object> dataDict)
	{
	}

	public List<Reward> GetRewardBundle(RewardOrigin origin)
	{
		return null;
	}

	public Dictionary<RewardOrigin, List<Reward>> GetRewardBundles()
	{
		return null;
	}

	public void SetRewardBundles(List<RewardServerData> rewardServerDatas)
	{
	}

	public RewardServerData GetPlayerLevelUpData()
	{
		return null;
	}

	public List<XpRewardServerData> GetCharacterXpRewards()
	{
		return null;
	}

	public XpRewardServerData GetPlayerXpReward()
	{
		return null;
	}

	public EventResultsServerData GetEventResults()
	{
		return null;
	}

	public byte GetMatchChallengesResults()
	{
		return 0;
	}
}
