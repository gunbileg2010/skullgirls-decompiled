using System;
using System.Collections.Generic;

public class SaveGearLoadoutRequest : NetworkRequest
{
	private string characterGuid;

	private string loadoutId;

	private List<string> backendIds;

	private GearLoadoutServerData gearLoadoutServerData;

	public SaveGearLoadoutRequest(string characterGuid, string loadoutId, List<Gear> gearList)
	{
	}

	public override void Send(Action callback)
	{
	}

	public GearLoadoutServerData GetGearLoadoutServerData()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
