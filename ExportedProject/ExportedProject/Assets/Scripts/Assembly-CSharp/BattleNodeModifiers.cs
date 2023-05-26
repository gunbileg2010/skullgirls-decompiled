using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BattleNodeModifiers
{
	[SerializeField]
	public List<DynamicResource> enemyFightModifiers;

	[SerializeField]
	public List<DynamicResource> playerFightModifiers;

	public float enemyFighterFSMultiplierAddition;

	public BattleNodeModifiers(Dictionary<string, object> data)
	{
	}

	public void ParseData(Dictionary<string, object> data)
	{
	}

	public Dictionary<string, object> ToDictionary()
	{
		return null;
	}
}
