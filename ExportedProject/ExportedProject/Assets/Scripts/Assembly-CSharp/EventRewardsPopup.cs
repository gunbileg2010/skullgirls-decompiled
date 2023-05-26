using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventRewardsPopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private EventRewardItemView itemPrototype;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private ContextualPopupItem contextualPopupPrefab;

	[SerializeField]
	private GameObject scoreRewardsOn;

	[SerializeField]
	private GameObject endOfEventRewardsOn;

	[SerializeField]
	private GameObject footerHint;

	[SerializeField]
	private LocalizedUGUIText minScoreText;

	[SerializeField]
	private ToggleGroup toggleGroup;

	[SerializeField]
	private Toggle defaultToggle;

	[SerializeField]
	private Color requiredBattlesNumberColor;

	[SerializeField]
	private Color battlesDoneNotEnoughColor;

	[SerializeField]
	private Color battlesDoneEnoughColor;

	[SerializeField]
	private LocalizedUGUIText seasonEndLabel;

	[SerializeField]
	private TimerUI seasonEndTimer;

	[SerializeField]
	private LocalizedUGUIText riftBattleFooterText;

	[SerializeField]
	private int layoutRewardsRibbonDisabledHeight;

	protected int itemCounter;

	protected List<EventRewardItemView> items;

	private ContextualPopupItem contextualPopup;

	private EventData eventData;

	private EventServerData eventServerData;

	private bool showImmediateRewards;

	private long currentScore;

	protected override void Awake()
	{
	}

	public void UGUI_ScoreRewardTabToggle(bool show)
	{
	}

	public void UGUI_EndOfEventTabToggle(bool show)
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private void PopulateLeaderboardMilestoneRewards()
	{
	}

	private void PopulateRiftBattleSingleBattleRewards()
	{
	}

	private void PopulateLeaderboardEndOfEventRewards()
	{
	}

	private void PopulateRiftBattleEndOfSeasonRewards()
	{
	}

	private void DestroyItems()
	{
	}

	private void ClearItems()
	{
	}

	private void ResetToggles()
	{
	}

	private EventRewardItemView GetItem()
	{
		return null;
	}

	private void UpdateRiftBattleSeasonEndUI()
	{
	}
}
