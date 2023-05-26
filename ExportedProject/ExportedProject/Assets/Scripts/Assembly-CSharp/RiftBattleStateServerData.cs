using System;
using System.Collections.Generic;

public class RiftBattleStateServerData
{
	public BattleMapServerData defenseMap;

	public Profile opponentInfo;

	private RiftBattleStateStatus status;

	private List<BattleInstanceServerData> battleInstances;

	private BattleInstanceServerData finishedRevengeBattleInstance;

	private int rating;

	private int tier;

	private int paidBattleTickets;

	private int freeBattleTickets;

	private long freeBattleTicketRefreshDate;

	private int maxFreeBattleTickets;

	private long nextOpponentRefreshDate;

	private DateTime lastTimePlayerCheckedDefenseHistory;

	private int battleHistoryBadgingNumber;

	private List<BattleNodeModifiers> riftNodeConfiguration;

	public RiftBattleStateServerData(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}

	public RiftBattleStateStatus GetStatus()
	{
		return default(RiftBattleStateStatus);
	}

	public int GetUserRating()
	{
		return 0;
	}

	public void SetUserRating(int rating)
	{
	}

	public RiftTier GetUserTier()
	{
		return default(RiftTier);
	}

	public BattleInstanceServerData GetBattleInstance(int index = 0)
	{
		return null;
	}

	public BattleInstanceServerData GetFirstFinishedBattleInstance()
	{
		return null;
	}

	public Dictionary<int, MapNodeProgressServerData> GetUserProgress()
	{
		return null;
	}

	public Dictionary<int, List<FightHistoryServerData>> GetUserFightHistory()
	{
		return null;
	}

	public int GetBattleTicketCount(CurrencyTier tier)
	{
		return 0;
	}

	public long GetFreeBattleTicketRefreshDate()
	{
		return 0L;
	}

	public long GetFreeOpponentRefreshDate()
	{
		return 0L;
	}

	public BattleNodeModifiers GetRiftBattleNodeConfiguration(int index)
	{
		return null;
	}

	public int GetDefeneseHistoryBadgingNumber()
	{
		return 0;
	}

	public void ResetDefenseHistoryBadgingNumber()
	{
	}

	public DateTime GetLastTimePlayerCheckedDefenseHistory()
	{
		return default(DateTime);
	}

	public void UpdateLastTimePlayerCheckedDefenseHistory()
	{
	}
}
