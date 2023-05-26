using System.Collections.Generic;

public class WinFightsWithCharacterTypeChallengeData : WinFightsChallengeData
{
	public List<BaseCharacterData> characters;

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
