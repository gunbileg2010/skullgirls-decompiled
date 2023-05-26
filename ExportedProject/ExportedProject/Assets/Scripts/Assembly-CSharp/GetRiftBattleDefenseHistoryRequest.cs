using System;
using System.Collections.Generic;

public class GetRiftBattleDefenseHistoryRequest : NetworkRequest
{
	private string eventInstanceId;

	private List<BattleInstanceServerData> battleInstances;

	public GetRiftBattleDefenseHistoryRequest(string eventInstanceId)
	{
	}

	public override void Send(Action callback)
	{
	}

	public List<BattleInstanceServerData> GetBattleInstances()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
