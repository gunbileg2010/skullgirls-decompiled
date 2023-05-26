using System;
using System.Collections.Generic;

public class GetGlobalSettingsRequest : NetworkRequest
{
	private Dictionary<string, object> settingsData;

	public override void Send(Action callback)
	{
	}

	public Dictionary<string, object> GetData()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
