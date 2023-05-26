using System.Collections;
using UnityEngine;

public class FightResultsPopupLeaderboardPanel : FightResultsPopupPanel
{
	[SerializeField]
	private FightResultsPopup parent;

	[SerializeField]
	private GameObject scoreTallyParent;

	[SerializeField]
	private RewardScrollView nextEventRewardScrollView;

	[SerializeField]
	private GameObject nextRewardsGO;

	[SerializeField]
	private LocalizedUGUIText streakAmountText;

	[SerializeField]
	private LocalizedUGUIText multiplierAmountText;

	[SerializeField]
	private LocalizedUGUIText scoreEarnedText;

	[SerializeField]
	private LocalizedUGUIText scoreText;

	[SerializeField]
	private LocalizedUGUIText previousGoalScoreText;

	[SerializeField]
	private LocalizedUGUIText nextGoalScoreText;

	[SerializeField]
	private RectTransform rewardProgressBar;

	[SerializeField]
	private GachaShardProgressUI silverGachaShardProgress;

	[SerializeField]
	private GachaShardProgressUI goldGachaShardProgress;

	[SerializeField]
	private GachaShardProgressUI diamondGachaShardProgress;

	[SerializeField]
	private FightResultsPopupRewardPanel rewardsPanel;

	[SerializeField]
	private LocalizedUGUIText socialGiftCapMessageText;

	private bool readyToContinue;

	private GachaShardProgressUI gachaShardProgressUI;

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
}
