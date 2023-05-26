using System;
using System.Collections.Generic;

public class ClaimChallengesRewardRequest : NetworkRequest
{
	private int thresholdIndex;

	private List<Reward> rewards;

	private bool claimAll;

	public ClaimChallengesRewardRequest(int thresholdIndex, bool claimAll = false)
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
