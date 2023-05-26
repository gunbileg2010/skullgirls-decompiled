using System;
using System.Collections.Generic;
using UnityEngine;

public class StatTable : ScriptableObject, IServerUploadable
{
	[Serializable]
	public class WeightedStat
	{
		public StatData stat;

		public int weight;

		public static StatData RandomSelect(List<WeightedStat> weightedStats)
		{
			return null;
		}
	}

	[SerializeField]
	private List<WeightedStat> stats;

	public StatData RollStat()
	{
		return null;
	}

	public List<StatData> GetAllPossibleStats()
	{
		return null;
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
