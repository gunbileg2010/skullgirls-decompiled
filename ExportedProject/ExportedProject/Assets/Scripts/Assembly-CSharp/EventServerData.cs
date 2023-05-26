using System;
using System.Collections.Generic;

public class EventServerData
{
	public string eventId;

	public string eventGuid;

	public DateTime startDateTime;

	public DateTime endDateTime;

	private EventData clientEventData;

	protected long score;

	protected bool hasEntered;

	protected int winstreak;

	protected int restorableStreak;

	protected DateTime winStreakResetTime;

	protected int eloRating;

	protected int tier;

	protected List<string> defenseTeamIds;

	protected List<FightHistoryServerData> defenseHistory;

	public EventServerData()
	{
	}

	public EventServerData(Dictionary<string, object> dataDict)
	{
	}

	public virtual void ParseData(Dictionary<string, object> dataDict)
	{
	}

	public bool IsCurrentlyActive()
	{
		return false;
	}

	public long GetScore()
	{
		return 0L;
	}

	public void SetScore(long score)
	{
	}

	public bool HasEnteredEvent()
	{
		return false;
	}

	public void SetHasEntered(bool hasEntered)
	{
	}

	public int GetWinStreak()
	{
		return 0;
	}

	public void SetWinStreak(int streak)
	{
	}

	public DateTime GetWinStreakResetTime()
	{
		return default(DateTime);
	}

	public void SetWinStreakResetTime(DateTime resetTime)
	{
	}

	public int GetRestorableStreak()
	{
		return 0;
	}

	public void SetRestorableStreak(int streak)
	{
	}

	public int GetEloRating()
	{
		return 0;
	}

	public int GetEventTier()
	{
		return 0;
	}

	public List<string> GetDefenseTeamIds()
	{
		return null;
	}

	public void SetDefenseTeamIds(List<string> teamIds)
	{
	}

	public void ClearDefenseTeam()
	{
	}

	public List<FightHistoryServerData> GetDefenseHistory()
	{
		return null;
	}

	public void SetDefenseHistory(List<FightHistoryServerData> fightHistory)
	{
	}

	public bool HasDefensePointsToClaim()
	{
		return false;
	}

	public void ClearDefenseHistory()
	{
	}

	public virtual void UpdateFromResultsData(EventResultsServerData results)
	{
	}

	public EventData GetClientData()
	{
		return null;
	}
}
