using System;
using System.Collections.Generic;

public class GetAvailableCampaignActsRequest : NetworkRequest
{
	private List<string> actGuids;

	public override void Send(Action callback)
	{
	}

	public List<string> GetActGuids()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
