using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ActSelectItem : MonoBehaviour
{
	[SerializeField]
	private RawImage coverArtImage;

	[SerializeField]
	private Badge badge;

	[SerializeField]
	private LocalizedUGUIText titleText;

	[SerializeField]
	private LocalizedUGUIText subtitleText;

	[SerializeField]
	private TimerUI expirationTimer;

	[SerializeField]
	private GameObject startTimeGO;

	[SerializeField]
	private LocalizedUGUIText startTimeText;

	[SerializeField]
	private GameObject caretGO;

	[SerializeField]
	private GameObject lockIconGO;

	[SerializeField]
	private Image frame;

	[SerializeField]
	private Sprite defaultFrameSprite;

	[SerializeField]
	private Sprite gradientMappedFrameSprite;

	[SerializeField]
	private GameObject collapsedGO;

	[SerializeField]
	private GameObject storyGO;

	[SerializeField]
	private LocalizedUGUIText descriptionText;

	[SerializeField]
	private Text completionPercentText;

	[SerializeField]
	private GameObject progressBarGO;

	[SerializeField]
	private Slider progressBarSlider;

	[SerializeField]
	private GameObject eventGO;

	[SerializeField]
	private GameObject eventButtonsGO;

	[SerializeField]
	private LocalizedUGUIText eventScoreText;

	[SerializeField]
	private LocalizedUGUIText eventPlayButtonText;

	[SerializeField]
	private LocalizedUGUIText eventRewardButtonText;

	[SerializeField]
	private Button defenseButton;

	[SerializeField]
	private LocalizedUGUIText defenseButtonText;

	[SerializeField]
	private Badge defenseBadge;

	[SerializeField]
	private RewardItem[] rewardItems;

	[SerializeField]
	private GameObject[] rewardBadges;

	[SerializeField]
	private LocalizedUGUIText[] rewardTexts;

	[SerializeField]
	private GameObject leftArrowGO;

	[SerializeField]
	private GameObject rightArrowGO;

	[SerializeField]
	private LocalizedUGUIText actTypeText;

	[SerializeField]
	private ActSelectItemTint actSelectItemTint;

	[SerializeField]
	private Text completionText;

	[SerializeField]
	private GameObject actLockGO;

	[SerializeField]
	private GameObject playsRemainingGO;

	[SerializeField]
	private LocalizedUGUIText playsRemainingText;

	[SerializeField]
	private Button playButton;

	[SerializeField]
	private Button playHelperButton;

	[SerializeField]
	private Button skipButton;

	[SerializeField]
	private Button skipHelperButton;

	[SerializeField]
	private PopupData rewardsChecklistPopupData;

	[SerializeField]
	private PopupData eventRewardsPopupData;

	[SerializeField]
	private LocalizedUGUIText unlockText;

	[SerializeField]
	private AnimationClip expandCollapseAnim;

	[SerializeField]
	private GameObject matchChallengesParentGO;

	[SerializeField]
	private LocalizedUGUIText completedChallengesText;

	[SerializeField]
	private LocalizedUGUIText totalChallengesText;

	[SerializeField]
	private Transform indicatorTarget;

	[SerializeField]
	private GameObject resetLTAProgressButtonGO;

	private GameContentData gameContentData;

	private GameContentSet gameContentSet;

	private Act act;

	private int actIndex;

	private EventData eventData;

	private EventSet eventSet;

	private ScrollListItem scrollListItem;

	private GradientColor difficultyTextGradient;

	private Color targetCoverArtTint;

	private Color targetDifficultyTextColor1;

	private Color targetDifficultyTextColor2;

	private Button button;

	private Animation animator;

	private bool isFocused;

	private bool isExpanded;

	private bool forceExpand;

	private Coroutine difficultyTintCoroutine;

	private List<Slider> progressSliders;

	private GameObject indicator;

	private ContextualPopupItem contextualPopupItem;

	private string rulesPopupCopy;

	public event Action<ActSelectItem> TimerExpired
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Populate(GameContentData gameContentData)
	{
	}

	public void Refresh()
	{
	}

	public GameContentData GetGameContentData()
	{
		return null;
	}

	public void ShowIndicator(GameObject indicatorPrefab)
	{
	}

	public void HideIndicator()
	{
	}

	public void UGUI_ButtonPressed()
	{
	}

	public void UGUI_LeftArrowPressed()
	{
	}

	public void UGUI_RightArrowPressed()
	{
	}

	public void UGUI_RewardsButtonPressed()
	{
	}

	public void UGUI_PlayButtonPressed()
	{
	}

	public void UGUI_CollapseButtonPressed()
	{
	}

	public void UGUI_DefenseButtonPressed()
	{
	}

	public void UGUI_SkipButtonPressed()
	{
	}

	public void RefreshLTAPlayAndSkipButtons()
	{
	}

	public void DEBUG_UGUI_ResetLTAProgressPressed()
	{
	}

	private void GoToContent(GameContentData contentToEnter)
	{
	}

	private IEnumerator SetDifficultyTint(float duration)
	{
		return null;
	}

	private void SetGradientColorsByDifficulty(UIGradient uiGradient, Act.Difficulty difficulty)
	{
	}

	private void SetGradientColors(UIGradient uiGradient, Gradient gradient)
	{
	}

	private void AnimateDifficultyTint(float duration)
	{
	}

	private void RefreshArrows()
	{
	}

	private void RefreshExpandedState()
	{
	}

	private void Collapse()
	{
	}

	private void Expand()
	{
	}

	private void OnWillBeFocused(ScrollListItem item)
	{
	}

	private void OnFocused(ScrollListItem item)
	{
	}

	private void OnUnfocused(ScrollListItem item)
	{
	}

	private void OnDefenseHistoryPointsClaimed()
	{
	}

	private void RefreshFrame()
	{
	}

	private void RefreshRemainingPlayCountText()
	{
	}

	private void RefreshCompletionText(GameContentData selectedContent)
	{
	}

	private void RefreshMatchChallengesText(Act selectedAct)
	{
	}

	private void RefreshUnlockedState(GameContentData selectedContent, Act selectedAct, Act.Difficulty actDifficulty)
	{
	}
}
