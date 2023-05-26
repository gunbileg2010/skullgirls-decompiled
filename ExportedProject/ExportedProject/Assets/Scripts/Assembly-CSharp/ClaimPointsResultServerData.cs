using System.Collections.Generic;

public class ClaimPointsResultServerData : FightResultServerData
{
	private List<FightHistoryServerData> claimedHistory;

	public ClaimPointsResultServerData()
	{
	}

	public ClaimPointsResultServerData(Dictionary<string, object> dataDict)
	{
	}

	public override void ParseData(Dictionary<string, object> dataDict)
	{
	}

	public List<FightHistoryServerData> GetClaimedHistory()
	{
		return null;
	}
}
