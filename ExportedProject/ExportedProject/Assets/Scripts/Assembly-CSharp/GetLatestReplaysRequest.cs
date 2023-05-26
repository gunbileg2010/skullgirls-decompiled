using System;
using System.Collections.Generic;

public class GetLatestReplaysRequest : NetworkRequest
{
	public string idToUse;

	public List<FightReplayServerData> replayDatas;

	public GetLatestReplaysRequest(string idToUse = null)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
