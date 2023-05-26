using System;

public class ClaimChallengeRequest : NetworkRequest
{
	private string challengeGuid;

	public ClaimChallengeRequest(string challengeGuid)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
