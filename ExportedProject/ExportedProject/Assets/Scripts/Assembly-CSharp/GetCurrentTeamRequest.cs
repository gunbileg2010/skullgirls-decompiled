using System;
using System.Collections.Generic;

public class GetCurrentTeamRequest : NetworkRequest
{
	private List<string> teamMemberIds;

	public override void Send(Action callback)
	{
	}

	public List<string> GetTeamMemberIds()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
