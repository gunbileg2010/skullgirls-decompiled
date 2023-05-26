using System;

[Serializable]
public class Stat
{
	public int level;

	public StatData data;

	public Stat(StatData statData, int inLevel = 1)
	{
	}

	public Stat(StatServerData serverData)
	{
	}

	public Stat(IDataReader reader)
	{
	}

	public void Apply(CharacterStats stats)
	{
	}

	public void UpdateFromStatServerData(StatServerData serverData)
	{
	}

	public void ReplaceStatData(string guid)
	{
	}

	public Fixed GetValue()
	{
		return default(Fixed);
	}

	public void Serialize(IDataWriter writer)
	{
	}
}
