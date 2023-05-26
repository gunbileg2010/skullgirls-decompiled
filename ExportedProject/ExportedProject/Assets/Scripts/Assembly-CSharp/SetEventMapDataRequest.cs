using System;

public class SetEventMapDataRequest : NetworkRequest
{
	private string eventGuid;

	private BattleMapServerData mapServerData;

	public SetEventMapDataRequest(string eventGuid, BattleMapServerData mapServerData)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
