using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SplashScreen : MonoSingleton<SplashScreen>
{
	public enum SplashScreenButtonType
	{
		Store = 1,
		Challenges = 2,
		Collection = 4,
		Gacha = 8,
		Story = 0x10,
		Leaderboards = 0x20,
		Events = 0x40,
		Mail = 0x80,
		Practice = 0x100,
		Inventory = 0x200,
		Social = 0x400,
		SyncPvp = 0x800,
		Calendar = 0x1000,
		Replays = 0x2000,
		Rift = 0x4000
	}

	[SerializeField]
	private GameObject[] screenGOs;

	[SerializeField]
	private Badge storyBadge;

	[SerializeField]
	private PopupData continueStoryPopupData;

	[SerializeField]
	private UIColorModifier storyColorModifier;

	[SerializeField]
	private Button storyButton;

	[SerializeField]
	private TimerUI eventsTimer;

	[SerializeField]
	private Badge eventsBadge;

	[SerializeField]
	private UIColorModifier eventsColorModifier;

	[SerializeField]
	private Button eventsButton;

	[SerializeField]
	private TimerUI leaderboardEventsTimer;

	[SerializeField]
	private Badge leaderboardEventsBadge;

	[SerializeField]
	private UIColorModifier leaderboardEventsColorModifier;

	[SerializeField]
	private Button leaderboardEventsButton;

	[SerializeField]
	private TimerUI riftBattleEventsTimer;

	[SerializeField]
	private Badge riftBattleEventsBadge;

	[SerializeField]
	private UIColorModifier riftBattlesColorModifier;

	[SerializeField]
	private Button riftBattlesButton;

	[SerializeField]
	private Badge syncPvpEventsBadge;

	[SerializeField]
	private UIColorModifier syncPvpColorModifier;

	[SerializeField]
	private Button syncPvpButton;

	[SerializeField]
	private Badge challengesBadge;

	[SerializeField]
	private PopupData challengesPopupData;

	[SerializeField]
	private Image challengesProgressMeterFilament;

	[SerializeField]
	private Badge gachasBadge;

	[SerializeField]
	private Image gachaImage;

	[SerializeField]
	private float gachaImageDisplaySeconds;

	[SerializeField]
	private float gachaImageFadeSeconds;

	[SerializeField]
	private UIColorModifier gachaColorModifier;

	[SerializeField]
	private Button gachaButton;

	[SerializeField]
	private UIColorModifier storeColorModifier;

	[SerializeField]
	private Button storeButton;

	[SerializeField]
	private Fight practiceModeFight;

	[SerializeField]
	private Badge collectionBadge;

	[SerializeField]
	private Badge socialBadge;

	[SerializeField]
	private Badge storeBadge;

	[SerializeField]
	private GameObject storeTextBadgeGO;

	[SerializeField]
	private Badge mailBadge;

	[SerializeField]
	private Badge stashBadge;

	[SerializeField]
	private Transform relicsButtonTarget;

	[SerializeField]
	private Transform storyButtonTarget;

	[SerializeField]
	private GameObject OffersLTOButtonGO;

	[SerializeField]
	private TimerUI ltoTimer;

	[SerializeField]
	private DynamicResourceHelper ltoAttractImageDynamicResourceLoader;

	[SerializeField]
	private Image directLtoAttractImageRef;

	[SerializeField]
	private DynamicResource ltoAttractDefaultImage;

	[SerializeField]
	private Animator directPurchaseAnimator;

	[SerializeField]
	private TimerUI directPurchaseTimer;

	[SerializeField]
	private PopupData directPurchaseStorePopupData;

	[SerializeField]
	private DynamicAdButton adButton;

	public int allowInBetaSplashScreenButtonMask;

	[SerializeField]
	private PopupData loginRewardCalendarPopupData;

	[SerializeField]
	private GameObject replaysGO;

	[SerializeField]
	private UIColorModifier sidebarColorModifier;

	private int disabledButtonMask;

	private GachaData gachaForButton;

	private Coroutine gachaImageRoutine;

	private const int kMinMinutesBetweenAutoPopups = 15;

	private DateTime allowAutoPopupsTimestamp;

	private ChallengeRedirectDestination popupToRedirectTo;

	private Coroutine challengeExpirationCoroutine;

	protected override void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void AddToDisabledButtonMask(int input)
	{
	}

	public void RemoveFromDisabledButtonMask(int input)
	{
	}

	public void DEBUG_ClearDisabledButtonMask()
	{
	}

	public void ShowMainMenuUI(bool active)
	{
	}

	public Transform GetPosition(IndicatorTarget target)
	{
		return null;
	}

	public void UGUI_StoryModeClicked()
	{
	}

	public void UGUI_EventsClicked()
	{
	}

	public void UGUI_LeaderboardEventsClicked()
	{
	}

	public void UGUI_ChallengesClicked()
	{
	}

	public void UGUI_RelicsClicked()
	{
	}

	public void UGUI_CollectionClicked()
	{
	}

	public void UGUI_PracticeClicked()
	{
	}

	public void UGUI_StoreClicked()
	{
	}

	public void UGUI_StoreSizzleClicked()
	{
	}

	public void UGUI_MailClicked()
	{
	}

	public void UGUI_CalendarClicked()
	{
	}

	public void UGUI_RewardedVideoAdsPressed()
	{
	}

	public void UGUI_UnlockButtonPressed()
	{
	}

	public void UGUI_InventoryButtonPressed()
	{
	}

	public void UGUI_SocialPopupPressed()
	{
	}

	public void UGUI_RiftBattlesPressed()
	{
	}

	public void UGUI_DirectPurchasePressed()
	{
	}

	public void UGUI_SyncPvp()
	{
	}

	public void UGUI_ReplaysPressed()
	{
	}

	public void FTUE_SetAllowAutoPopupsTimestamp(DateTime timestamp)
	{
	}

	public void RedirectBasedOnChallengeDestination(ChallengeRedirectDestination destination, object context = null)
	{
	}

	private IEnumerator OnStateEntered(IGameState prevState, object context)
	{
		return null;
	}

	private IEnumerator OnStateExited(IGameState nextState)
	{
		return null;
	}

	private IEnumerator ResetChallengeUIOnExpiration()
	{
		return null;
	}

	protected bool IsButtonDisabled(SplashScreenButtonType type)
	{
		return false;
	}

	protected bool IsButtonBetaBlocked(SplashScreenButtonType type)
	{
		return false;
	}

	private void OnChallengesRefreshed(bool success)
	{
	}

	private void RefreshGachaBadge()
	{
	}

	private void StartGachaImageRefresh()
	{
	}

	private IEnumerator GachaImageRefresh()
	{
		return null;
	}

	private void SetNewGachaImage(GachaData newGacha)
	{
	}

	private void ClearGachaImage()
	{
	}

	private void RefreshChallengeUI()
	{
	}

	private void RefreshStashUI()
	{
	}

	private void UpdateAndShowLTOButton()
	{
	}

	private void UpdateDirectPurchaseStoreButton()
	{
	}

	private void UpdateAdButton(DateTime adPacingExpiration)
	{
	}

	private void HideAllBadges()
	{
	}

	private void RefreshLockedAreas()
	{
	}

	private void ShowAllScreenEnterPopups()
	{
	}

	private bool AutoShowCalendarRewardsFromLogin()
	{
		return false;
	}

	private bool AutoShowChallengesPopup()
	{
		return false;
	}

	private bool AutoShowOfferPopup()
	{
		return false;
	}

	private bool ShowProgressionPopups()
	{
		return false;
	}

	private bool QueueGuestAccountWarningPopup()
	{
		return false;
	}

	private void RefreshCollectionBadge()
	{
	}

	private void RefreshStoreBadge()
	{
	}

	private void OnCampaignActsRefreshed()
	{
	}

	private void OnEventsUpdated()
	{
	}

	private void UpdateEventButtonTimerAndBadge(EventDataType eventDataType, TimerUI timerUI, Badge badge, int badgeNumber)
	{
	}

	private void OnChallengesUpdated()
	{
	}

	private void OnAchievementsUpdated()
	{
	}

	private void OnDeploymentsUpdated()
	{
	}

	private void OnDirectPurchaseStoreUpdated()
	{
	}

	private void OnProfileUpdated(Profile profile)
	{
	}

	private void OnSocialStateUpdated()
	{
	}

	public SplashScreen()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
