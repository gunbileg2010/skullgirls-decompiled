using System;
using System.Collections.Generic;

[Serializable]
public class BattleNodeParams
{
	public int teamSize;

	public int collectibleNodeModifierCount;

	public bool isBossNode;

	public Dictionary<string, object> ToDictionary()
	{
		return null;
	}
}
