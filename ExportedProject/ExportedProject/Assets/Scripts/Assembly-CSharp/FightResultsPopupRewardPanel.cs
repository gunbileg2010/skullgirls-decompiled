using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightResultsPopupRewardPanel : FightResultsPopupPanel
{
	[SerializeField]
	private FightResultsPopup parent;

	[SerializeField]
	private AnimationHelper scaleInAnim;

	[SerializeField]
	private LocalizedUGUIText rewardTypeText;

	[SerializeField]
	private RewardScrollView rewardScrollView;

	[SerializeField]
	private LocalizedUGUIText socialGiftCapMessageText;

	private bool readyToContinue;

	public IEnumerator ShowResultsForSetLootList(RewardOrigin origin, List<Loot> loots = null)
	{
		return null;
	}

	public IEnumerator ShowResultsForSetRewardList(RewardOrigin origin, List<Reward> rewards = null)
	{
		return null;
	}

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

	private IEnumerator InternalShowResultsForSetRewardList(RewardOrigin origin, List<Reward> rewards = null)
	{
		return null;
	}
}
