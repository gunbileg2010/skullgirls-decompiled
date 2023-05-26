using System;
using System.Collections.Generic;

public class SetConsumableNewStateRequest : NetworkRequest
{
	private List<string> consumableGuids;

	private bool isNew;

	public SetConsumableNewStateRequest(List<string> consumableGuids, bool isNew)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
