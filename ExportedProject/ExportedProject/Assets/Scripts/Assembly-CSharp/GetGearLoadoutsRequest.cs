using System;
using System.Collections.Generic;

public class GetGearLoadoutsRequest : NetworkRequest
{
	private string characterGuid;

	private List<GearLoadoutServerData> gearLoadouts;

	public GetGearLoadoutsRequest(string characterGuid)
	{
	}

	public override void Send(Action callback)
	{
	}

	public List<GearLoadoutServerData> GetGearLoadouts()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
