using System;
using System.Collections.Generic;

public class ClaimAdRewardsRequest : NetworkRequest
{
	private int adPacingDurationMinutes;

	private List<Reward> rewards;

	public override void Send(Action callback)
	{
	}

	public List<Reward> GetRewards()
	{
		return null;
	}

	public int GetLatestPacingDurationMinutes()
	{
		return 0;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
