using System;
using System.Collections.Generic;
using UnityEngine;

public class RiftBattleEventData : EventData
{
	[Serializable]
	public class BattleRewardModifier
	{
		public int winStreak;

		public float battleRewardMultiplier;
	}

	[Serializable]
	public class Seed
	{
		public int fighterScore;

		public int initialRating;

		public RiftTier initialTier;

		public Dictionary<string, object> ToDictionary()
		{
			return null;
		}
	}

	[Serializable]
	public class BattleReward
	{
		public RiftTier tier;

		public List<Loot> rewards;

		public Dictionary<string, object> ToDictionary()
		{
			return null;
		}
	}

	[SerializeField]
	private GameContentDisplayData actSelectContent;

	public BattleNodeParams[] defaultDefenseMapNodeParams;

	[SerializeField]
	private Chapter chapter;

	[SerializeField]
	private int battleLengthInMinutes;

	[SerializeField]
	private int minBattlesForSeasonRewards;

	[SerializeField]
	private List<EventTierMapping> percentileTiers;

	[SerializeField]
	private List<EventTierMapping> rankTiers;

	[SerializeField]
	[Timestamp]
	private long seedAccountCreatedBeforeDate;

	[SerializeField]
	[Timestamp]
	private long seedEndDate;

	[SerializeField]
	private List<Seed> seedsForInitialRatingAndTier;

	[SerializeField]
	private int ratingDecayIntervalMinutes;

	[SerializeField]
	private int ratingDecayIntervalAmount;

	[SerializeField]
	private int ratingDecayEventEndAmount;

	[SerializeField]
	private int ratingDecayMinimumRating;

	[SerializeField]
	private long minBattleScore;

	[SerializeField]
	private List<float> battleRewardMultipliers;

	[SerializeField]
	private float battleRewardsVictoryMultiplier;

	[SerializeField]
	private List<BattleReward> perFightBattleRewards;

	[SerializeField]
	private List<BattleReward> battleRewards;

	[SerializeField]
	private List<EventReward> rookieRewards;

	[SerializeField]
	private List<EventReward> percentileRewards;

	[SerializeField]
	private List<EventReward> rankRewards;

	private Chapter chapterCopy;

	[NonSerialized]
	private SGMatch[] userMatches;

	[NonSerialized]
	private SGMatch[] opponentMatches;

	public override EventDataType GetEventType()
	{
		return default(EventDataType);
	}

	public override GameContentDisplayData GetDisplayData()
	{
		return null;
	}

	public override GameType GetGameType()
	{
		return default(GameType);
	}

	public BattleNodeParams[] GetNodeParams()
	{
		return null;
	}

	public Chapter GetChapter(bool useOpponentData)
	{
		return null;
	}

	public SGMatch[] GetUserMatches()
	{
		return null;
	}

	public SGMatch[] GetOpponentMatches()
	{
		return null;
	}

	public int GetBattleLengthInMinutes()
	{
		return 0;
	}

	public override long GetMinScore()
	{
		return 0L;
	}

	public List<EventTierMapping> GetPercentileTiers()
	{
		return null;
	}

	public List<EventTierMapping> GetRankTiers()
	{
		return null;
	}

	public int GetRatingDecayIntervalInDays()
	{
		return 0;
	}

	public int GetExpectedModifierCount(SGMatch currentMatch)
	{
		return 0;
	}

	public float GetRewardMultiplierForWinStreak(int winStreak)
	{
		return 0f;
	}

	public override Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public override List<EventReward> GetEventRewards()
	{
		return null;
	}

	private void InitMatches()
	{
	}
}
