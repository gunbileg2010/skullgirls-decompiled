using System.Collections.Generic;
using UnityEngine;

public class InflictModifierChallengeData : ChallengeData
{
	[SerializeField]
	private ModifierType modifierType;

	public override Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public override ChallengeType GetChallengeType()
	{
		return default(ChallengeType);
	}
}
