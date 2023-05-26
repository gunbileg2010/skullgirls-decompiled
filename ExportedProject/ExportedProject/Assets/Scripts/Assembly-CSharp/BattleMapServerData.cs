using System.Collections.Generic;

public class BattleMapServerData
{
	public string userId;

	public string eventGuid;

	public Dictionary<int, RiftBattleMapNodeServerData> nodes;

	public BattleMapServerData()
	{
	}

	public BattleMapServerData(Dictionary<string, object> data)
	{
	}

	public BattleMapServerData GetCopy()
	{
		return null;
	}

	private void ParseData(Dictionary<string, object> data)
	{
	}
}
