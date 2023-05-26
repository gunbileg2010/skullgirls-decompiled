using System.Collections.Generic;

public class ChapterServerData
{
	public string guid;

	public List<MatchServerData> matches;

	public ChapterServerData(Dictionary<string, object> dataDict)
	{
	}

	public void FromDictionary(Dictionary<string, object> dataDict)
	{
	}

	public bool IsCompleted()
	{
		return false;
	}

	public bool IsFullyCompleted()
	{
		return false;
	}

	public float GetCompletionRatio()
	{
		return 0f;
	}

	public void ResetCompletion()
	{
	}

	public MatchServerData GetMatchServerData(string matchGuid)
	{
		return null;
	}
}
