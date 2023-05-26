using System;
using System.Collections.Generic;

public class GetAvailableGachasRequest : NetworkRequest
{
	private List<GachaServerData> availableGachas;

	public override void Send(Action callback)
	{
	}

	public List<GachaServerData> GetAvailableGachas()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
