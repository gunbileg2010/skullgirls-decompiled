using System.Collections.Generic;

public class WinFightsWithDifferentElementsChallengeData : WinFightsChallengeData
{
	public override Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public override ChallengeType GetChallengeType()
	{
		return default(ChallengeType);
	}
}
