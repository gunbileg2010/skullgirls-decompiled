using System.Collections.Generic;
using System.IO;

public class FightStats
{
	public bool wonFight;

	public bool finishedWithBlockbuster;

	public float healthRemainingPercent;

	public float secondsRemaining;

	public int maxCombo;

	public int deathCount;

	private List<MatchChallenge> matchChallenges;

	private List<int> matchChallengesProgress;

	private List<string> subscribedEvents;

	private Dictionary<CombatEvent, int> combatEvents;

	private Dictionary<Character, int> maxCombos;

	public void InitializeMatchChallenges(Fight fight)
	{
	}

	public void CleanupMatchChallenges()
	{
	}

	public void Reset()
	{
	}

	public void LogCombatEvent(CombatEvent combatEvent, int count = 1)
	{
	}

	public void LogCombo(Character character, int combo)
	{
	}

	public List<object> ToServerList()
	{
		return null;
	}

	public void SaveState(BinaryWriter writer)
	{
	}

	public void LoadState(BinaryReader reader)
	{
	}

	private void OnEventTriggered(object passed)
	{
	}
}
