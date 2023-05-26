using System;
using System.Collections.Generic;

public class RestoreLeaderboardEventStreakRequest : NetworkRequest
{
	private string eventId;

	private List<FightInstanceServerData> fightInstanceServerDatas;

	public RestoreLeaderboardEventStreakRequest()
	{
	}

	public RestoreLeaderboardEventStreakRequest(string eventId)
	{
	}

	public override void Send(Action callback)
	{
	}

	public FightInstanceServerData GetFightInstanceData()
	{
		return null;
	}

	public List<FightInstanceServerData> GetFightInstancesData()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
