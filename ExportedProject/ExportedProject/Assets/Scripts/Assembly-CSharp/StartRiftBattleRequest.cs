using System;

public class StartRiftBattleRequest : NetworkRequest
{
	private string eventInstanceId;

	private string battleInstanceId;

	private bool usePaidTicket;

	private RiftBattleStateServerData battleState;

	public StartRiftBattleRequest(string eventInstanceId, string battleInstanceId, bool usePaidTicket)
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
