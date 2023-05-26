using System;
using System.Collections.Generic;

public class RerollGearStatsRequest : NetworkRequest
{
	private string backendId;

	private List<StatServerData> newStats;

	public RerollGearStatsRequest(Gear specialMove)
	{
	}

	public override void Send(Action callback)
	{
	}

	public List<StatServerData> GetNewStats()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
