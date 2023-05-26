using System.Collections.Generic;

public class GearServerData
{
	public string backendId;

	public string guid;

	public int evolution;

	public List<StatServerData> statServerDatas;

	public int softCurrencyValue;

	public bool isLocked;

	public bool isNew;

	public RerolledMoveStat rerolledMoveStat;

	public GearServerData(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}
}
