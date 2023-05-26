using System.Collections.Generic;

public class ActServerData
{
	public string guid;

	public List<ChapterServerData> chapters;

	public ActServerData(Dictionary<string, object> dataDict)
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

	public ChapterServerData GetChapterServerData(string chapterGuid)
	{
		return null;
	}
}
