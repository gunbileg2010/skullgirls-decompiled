using System;
using System.Collections.Generic;
using UnityEngine;

public class LootTable : ScriptableObject, IServerUploadable
{
	[Serializable]
	public class WeightedLoot
	{
		public Loot loot;

		public int weight;

		public static void RandomSelect(IList<WeightedLoot> weightedLoots, Price inPrice, out Loot loot, out Price outPrice)
		{
			loot = null;
			outPrice = null;
		}

		public static Loot RandomSelect(IList<WeightedLoot> weightedLoots)
		{
			return null;
		}

		private static WeightedLoot IntenralRandomSelect(IList<WeightedLoot> weightedLoots)
		{
			return null;
		}
	}

	[SerializeField]
	private WeightedLoot[] loots;

	[SerializeField]
	private Price price;

	public Loot GetLoot()
	{
		return null;
	}

	public void GetPricedLoot(Price inPrice, out Loot loot, out Price outPrice)
	{
		loot = null;
		outPrice = null;
	}

	public List<Loot> GetAllPossibleLoot()
	{
		return null;
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public Dictionary<string, object> GetServerUploadData(Price parentPrice)
	{
		return null;
	}

	public void ParseFromServerData(Dictionary<string, object> lootTableDict)
	{
	}

	public static List<WeightedLoot> ParseWeightedLootsListFromServerLootTable(Dictionary<string, object> lootTableDict)
	{
		return null;
	}
}
