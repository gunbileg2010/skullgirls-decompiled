using System.Collections.Generic;

public class WinFightsAtFSDisadvantageChallengeData : WinFightsChallengeData
{
	public float multiplier;

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
