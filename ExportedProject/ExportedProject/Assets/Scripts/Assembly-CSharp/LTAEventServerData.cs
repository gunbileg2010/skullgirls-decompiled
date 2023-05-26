using System.Collections.Generic;

public class LTAEventServerData : EventServerData
{
	public string actGuid;

	protected int playCount;

	protected bool wasEverFullyCompleted;

	public LTAEventServerData(Dictionary<string, object> dataDict)
	{
	}

	public override void ParseData(Dictionary<string, object> dataDict)
	{
	}

	public Act GetActForEvent()
	{
		return null;
	}

	public int GetPlayCount()
	{
		return 0;
	}

	public void IncrementPlayCount()
	{
	}

	public bool GetWasEverFullyCompleted()
	{
		return false;
	}
}
