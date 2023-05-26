using System;
using System.Collections.Generic;

public class SyncPvpPrefightCheckRequest : NetworkRequest
{
	public SyncPvpPrefightServerData data;

	private bool isCompetitive;

	public SyncPvpPrefightCheckRequest(bool isCompetitive = false)
	{
	}

	public override void Send(Action callback)
	{
	}

	public bool HasBannedGuids()
	{
		return false;
	}

	public List<string> GetBannedGuids()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
