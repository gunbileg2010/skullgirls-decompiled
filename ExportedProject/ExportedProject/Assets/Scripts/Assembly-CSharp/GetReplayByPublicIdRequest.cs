using System;

public class GetReplayByPublicIdRequest : NetworkRequest
{
	public FightReplayServerData replayData;

	private string idToUse;

	public GetReplayByPublicIdRequest(string id)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
