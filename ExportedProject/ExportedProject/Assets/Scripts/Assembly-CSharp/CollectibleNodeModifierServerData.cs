using System.Collections.Generic;

public class CollectibleNodeModifierServerData
{
	public string backendId;

	public bool isLocked;

	public bool isNew;

	public string guid;

	public bool inUse;

	public int level;

	public int softCurrencyValue;

	public string characterGuid;

	public Element element;

	public CollectibleNodeModifierServerData(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}
}
