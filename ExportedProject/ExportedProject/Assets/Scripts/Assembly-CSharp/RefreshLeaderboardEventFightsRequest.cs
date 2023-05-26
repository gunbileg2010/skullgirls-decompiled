using System;
using System.Collections.Generic;

public class RefreshLeaderboardEventFightsRequest : NetworkRequest
{
	private string eventId;

	private List<FightInstanceServerData> fightInstanceServerDatas;

	public RefreshLeaderboardEventFightsRequest()
	{
	}

	public RefreshLeaderboardEventFightsRequest(string eventId)
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
