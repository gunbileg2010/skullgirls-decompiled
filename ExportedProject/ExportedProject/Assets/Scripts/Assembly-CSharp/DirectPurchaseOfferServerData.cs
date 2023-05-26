using System;
using System.Collections.Generic;

[Serializable]
public class DirectPurchaseOfferServerData
{
	public List<Reward> rewards;

	public bool purchased;

	public long itemId;

	public List<Stat> gearStats;

	private List<Loot> claimableRewards;

	public DirectPurchaseOfferServerData()
	{
	}

	public DirectPurchaseOfferServerData(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}

	public Reward GetKeyReward()
	{
		return null;
	}
}
