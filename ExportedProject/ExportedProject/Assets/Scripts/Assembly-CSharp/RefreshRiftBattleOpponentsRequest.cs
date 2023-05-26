using System;

public class RefreshRiftBattleOpponentsRequest : NetworkRequest
{
	private string eventInstanceId;

	private bool useHC;

	private RiftBattleStateServerData battleState;

	public RefreshRiftBattleOpponentsRequest(string eventInstanceId, bool useHC)
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
