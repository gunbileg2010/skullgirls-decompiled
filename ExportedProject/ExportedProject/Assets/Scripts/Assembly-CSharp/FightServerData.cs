using System.Collections.Generic;

public class FightServerData
{
	private List<XsCharacter> basicEnemies;

	public FightServerData()
	{
	}

	public FightServerData(Dictionary<string, object> dataDict)
	{
	}

	public void FromDictionary(Dictionary<string, object> dataDict)
	{
	}

	public int GetEnemyCharacterCount()
	{
		return 0;
	}

	public List<XsCharacter> GetBasicEnemies()
	{
		return null;
	}

	public XsCharacter GetEnemyCharacter(int index)
	{
		return null;
	}

	public bool IsAnyEnemyRandomized()
	{
		return false;
	}

	public int GetTotalFighterScore()
	{
		return 0;
	}
}
