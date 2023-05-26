using System;
using System.Collections.Generic;

public class GetActsProgressRequest : NetworkRequest
{
	private List<string> actGuids;

	private List<string> eventInstanceIds;

	private List<ActServerData> actDatas;

	public GetActsProgressRequest(List<string> actGuids, List<string> eventInstanceIds = null)
	{
	}

	public override void Send(Action callback)
	{
	}

	public List<ActServerData> GetActDatas()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
