using System;
using System.Collections.Generic;

public class FightHistoryServerData
{
	private string attackingPlayerName;

	private string defendingPlayerName;

	private XsProfile attackingPlayerProfile;

	private List<XsCharacter> attackingCharacters;

	private List<XsCharacter> defendingCharacters;

	private long pointsEarned;

	private bool wonFight;

	private bool attackerIsDeveloper;

	private bool defenderIsDeveloper;

	private DateTime timestampDateTime;

	public FightHistoryServerData()
	{
	}

	public FightHistoryServerData(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}

	public void CopyInDefendersFromRiftBattleNodeSnapshop(RiftBattleMapNodeServerData nodeServerData)
	{
	}

	public string GetAttackingPlayerName()
	{
		return null;
	}

	public string GetDefendingPlayerName()
	{
		return null;
	}

	public XsProfile GetAttackingPlayerProfile()
	{
		return null;
	}

	public List<XsCharacter> GetAttackingCharacters()
	{
		return null;
	}

	public List<XsCharacter> GetDefendingCharacters()
	{
		return null;
	}

	public long GetPointsEarned()
	{
		return 0L;
	}

	public bool DidWinFight()
	{
		return false;
	}

	public bool wasAttackerDeveloper()
	{
		return false;
	}

	public bool wasDefenderDeveloper()
	{
		return false;
	}

	public DateTime GetTimestampDateTime()
	{
		return default(DateTime);
	}
}
