using System;
using System.Collections.Generic;

[Serializable]
public class DirectPurchaseStoreServerData
{
	public Dictionary<string, List<DirectPurchaseOfferServerData>> offers;

	public DateTime refreshTime;

	public List<DirectPurchaseTabInfo> tabsToShow;

	public DirectPurchaseStoreServerData()
	{
	}

	public DirectPurchaseStoreServerData(Dictionary<string, object> dataDict)
	{
	}

	public void ParseData(Dictionary<string, object> dataDict)
	{
	}
}
