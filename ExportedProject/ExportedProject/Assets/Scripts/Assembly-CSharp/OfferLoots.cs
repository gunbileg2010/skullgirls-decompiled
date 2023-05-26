using System;
using System.Collections.Generic;

[Serializable]
public class OfferLoots
{
	public List<Loot> paidLoots;

	public List<Loot> bonusLoots;

	public int GetLootAmount(LootType lootType)
	{
		return 0;
	}

	public virtual Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
