using System.Collections.Generic;

public class FightInstanceServerData
{
	public int difficulty;

	public int defenseBonusCount;

	private string backendId;

	private string opponentId;

	private string enemyName;

	private bool isEnemyDeveloper;

	private List<Character> enemyCharacters;

	private float enemyFighterFSMultiplierAddition;

	public FightInstanceServerData()
	{
	}

	public FightInstanceServerData(string opponentId, string opponentName, bool isOpponentDeveloper)
	{
	}

	public FightInstanceServerData(Dictionary<string, object> dataDict)
	{
	}

	public void FromDictionary(Dictionary<string, object> dataDict)
	{
	}

	public string GetId()
	{
		return null;
	}

	public bool IsSeedOpponent()
	{
		return false;
	}

	public string GetOpponentName()
	{
		return null;
	}

	public bool IsOpponentDeveloper()
	{
		return false;
	}

	public List<Character> GetEnemyCharacters()
	{
		return null;
	}

	public void SetEnemyFSMultiplierAddition(float value)
	{
	}
}
