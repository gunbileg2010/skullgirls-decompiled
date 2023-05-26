using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EventReward
{
	public enum EventRewardType
	{
		Rank = 0,
		Score = 1,
		Percentile = 2
	}

	[HideInInspector]
	public EventRewardType rewardType;

	[HideInInspector]
	public bool isImmediate;

	public long value;

	public List<Loot> loots;

	public EventReward()
	{
	}

	public EventReward(Dictionary<string, object> dataDict)
	{
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
