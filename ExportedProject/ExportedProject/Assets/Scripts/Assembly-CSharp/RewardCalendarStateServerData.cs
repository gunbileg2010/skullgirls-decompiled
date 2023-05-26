using System.Collections.Generic;

public class RewardCalendarStateServerData
{
	public RewardCalendarInstanceServerData instance;

	public List<Reward> rewards;

	public RewardCalendarStateServerData()
	{
	}

	public RewardCalendarStateServerData(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}

	public RewardCalendar GetClientData()
	{
		return null;
	}
}
