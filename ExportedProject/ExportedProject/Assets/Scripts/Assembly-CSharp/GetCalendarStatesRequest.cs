using System;
using System.Collections.Generic;

public class GetCalendarStatesRequest : NetworkRequest
{
	private RewardCalendarStatesServerData states;

	public override void Send(Action callback)
	{
	}

	public List<RewardCalendarStateServerData> GetCalendarStatesWithRewards()
	{
		return null;
	}

	public List<RewardCalendarStateServerData> GetCalendarStates()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
