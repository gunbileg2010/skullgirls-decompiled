using System.Collections.Generic;

public class Challenge
{
	public ChallengeData challengeData;

	public int target;

	public int progress;

	public bool claimed;

	public int egretPointReward;

	public List<ChallengeConstraint> constraints;

	public Challenge(Dictionary<string, object> dataDict)
	{
	}

	public string GetDescription()
	{
		return null;
	}

	public string GetLockedCriteriaDescription()
	{
		return null;
	}

	public string GetChallengeGuid()
	{
		return null;
	}

	public ChallengeRedirectDestination GetRedirectDestination()
	{
		return default(ChallengeRedirectDestination);
	}

	public bool IsComplete()
	{
		return false;
	}

	public bool IsLocked()
	{
		return false;
	}

	public bool IsClaimable()
	{
		return false;
	}

	private void ParseData(Dictionary<string, object> dataDict)
	{
	}
}
