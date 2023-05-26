using System;
using System.Collections.Generic;

public class RewardCalendarInstanceServerData
{
	public string guid;

	public long firstDayTimestamp;

	public long nextRewardTimestamp;

	public long calendarResetTimestamp;

	public long expirationTimestamp;

	private int rewardDayIndex;

	private RewardCalendar calendar;

	public RewardCalendarInstanceServerData()
	{
	}

	public RewardCalendarInstanceServerData(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}

	public RewardCalendar GetClientData()
	{
		return null;
	}

	public int GetDaysRemaining()
	{
		return 0;
	}

	public int GetCurrentRewardDayIndex()
	{
		return 0;
	}

	public int GetCurrentRewardDay()
	{
		return 0;
	}

	public bool ClaimedAllRewards()
	{
		return false;
	}

	public bool RewardIsAvailableToClaim()
	{
		return false;
	}

	public DateTime GetNextRewardTime()
	{
		return default(DateTime);
	}

	public DateTime GetCalendarResetTime()
	{
		return default(DateTime);
	}
}
