using System;
using System.Collections.Generic;

[Serializable]
public class DirectPurchaseUploadTabInfo : DirectPurchaseTabInfo
{
	public LootTable lootTable;

	public int lootCount;

	public override Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
