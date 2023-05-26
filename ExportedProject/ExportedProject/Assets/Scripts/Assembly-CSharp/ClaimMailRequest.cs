using System;
using System.Collections.Generic;

public class ClaimMailRequest : NetworkRequest
{
	private string mailId;

	private List<Reward> rewards;

	public ClaimMailRequest(string mailId)
	{
	}

	public override void Send(Action callback)
	{
	}

	public List<Reward> GetRewards()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
