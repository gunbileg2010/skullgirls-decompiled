using System;
using System.Collections.Generic;

public class BattleInstanceServerData
{
	public string backendId;

	public string eventInstanceId;

	public string userId;

	public int cachedUserRating;

	public int cachedUserWinStreak;

	public XsProfile playerInfo;

	public XsProfile opponentInfo;

	public BattleInstanceStatus status;

	public BattleMapServerData mapSnapshot;

	public int ratingChangeWin;

	public int ratingChangeLoss;

	public int ratingChangeWinMissingAmount;

	public bool hasAttackerDiversity;

	public bool battleWasAutoCompleted;

	public Dictionary<int, MapNodeProgressServerData> progress;

	public Dictionary<int, List<FightHistoryServerData>> fightHistories;

	public short lastNodeMapIndex;

	public Dictionary<string, int> usedCharactersMap;

	public HashSet<string> usedVariants;

	private int outcome;

	public DateTime endTime;

	public string revengeBattleId;

	public bool isRevengeBattle;

	public bool revengeBattleFought;

	public long revengeScoreToBeat;

	public BattleInstanceServerData(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}

	public bool WasVariantUsed(string characterVariantGuid)
	{
		return false;
	}

	public bool CanCharacterBeUsed(Character character)
	{
		return false;
	}

	public int GetCharacterUseCount(Character character)
	{
		return 0;
	}

	public void IncrementCharacterUse(Character character)
	{
	}

	public void MarkCharactersAsUsed(Fight fight, Action callback)
	{
	}

	public bool DidPlayerWin()
	{
		return false;
	}

	public int GetUserRatingAdjustment(bool playerWon)
	{
		return 0;
	}

	public int GetOpponentRatingAdjustment()
	{
		return 0;
	}

	public long GetUserScore()
	{
		return 0L;
	}

	public int GetLossCount()
	{
		return 0;
	}
}
