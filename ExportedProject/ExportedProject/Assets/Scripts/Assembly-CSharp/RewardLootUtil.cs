using System.Collections.Generic;

public static class RewardLootUtil
{
	public static List<Loot> ParseLootsFromServerLootsList(List<object> lootsList, bool expandLootTables = true)
	{
		return null;
	}

	public static Loot ParseLootFromServerLoot(Dictionary<string, object> lootDict)
	{
		return null;
	}

	public static List<Loot> ParseLootFromServerClaimableReward(Dictionary<string, object> claimableRewardDict)
	{
		return null;
	}

	public static RewardType GetRewardTypeFromServerReward(Dictionary<string, object> rewardDict)
	{
		return default(RewardType);
	}

	public static List<RewardServerData> ParseRewardServerDatasFromServerList(List<object> rewardFromOriginList)
	{
		return null;
	}

	public static List<Reward> ToRewardsList(this List<RewardServerData> list)
	{
		return null;
	}

	public static List<Reward> ToRewardsList(this List<Loot> list)
	{
		return null;
	}

	public static List<Reward> GetRewardsFromOrigin(this List<RewardServerData> list, RewardOrigin origin)
	{
		return null;
	}

	public static List<Reward> ParseRewardListFromServerReward(Dictionary<string, object> rewardDict)
	{
		return null;
	}

	public static Dictionary<LootType, object> ConsolidateRewards(List<Reward> rewards)
	{
		return null;
	}

	public static List<Stat> ProcessMoveRewardDataToStatList(Dictionary<string, object> moveDict)
	{
		return null;
	}

	public static void SortSkipEventRewards(List<RewardServerData> rewardServerDatas)
	{
	}

	private static List<Loot> ParseLootFromRewardDict(Dictionary<string, object> dict, bool isClaimableReward)
	{
		return null;
	}

	private static void ConsolidateRewardsRecursive(ref Dictionary<LootType, object> consolidatedRewards, List<Reward> rewards)
	{
	}

	private static void AddValueToConsolidatedRewardsDictionary(Dictionary<LootType, object> consolidatedRewards, LootType type, int value)
	{
	}

	private static void AddValueToConsolidatedRewardsDictionary(Dictionary<LootType, object> consolidatedRewards, LootType type, string specific, int value)
	{
	}
}
