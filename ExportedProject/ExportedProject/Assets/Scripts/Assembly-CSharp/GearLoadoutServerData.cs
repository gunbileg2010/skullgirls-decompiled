using System.Collections.Generic;

public class GearLoadoutServerData
{
	public string backendId;

	public string characterGuid;

	public List<string> moveIds;

	public GearLoadoutServerData(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}
}
