using System;
using System.Collections.Generic;

public class SetLeaderboardEventStreakRequest : NetworkRequest
{
	private string eventInstanceId;

	private int streak;

	private List<FightInstanceServerData> fightInstanceServerDatas;

	public SetLeaderboardEventStreakRequest(string eventInstanceId, int streak)
	{
	}

	public override void Send(Action callback)
	{
	}

	public List<FightInstanceServerData> GetFightInstancesData()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
