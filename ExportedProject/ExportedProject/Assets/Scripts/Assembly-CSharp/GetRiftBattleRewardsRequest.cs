using System;
using System.Collections.Generic;

public class GetRiftBattleRewardsRequest : NetworkRequest
{
	private string eventInstanceId;

	private string battleInstanceId;

	private List<Reward> rewards;

	private int winStreak;

	private long winStreakResetTime;

	public GetRiftBattleRewardsRequest(string eventInstanceId, string battleInstanceId)
	{
	}

	public override void Send(Action callback)
	{
	}

	public List<Reward> GetRewards()
	{
		return null;
	}

	public int GetWinStreak()
	{
		return 0;
	}

	public DateTime GetWinStreakResetTime()
	{
		return default(DateTime);
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
