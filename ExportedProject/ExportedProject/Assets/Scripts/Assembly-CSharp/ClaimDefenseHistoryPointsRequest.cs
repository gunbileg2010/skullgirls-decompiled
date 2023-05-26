using System;

public class ClaimDefenseHistoryPointsRequest : NetworkRequest
{
	private string eventInstanceId;

	private ClaimPointsResultServerData claimPointsResultServerData;

	public ClaimDefenseHistoryPointsRequest(string eventInstanceId)
	{
	}

	public override void Send(Action callback)
	{
	}

	public ClaimPointsResultServerData GetClaimPointsResults()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
