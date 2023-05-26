using System;

public class GetBattleInstanceRequest : NetworkRequest
{
	private string eventInstanceId;

	private string battleInstanceId;

	private BattleInstanceServerData battleInstance;

	public GetBattleInstanceRequest(string eventInstanceId, string battleInstanceId)
	{
	}

	public override void Send(Action callback)
	{
	}

	public BattleInstanceServerData GetBattleInstance()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
