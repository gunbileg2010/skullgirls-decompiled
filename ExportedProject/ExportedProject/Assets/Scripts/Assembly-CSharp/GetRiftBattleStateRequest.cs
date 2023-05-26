using System;

public class GetRiftBattleStateRequest : NetworkRequest
{
	private string eventInstanceId;

	private RiftBattleStateServerData battleState;

	public GetRiftBattleStateRequest(string eventInstanceId)
	{
	}

	public override void Send(Action callback)
	{
	}

	public RiftBattleStateServerData GetBattleState()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
