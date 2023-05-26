using System;
using System.Collections.Generic;
using UnityEngine;

public class LeaderboardEventTeamView : MonoBehaviour
{
	[SerializeField]
	private List<CharacterPortrait> characterPortraits;

	[SerializeField]
	private GameObject fighterScoreBackingGO;

	[SerializeField]
	private LocalizedUGUIText teamFighterScore;

	[SerializeField]
	private float selectedScale;

	[SerializeField]
	private float deselectedScale;

	[SerializeField]
	private GameObject playerNameBackingGO;

	[SerializeField]
	private PlayerNameTextUI playerNameText;

	[SerializeField]
	private GameObject pointsMultiplierGO;

	[SerializeField]
	private LocalizedUGUIText pointsMultiplier;

	private TeamType teamType;

	private Action<LeaderboardEventTeamView> pressedCallback;

	private FightInstanceServerData fightInstance;

	private bool isSelected;

	private Canvas canvas;

	private List<Character> characters;

	private ContextualPopupItem defenseBonusContextualPopup;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void PopulateFromFight(FightInstanceServerData serverFight)
	{
	}

	public void PopulateFromDefenseTeam(List<string> defenseTeamIds, Action callback = null)
	{
	}

	public void PopulateFromFightHistory(FightHistoryServerData fightHistory, TeamType teamType)
	{
	}

	public void PopulateFromFightReplay(FightReplayServerData fightReplay, TeamType teamType)
	{
	}

	public void SetClickCallback(Action<LeaderboardEventTeamView> callback)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public FightInstanceServerData GetFightInstance()
	{
		return null;
	}

	public List<Character> GetCharacters()
	{
		return null;
	}

	public void UGUI_TeamPressed()
	{
	}

	public void UGUI_DefenseBonusPressed()
	{
	}

	private void Populate(List<XsCharacter> xsCharacters, string playerName, bool isSeedTeam, bool isDeveloper)
	{
	}

	private void Populate(List<Character> characters, string playerName, bool isSeedTeam, bool isDeveloper)
	{
	}

	private float CalculateDefenderBonusMultiplier(int bonusCount)
	{
		return 0f;
	}
}
