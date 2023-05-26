using System;
using System.Collections.Generic;

public class SetDefenseTeamRequest : NetworkRequest
{
	private string eventGuid;

	private List<string> characterIds;

	public SetDefenseTeamRequest(string eventGuid, List<string> characterIds)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
