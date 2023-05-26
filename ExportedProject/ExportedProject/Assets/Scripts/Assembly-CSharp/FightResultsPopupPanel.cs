using System.Collections;
using UnityEngine;

public abstract class FightResultsPopupPanel : MonoBehaviour
{
	public abstract IEnumerator ShowResultsSequence(bool playerWon, Team playerTeam, Team enemyTeam, FightResultServerData fightResultData, bool isTutorial = false);

	public abstract bool NeedsToDisplay(bool playerWon, Team playerTeam, Team enemyTeam, FightResultServerData fightResultData, bool isTutorial = false);

	public abstract void UGUI_Continue();

	public abstract void UGUI_Retry();

	public abstract void UGUI_Quit();

	public abstract void Cleanup();
}
