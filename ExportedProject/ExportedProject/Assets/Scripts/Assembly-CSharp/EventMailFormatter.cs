using System.Collections.Generic;

public class EventMailFormatter : MailFormatter
{
	public override string GetBody(string body, Dictionary<string, string> metadata)
	{
		return null;
	}

	private string UpdateBodyWithPercentileRankRewards(string body, List<EventReward> percentileRewards, List<EventReward> rankRewards, float percent, float rankValue)
	{
		return null;
	}
}
