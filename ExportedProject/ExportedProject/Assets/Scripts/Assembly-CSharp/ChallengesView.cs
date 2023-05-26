using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChallengesView : MonoBehaviour
{
	[SerializeField]
	private Badge badge;

	[SerializeField]
	private TimerUI timer;

	[SerializeField]
	private LocalizedUGUIText timerTextLocalizer;

	[SerializeField]
	private ChallengeItem challengeItemPrefab;

	[SerializeField]
	private int maxChallengeItemsPerRow;

	[SerializeField]
	private RectTransform[] challengeRowRefs;

	[SerializeField]
	public GameObject flyingEgretIconPrefab;

	[SerializeField]
	private Transform flyingEgretIconDestination;

	[SerializeField]
	private int egretPointsPerFlyingEgretIcon;

	[SerializeField]
	private float flyingEgretSpawnAnimLength;

	[SerializeField]
	private float flyingEgretAnimLength;

	[SerializeField]
	private float delayBeforeFlyingAnimBegins;

	[SerializeField]
	private ChallengeRewardThresholdUI challengeRewardThresholdPrefab;

	[SerializeField]
	private Transform challengeRewardThresholdsParent;

	[SerializeField]
	private TallyText egretPointTallyText;

	[SerializeField]
	private ScaleEZSelfContainedAnimator egretPointCounterAnimation;

	[SerializeField]
	private AudioClip egretIconArrivalSound;

	[SerializeField]
	private GameObject claimSparkPrefab;

	[SerializeField]
	private Vector3 claimSparkScale;

	[SerializeField]
	private float claimSparkOffCenteredCorrection;

	[SerializeField]
	private Image progressMeterFilament;

	[SerializeField]
	private float progressBarFillAnimDuration;

	[SerializeField]
	private AdvancedButton claimAllButton;

	[SerializeField]
	private LocalizedUGUIText claimAllButtonLocalizer;

	[SerializeField]
	private LoadingView loadingView;

	[SerializeField]
	private GameObject topUIParent;

	[SerializeField]
	private ScrollRect challengeScrollView;

	private List<ChallengeItem> challengeItems;

	private int thresholdCount;

	private int egretPointCountToUseOnProgressUI;

	private int currentClaimChallengeSoundIndex;

	private const int kMinNumberOfFlyingEgretIcons = 2;

	private const int kMaxNumberOfFlyingEgretIcons = 9;

	private const float kTimePerSparkFrame = 0.05f;

	private float progressBarSkipAmount;

	private uint kFXImageHash;

	private List<ChallengeRewardThresholdUI> challengeRewardThresholds;

	private List<GameObject> flyingEgretIcons;

	private List<GameObject> claimSparks;

	private Action<MissionControlPopup.MissionControlView> automaticTabbingCallback;

	private Action hideChallengesCallback;

	private EZAnimateFloat progressBarFillAnim;

	private Coroutine progressBarCoroutine;

	private void OnDestroy()
	{
	}

	private void Awake()
	{
	}

	public void Refresh()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void RefreshBadge()
	{
	}

	public void UGUI_ClaimAllButtonPressed()
	{
	}

	public void SetAutomaticTabbingCallback(Action<MissionControlPopup.MissionControlView> callback)
	{
	}

	public void SetHideChallengesPopupCallback(Action callback)
	{
	}

	public void HideTooltipsSpawnedOnChallengeRewardThresholds()
	{
	}

	private void RefreshChallengesUI()
	{
	}

	private void RefreshClaimAllButtonStatus()
	{
	}

	private void TryToUpdateTimerText()
	{
	}

	private void RefreshAllChallengeProgressUI(bool refreshInstantly = false)
	{
	}

	private void RefreshChallengeUIItems()
	{
	}

	private void RefreshChallengeRewardThresholds()
	{
	}

	private void HideAllChallengeItems()
	{
	}

	private void HideAllChallengeUI()
	{
	}

	private IEnumerator DoSmoothUpdatingOfProgressBar()
	{
		return null;
	}

	private IEnumerator PlayClaimSpark(Vector3 spawnPoint)
	{
		return null;
	}

	private IEnumerator PlayFlyingEgretIconsAnimation(Vector3 spawnPoint, int numberOfEgretPointsClaimed)
	{
		return null;
	}

	private void OnChallengeClaimButtonPressed(string id)
	{
	}

	private void OnChallengeGoNowButtonPressed(ChallengeRedirectDestination redirectDestination)
	{
	}

	private void OnChallengeRewardThresholdClaim(int thresholdIndex)
	{
	}

	private void OnChallengesRefreshed(bool refreshSucceeded)
	{
	}

	private void StopClaimEffects()
	{
	}

	private void StopChallengeProgressBarEffects()
	{
	}

	private void DoClaimEffects(Vector3 spawnPoint, int numberOfEgretPointsClaimed)
	{
	}

	private bool ClaimableChallengesAreAvailable()
	{
		return false;
	}

	private float CalculateTargetProgress()
	{
		return 0f;
	}
}
