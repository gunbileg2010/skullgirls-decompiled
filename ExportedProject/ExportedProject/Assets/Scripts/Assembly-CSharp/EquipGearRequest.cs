using System;
using System.Collections.Generic;

public class EquipGearRequest : NetworkRequest
{
	private string characterId;

	private string[] gearGuids;

	private bool isCompetitive;

	public EquipGearRequest(Character character, List<Gear> items, bool isCompetitive = false)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}

	private bool AlreadyEquiped(string[] gearGuids, string guid)
	{
		return false;
	}
}
