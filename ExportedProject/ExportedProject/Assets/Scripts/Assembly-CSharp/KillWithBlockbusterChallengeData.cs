using System.Collections.Generic;
using UnityEngine;

public class KillWithBlockbusterChallengeData : ChallengeData
{
	[SerializeField]
	private int bbNumber;

	public override Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public override string GetDescription(Challenge challenge)
	{
		return null;
	}

	public override ChallengeType GetChallengeType()
	{
		return default(ChallengeType);
	}
}
