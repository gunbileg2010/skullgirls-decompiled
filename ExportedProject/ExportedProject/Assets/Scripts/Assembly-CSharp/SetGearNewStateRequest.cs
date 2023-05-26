using System;
using System.Collections.Generic;

public class SetGearNewStateRequest : NetworkRequest
{
	private List<string> backendIds;

	private bool isNew;

	public SetGearNewStateRequest(List<Gear> gearList, bool isNew)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
