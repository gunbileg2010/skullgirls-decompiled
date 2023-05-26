using System.Collections;
using UnityEngine;

public class FightResultsPopupSyncPvpPanel : FightResultsPopupPanel
{
	[SerializeField]
	private FightResultsPopup parent;

	[SerializeField]
	private PlayerSummary playerSummary;

	[SerializeField]
	private LocalizedUGUIText playerRematchStatus;

	[SerializeField]
	private PlayerSummary opponentSummary;

	[SerializeField]
	private LocalizedUGUIText opponentRematchStatus;

	[SerializeField]
	private GameObject replayButtonGlow;

	[SerializeField]
	private AnimDrivenTallyText playerTeamHealthDisplay;

	[SerializeField]
	private AnimDrivenTallyText opponentTeamHealthDisplay;

	[SerializeField]
	private float healthTallyLengthSeconds;

	private bool readyToContinue;

	private bool wantRematch;

	private bool opponentWantsRematch;

	private AdvancedButton replayButton;

	public override bool NeedsToDisplay(bool playerWon, Team playerTeam, Team enemyTeam, FightResultServerData fightResultData, bool isTutorial = false)
	{
		return false;
	}

	public override IEnumerator ShowResultsSequence(bool playerWon, Team playerTeam, Team enemyTeam, FightResultServerData fightResultData, bool isTutorial = false)
	{
		return null;
	}

	public override void UGUI_Continue()
	{
	}

	public override void UGUI_Quit()
	{
	}

	public override void UGUI_Retry()
	{
	}

	public override void Cleanup()
	{
	}

	private void OnOpponentDisconnected()
	{
	}

	private void OnOpponentWantsRematch(bool rematch, bool startRematch)
	{
	}

	private void ShowHideReplayButtonGlow(bool show)
	{
	}
}
