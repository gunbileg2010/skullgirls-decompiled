using System;
using System.Collections.Generic;

public class GetChallengesRequest : NetworkRequest
{
	private List<Challenge> challenges;

	private List<bool> claimedRewardThresholds;

	private DateTime expirationTime;

	private bool newChallengesAvailable;

	public override void Send(Action callback)
	{
	}

	public List<Challenge> GetChallenges()
	{
		return null;
	}

	public List<bool> GetClaimedRewardThresholds()
	{
		return null;
	}

	public DateTime GetExpirationTime()
	{
		return default(DateTime);
	}

	public bool GetNewChallengesAvailable()
	{
		return false;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
