using System.Collections.Generic;
using UnityEngine;

public class SyncPvpEventData : EventData
{
	[SerializeField]
	private char lobbyIdChar;

	[SerializeField]
	private GameContentDisplayData actSelectContent;

	[SerializeField]
	private string rulesPopupCopy;

	[SerializeField]
	private bool shouldUseCompeititveCollection;

	[SerializeField]
	private FightRequirement fightRequirement;

	[SerializeField]
	private List<DynamicResource> enemyFightModifiers;

	[SerializeField]
	private List<DynamicResource> playerFightModifiers;

	public override EventDataType GetEventType()
	{
		return default(EventDataType);
	}

	public override GameContentDisplayData GetDisplayData()
	{
		return null;
	}

	public override GameType GetGameType()
	{
		return default(GameType);
	}

	public FightConstraint[] GetSyncPvpFightConstraints()
	{
		return null;
	}

	public List<DynamicResource> GetPlayerTeamModifiers()
	{
		return null;
	}

	public List<DynamicResource> GetEnemyTeamModifiers()
	{
		return null;
	}

	public string GetRulesPopupCopy()
	{
		return null;
	}

	public bool GetShouldUseCompetitiveCollection()
	{
		return false;
	}

	public char GetLobbyIdChar()
	{
		return '\0';
	}

	public override Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
