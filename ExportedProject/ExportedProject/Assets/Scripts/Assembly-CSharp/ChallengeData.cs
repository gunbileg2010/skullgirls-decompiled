using System.Collections.Generic;
using UnityEngine;

public class ChallengeData : GuidScriptableObject, IServerUploadable
{
	[SerializeField]
	protected string description;

	[SerializeField]
	private string lockedCriteriaDescription;

	[SerializeField]
	private ChallengeRedirectDestination challengeRedirectDestination;

	public int target;

	[SerializeField]
	private int egretPointReward;

	public virtual string GetDescription(Challenge challenge)
	{
		return null;
	}

	public string GetLockedCriteriaDescription()
	{
		return null;
	}

	public virtual ChallengeType GetChallengeType()
	{
		return default(ChallengeType);
	}

	public ChallengeRedirectDestination GetChallengeRedirectDestination()
	{
		return default(ChallengeRedirectDestination);
	}

	public int GetEgretPointReward()
	{
		return 0;
	}

	public virtual Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
