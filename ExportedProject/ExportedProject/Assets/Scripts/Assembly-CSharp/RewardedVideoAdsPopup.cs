using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardedVideoAdsPopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private TalkingHeadController peacockTalkingHeadController;

	[SerializeField]
	private TalkingHead peacockTalkingHead;

	[SerializeField]
	private Canvas peacockSubCanvas;

	[SerializeField]
	private TalkingHeadController tebyTalkingHeadController;

	[SerializeField]
	private Canvas tebySubCanvas;

	[SerializeField]
	private float rewardHeight;

	[SerializeField]
	private ScrollRect rewardPreviewScroll;

	[SerializeField]
	private RewardItem rewardPreview;

	[SerializeField]
	private RectTransform rewardPreviewParent;

	[SerializeField]
	private Button watchButton;

	[SerializeField]
	private TimerUI watchButtonTimer;

	[SerializeField]
	private LocalizedUGUIText amountWatched;

	[SerializeField]
	private Image playArrow;

	[SerializeField]
	private string popupEnterQuipsAdAvailableEmote;

	[SerializeField]
	private List<string> popupEnterQuipsAdAvailable;

	[SerializeField]
	private string popupEnterQuipsAdNotAvailableEmote;

	[SerializeField]
	private List<string> popupEnterQuipsAdNotAvailable;

	[SerializeField]
	private string popupEnterQuipsAdCappedEmote;

	[SerializeField]
	private List<string> popupEnterQuipsAdCapped;

	[SerializeField]
	private string backFromAdQuipsEmote;

	[SerializeField]
	private List<string> backFromAdQuips;

	[SerializeField]
	private StoryDialogItemController quipBubble;

	[SerializeField]
	private float quipScaleDuration;

	[SerializeField]
	private ContextualTutorial rewardedVideoAdsContextualTutorial;

	private DialogueItem quipDialogue;

	private EZAnimOptions quipAnimOptions;

	private bool isQuipVisible;

	private List<RewardItem> spawnedRewardPreviews;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_AdButtonPressed()
	{
	}

	public void UGUI_QuipPressed()
	{
	}

	private void OnAdClosed()
	{
	}

	private void ShowQuipAfterAd()
	{
	}

	private void ShowQuip(List<string> quipList)
	{
	}

	private void PopulateRewardContainers(List<Loot> potentialLoot)
	{
	}

	private void UpdateAdButton(DateTime adPacingExpiration)
	{
	}
}
