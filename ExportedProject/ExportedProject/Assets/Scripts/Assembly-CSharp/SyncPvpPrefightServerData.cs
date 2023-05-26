using System.Collections.Generic;

public class SyncPvpPrefightServerData
{
	public struct CompetitiveFighterDataUpdate
	{
		public string guid;

		public List<int> baseAttack;

		public List<int> baseLifebar;

		public void ParseData(Dictionary<string, object> dataDict)
		{
		}
	}

	public List<string> bannedVariantGuids;

	public List<string> bannedMoveGuids;

	public List<CompetitiveFighterDataUpdate> competitiveFighterStatData;

	public Fixed competitiveSuperDamageMult;

	public Fixed competiveSpecialDamageMult;

	public Fixed competitiveSekhmetDamageMult;

	public bool HasBannedFighterVariantGuids()
	{
		return false;
	}

	public List<string> GetBannedFighterVariantGuids()
	{
		return null;
	}

	public bool HasBannedMoveGuids()
	{
		return false;
	}

	public List<string> GetBannedMoveGuids()
	{
		return null;
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}
}
