using System.Collections.Generic;

public class ExecuteJuggleChallengeData : ChallengeData
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
