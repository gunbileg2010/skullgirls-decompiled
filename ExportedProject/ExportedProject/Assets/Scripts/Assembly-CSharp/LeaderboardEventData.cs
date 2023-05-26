using System.Collections.Generic;
using UnityEngine;

public class LeaderboardEventData : EventData
{
	public enum EventDifficulty : short
	{
		Undefined = -1,
		Bronze = 0,
		Silver = 1,
		Gold = 2,
		Diamond = 3
	}

	[SerializeField]
	private GameContentDisplayData actSelectContent;

	[SerializeField]
	private EventDifficulty difficulty;

	[SerializeField]
	private float xpMultiplier;

	[SerializeField]
	private FightRequirement fightRequirement;

	[SerializeField]
	public FightConstraint[] defenseTeamConstraints;

	[SerializeField]
	private List<DynamicResource> enemyFightModifiers;

	[SerializeField]
	private List<DynamicResource> playerFightModifiers;

	[SerializeField]
	protected long minScore;

	[SerializeField]
	private List<EventReward> scoreBasedRewards;

	[SerializeField]
	private List<EventReward> percentileRewards;

	[SerializeField]
	private List<EventReward> rankRewards;

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

	public EventDifficulty GetEventDifficulty()
	{
		return default(EventDifficulty);
	}

	public float GetXpMultiplier()
	{
		return 0f;
	}

	public int GetEnergyRequirement()
	{
		return 0;
	}

	public override long GetMinScore()
	{
		return 0L;
	}

	public EventReward GetNextEventRewardForScore(long currentScore)
	{
		return null;
	}

	public EventReward GetNextOrFinalEventRewardForScore(long currentScore)
	{
		return null;
	}

	public List<EventReward> GetEventRewardsInScoreRange(long begin, long end)
	{
		return null;
	}

	public int GetMilestoneForScore(long score)
	{
		return 0;
	}

	public void SetupLeaderboardMatch()
	{
	}

	public override List<EventReward> GetEventRewards()
	{
		return null;
	}

	public override Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
