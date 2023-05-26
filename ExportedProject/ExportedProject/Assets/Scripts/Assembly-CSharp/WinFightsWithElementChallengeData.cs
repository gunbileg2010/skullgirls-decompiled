using System.Collections.Generic;

public class WinFightsWithElementChallengeData : WinFightsChallengeData
{
	public Element element;

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
