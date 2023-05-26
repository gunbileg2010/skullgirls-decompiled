using System.Collections;
using UnityEngine;

public class FightResultsPopupRiftBattlePanel : FightResultsPopupPanel
{
	[SerializeField]
	private FightResultsPopup parent;

	[SerializeField]
	private AnimDrivenTallyText battleScoreTally;

	[SerializeField]
	private FightResultsRiftBattleSubTally[] subTallies;

	[SerializeField]
	private Color pointColorTintInNotification;

	private bool readyToContinue;

	private const string totalScoreScoreKey = "total";

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

	public override void UGUI_Retry()
	{
	}

	public override void UGUI_Quit()
	{
	}

	public override void Cleanup()
	{
	}

	private IEnumerator PlayPhase(FightResultsRiftBattleSubTally subTally, int subTotal)
	{
		return null;
	}
}
