using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderboardLobbyScreen : MonoBehaviour
{
	[SerializeField]
	private Transform constraintsTransform;

	[SerializeField]
	private FightConstraintUI constraintIconPrefab;

	[SerializeField]
	private ContextualPopupItem contextualPopupItemPrefab;

	[SerializeField]
	private MatchModifierUI matchModifierUI;

	[SerializeField]
	private GameObject winStreakModifiersActiveGO;

	[SerializeField]
	private LocalizedUGUIText streakText;

	[SerializeField]
	private LocalizedUGUIText multiplierText;

	[SerializeField]
	private LocalizedUGUIText scoreText;

	[SerializeField]
	private LocalizedUGUIText nextRewardText;

	[SerializeField]
	private LeaderboardEventTeamView playerDefenseTeamView;

	[SerializeField]
	private Badge defenseHistoryBadge;

	[SerializeField]
	private RectTransform enemyTeamsMarker;

	[SerializeField]
	private LeaderboardEventTeamView enemyTeamViewPrefab;

	[SerializeField]
	private PopupData eventRewardsPopupData;

	[SerializeField]
	private MasterPopupData refreshFightsPopupData;

	[SerializeField]
	private LeaderboardLobbyDebugPopup leaderboardDebugPopup;

	private const int kTopBarConfiguration = 1048588;

	private List<FightInstanceServerData> fightInstances;

	private List<LeaderboardEventTeamView> enemyTeamViews;

	private SGMatch match;

	private List<FightConstraintUI> fightConstraintIcons;

	private ContextualPopupItem contextualPopup;

	private LeaderboardEventData eventData;

	private EventServerData serverEventData;

	private LeaderboardEventTeamView selectedTeamView;

	private GameSettings.WinStreakModifierLeaderboards winStreakMod;

	private bool arebuttonsInteractable;

	private void Awake()
	{
	}

	public void UGUI_ContinueButtonPressed()
	{
	}

	public void UGUI_ShowFightModifiers()
	{
	}

	public void UGUI_ShowRewards()
	{
	}

	public void UGUI_SetDefense()
	{
	}

	public void UGUI_RefreshTeamsPressed()
	{
	}

	public void UGUI_DEBUG_ShowLeaderboardDebugPopup()
	{
	}

	private IEnumerator OnStateEntered(IGameState prevState, object context)
	{
		return null;
	}

	private IEnumerator OnStateExited(IGameState nextState)
	{
		return null;
	}

	private void SetupEnemyTeams()
	{
	}

	private void SetupFightConstraints(Action callback = null)
	{
	}

	private void Cleanup()
	{
	}

	private void TeamViewPressed(LeaderboardEventTeamView pressedTeamView)
	{
	}

	private void DefenseTeamMeetsRequirement(List<string> defenseTeamIds, Action<bool> callback)
	{
	}

	private void ShowFightRefreshPopup()
	{
	}

	private void ShowRestorePopup()
	{
	}

	private void ResetToDefaultTopBarConfig()
	{
	}

	private void OnStreakSet(List<FightInstanceServerData> newFightInstances, int newStreak)
	{
	}
}
