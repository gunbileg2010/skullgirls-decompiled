using System.Collections.Generic;
using UnityEngine;

public class AdReward : GuidScriptableObject, IServerUploadable
{
	[SerializeField]
	private GachaData.WeightedLootTableSet perVideoViewLootTable;

	[SerializeField]
	private int rollsPerAdReward;

	public List<Loot> GetLoots()
	{
		return null;
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
