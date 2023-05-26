using System;
using System.Collections.Generic;

public class StartFightRequest : NetworkRequest
{
	private string fightId;

	private List<string> teamIds;

	private bool uploadReplay;

	public StartFightRequest(string fightId, List<string> teamIds)
	{
	}

	public override void Send(Action callback)
	{
	}

	public bool ShouldUseReplays()
	{
		return false;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
