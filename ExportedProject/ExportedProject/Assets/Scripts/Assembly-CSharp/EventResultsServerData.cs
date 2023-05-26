using System.Collections.Generic;

public class EventResultsServerData
{
	private string id;

	private int score;

	private int winStreak;

	private int restorableStreak;

	protected List<FightHistoryServerData> defenseHistory;

	private Dictionary<string, int> scoreBreakdown;

	public EventResultsServerData(HttpResponse response)
	{
	}

	public EventResultsServerData(Dictionary<string, object> data)
	{
	}

	public string GetId()
	{
		return null;
	}

	public int GetScore()
	{
		return 0;
	}

	public int GetWinStreak()
	{
		return 0;
	}

	public int GetRestorableStreak()
	{
		return 0;
	}

	public List<FightHistoryServerData> GetDefenseHistory()
	{
		return null;
	}

	public Dictionary<string, int> GetScoreBreakdown()
	{
		return null;
	}

	private void Populate(Dictionary<string, object> data)
	{
	}
}
