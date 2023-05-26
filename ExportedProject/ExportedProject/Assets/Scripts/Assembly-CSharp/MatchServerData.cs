using System.Collections.Generic;

public class MatchServerData
{
	public string guid;

	public bool isFinal;

	public FightServerData fightData;

	public const int kMatchChallengesPerMatch = 3;

	private bool isCompleted;

	private byte matchChallengesProgress;

	public MatchServerData(Dictionary<string, object> dataDict)
	{
	}

	public void FromDictionary(Dictionary<string, object> dataDict)
	{
	}

	public void SetCompleted(bool completed)
	{
	}

	public bool IsCompleted()
	{
		return false;
	}

	public byte GetMatchChallengesProgress()
	{
		return 0;
	}

	public void AddMatchChallengesProgress(byte progress)
	{
	}

	public bool IsMatchChallengeComplete(int challengeIndex)
	{
		return false;
	}

	public int GetNumCompletedMatchChallenges()
	{
		return 0;
	}
}
