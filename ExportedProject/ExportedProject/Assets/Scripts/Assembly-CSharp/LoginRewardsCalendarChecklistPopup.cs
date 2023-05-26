using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginRewardsCalendarChecklistPopup : SGUGUIPopup
{
	[SerializeField]
	protected Image backgroundImage;

	[SerializeField]
	protected RectTransform frameTransform;

	[SerializeField]
	private TalkingHeadController talkingHeadController;

	[SerializeField]
	private LocalizedUGUIText titleText;

	[SerializeField]
	private LocalizedUGUIText descriptionText;

	[SerializeField]
	private TimerUI resetTimer;

	[SerializeField]
	private GameObject timerHintGO;

	[SerializeField]
	private TimerUI nextRewardTimer;

	[SerializeField]
	private LocalizedUGUIText nextRewardText;

	[SerializeField]
	protected LoginRewardsCalendarItem itemPrototype;

	[SerializeField]
	private GameObject bigCalendarGO;

	[SerializeField]
	private LoginRewardsCalendarItem bigCalendarItem;

	protected int itemCounter;

	protected List<LoginRewardsCalendarItem> items;

	private List<RewardCalendarStateServerData> rewardCalendarStates;

	private int rewardCalendarIndex;

	protected override void Awake()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	protected override void ButtonPressed(int index)
	{
	}

	private void PopulateNextCalendar()
	{
	}

	private void ClearItems()
	{
	}

	private LoginRewardsCalendarItem GetItem()
	{
		return null;
	}
}
