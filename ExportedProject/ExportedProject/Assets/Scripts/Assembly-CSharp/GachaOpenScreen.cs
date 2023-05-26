using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GachaOpenScreen : MonoBehaviour
{
	public enum Phase
	{
		Intro = 0,
		Procession = 1,
		Rewards = 2,
		Results = 3
	}

	public class GachaOpenScreenContext
	{
		public GachaData gachaData;

		public List<Reward> rewards;

		public int openedAmount;

		public bool wasVoucherPurchase;

		public int denominationIndex;
	}

	[Serializable]
	public class GachaOpenVFX
	{
		public RarityTier rarity;

		public float duration;

		public GameObject effectGO;
	}

	[SerializeField]
	private Stage stage;

	[SerializeField]
	private Camera reelCamera;

	[SerializeField]
	private Animator lightBeamAnimator;

	[SerializeField]
	private Transform lightBeamTransform;

	[SerializeField]
	private GameObject lightBeamVfxGO;

	[SerializeField]
	private SpriteRenderer[] lightBeams;

	[SerializeField]
	private GameObject preOpenGO;

	[SerializeField]
	private DragReel dragReelControl;

	[SerializeField]
	private Transform reel3DSpawnAnchor;

	[SerializeField]
	private CanvasGroup dragToOpenCanvasGroup;

	[SerializeField]
	private GameObject openAllReelsButtonGO;

	[SerializeField]
	private Text openAllReelsText;

	[SerializeField]
	private GameObject ReelsHolderGO;

	[SerializeField]
	private GameObject introPedestalGO;

	[SerializeField]
	private Transform relicShadow;

	[SerializeField]
	private GameObject circleGO;

	[SerializeField]
	private Badge gachaCountBadge;

	[SerializeField]
	private Vector2 introDebrisSpeeds;

	[SerializeField]
	private float buttonsHidingSpeed;

	[SerializeField]
	private int maxNumberToOpen;

	[SerializeField]
	private GameObject openGO;

	[SerializeField]
	private Transform gachaOpenMarker;

	[SerializeField]
	private GachaEffects defaultGachaEffects;

	[SerializeField]
	private float openGachaInitialRotationSpeed;

	[SerializeField]
	private float openGachaEnergizeRotationSpeed;

	[SerializeField]
	private float openGachaEnergizeRotationDuration;

	[SerializeField]
	private List<GachaOpenVFX> openingVfx;

	[SerializeField]
	private GameObject rewardDisplayGO;

	[SerializeField]
	private Button rewardDisplayButton;

	[SerializeField]
	private Transform characterMarker;

	[SerializeField]
	private GameObject characterNameGO;

	[SerializeField]
	private LocalizedUGUIText characterPrimaryText;

	[SerializeField]
	private LocalizedUGUIText characterSecondaryText;

	[SerializeField]
	private UIGradient32 characterPrimaryGradiant;

	[Space]
	[SerializeField]
	private Transform prizeItemAnchor;

	[SerializeField]
	private SpriteFrameAnimation safeSpriteFrameAnimation;

	[SerializeField]
	private GameObject otherNameGO;

	[SerializeField]
	private GameObject currencyNameGO;

	[SerializeField]
	private GameObject specialNameGO;

	[SerializeField]
	private Text currencyPrimaryText;

	[SerializeField]
	private LocalizedUGUIText currencySecondaryText;

	[SerializeField]
	private Image currencyGlowImage;

	[SerializeField]
	private Image currencyIconImage;

	[SerializeField]
	private SpriteRenderer characterOutline;

	[SerializeField]
	private LocalizedUGUIText gearNameText;

	[SerializeField]
	private LocalizedUGUIText gearTypeText;

	[SerializeField]
	private LocalizedUGUIText gearCharacterText;

	[SerializeField]
	private Orbiter[] orbiters;

	[SerializeField]
	private Spline orbiterSpline;

	[SerializeField]
	private Transform orbiterSplineStartTransform;

	[SerializeField]
	private SpriteFrameAnimation orbExplosion;

	[SerializeField]
	private ParticleSystem shinyExplosion;

	[SerializeField]
	private GameObject shinyParent;

	[SerializeField]
	private UIGradient32 shinyTextGradient;

	[SerializeField]
	private Image[] shinyIcons;

	[SerializeField]
	private float maxRewardDisplayTime;

	[SerializeField]
	private Vector2 specialCharacterOutlineScale;

	[SerializeField]
	private float rewardItemScaleMultiplier;

	[SerializeField]
	private float lightBeamsDimMultiplier;

	[SerializeField]
	private RewardsPopupData rewardsBasicPopupData;

	[SerializeField]
	private RewardsPopupData rewardsOpenMorePopupData;

	[SerializeField]
	private RewardsPopupData rewardsPurchaseMorePopupData;

	[SerializeField]
	private GameObject resultPopupGO;

	[SerializeField]
	private AudioClip commonRewardStingerClip;

	[SerializeField]
	private AudioClip rareRewardStingerClip;

	[SerializeField]
	private AudioClip ultraRareRewardStingerClip;

	[SerializeField]
	private AudioClip intro;

	[SerializeField]
	private AudioClip loop;

	private static bool tutorialMode;

	private GachaData clientGachaData;

	private List<Reward> rewards;

	private List<Reward> rewardsToOpen;

	private Gacha3D gacha3D;

	private GachaEffects gachaEffects;

	private Animator environmentAnimator;

	private static int environmentDebrisSpeedParameterId;

	private LerpMaterialColor[] lerpMaterialColors;

	private int cachedNumberOwned;

	private int ambientSFXSound;

	private int gachaSpinSound;

	private int gachaHoldSound;

	private bool isOpening;

	private bool waitForReward;

	private int topBarConfiguration;

	private Vector3 podiumAnchoredPos;

	private Vector3 openAllButtonAnchoredPos;

	private GachaOpenScreenContext specificContext;

	private bool shouldShowBackButton;

	private void Awake()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	public static void EnterTutorialMode()
	{
	}

	public void UGUI_OpenAllGachas()
	{
	}

	public void UGUI_PurchaseExtraGacha()
	{
	}

	public void UGUI_GachasButtonPressed()
	{
	}

	public void UGUI_OpenAnotherPressed()
	{
	}

	public void UGUI_CollectionButtonPressed()
	{
	}

	private void MakePurchaseRequest(bool isVoucherPurchase = false)
	{
	}

	private void CleanupAndPrepForNewOpening()
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

	private void PrepIntro()
	{
	}

	private IEnumerator DoTrackGachaDragging()
	{
		return null;
	}

	private void UpdateIntroEnvironment(float mostRecentDragFactor, float holdSoundMinVolume, float holdSoundMaxVolume)
	{
	}

	private IEnumerator DoOpenGachaRoutine(bool openImmediately = false)
	{
		return null;
	}

	private IEnumerator DoAnimateOpening()
	{
		return null;
	}

	private IEnumerator DoShowPrizesSequentially()
	{
		return null;
	}

	private void ShowResultsPhase()
	{
	}

	private bool ShowGetMoreButtonForCurrencyType(CurrencyType currencyType)
	{
		return false;
	}

	private IEnumerator TrackOrbLayer()
	{
		return null;
	}

	private IEnumerator ShowReward(Reward reward, GameObject rewardCardGO)
	{
		return null;
	}

	private void SetPhase(Phase newPhase)
	{
	}

	private void ToggleCameraEffects(bool effectsOn)
	{
	}

	private void RefreshOpenMultiplesButton()
	{
	}

	private void LerpObjectPositionFromDragFactor(RectTransform transform, Vector3 startPos, Vector3 endPos, float dragFactor, bool instaReset = false)
	{
	}

	private void UpdateShadow()
	{
	}

	private void CleanUpGachaOpening()
	{
	}

	private void StartStopGachaIntroAnimations(bool start)
	{
	}

	private void StartStopGachaOpeningAnimations(bool start)
	{
	}
}
