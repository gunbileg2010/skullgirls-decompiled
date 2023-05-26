using System.Collections.Generic;
using UnityEngine;

public class StatData : GuidScriptableObject, IServerUploadable
{
	[SerializeField]
	private string description;

	[SerializeField]
	private StatType statType;

	[SerializeField]
	private List<Fixed> upgrades;

	public void Apply(CharacterStats stats, int level)
	{
	}

	public Fixed GetUpgradeValueForLevel(int level)
	{
		return default(Fixed);
	}

	public string GetDescription(int level)
	{
		return null;
	}

	public StatType GetStatType()
	{
		return default(StatType);
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public void UpdateFromServerData(Dictionary<string, object> statDict)
	{
	}

	private void ApplyStatUpgradeToStats(CharacterStats stats, Fixed upgrade)
	{
	}
}
