using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class HUD : MonoSingleton<HUD>
{
	[SerializeField]
	private Transform drawAboveActorsTransform;

	[SerializeField]
	private CanvasGroup flasherImage;

	[SerializeField]
	private Animation fightIntroShowtimeAnim;

	[SerializeField]
	private List<GameObject> fightIntroDisableFlashingList;

	[SerializeField]
	private Animation fightOutroAnim;

	[SerializeField]
	private LocalizedUGUIText fightOutroHeaderText;

	[SerializeField]
	private LocalizedUGUIText fightOutroFooterText;

	[SerializeField]
	private BlockbusterIntroUI blockbusterIntroUI;

	[SerializeField]
	private RectTransform topBar;

	[SerializeField]
	private TeammateIcon[] playerIcons;

	[SerializeField]
	private TeammateIcon[] enemyIcons;

	[SerializeField]
	private CharacterAbilityButton playerCharacterAbilityButton;

	[SerializeField]
	private List<CharacterAbilityButton> playerCharacterAbilityAuxButtons;

	[SerializeField]
	private CharacterAbilityButton enemyCharacterAbilityButton;

	[SerializeField]
	private List<CharacterAbilityButton> enemyCharacterAbilityAuxButtons;

	[SerializeField]
	private PrestigeMeter p1PrestigeMeter;

	[SerializeField]
	private PrestigeMeter p2PrestigeMeter;

	[SerializeField]
	private GameObject damageTextPrefab;

	[SerializeField]
	private StatusText playerStatusText;

	[SerializeField]
	private StatusText enemyStatusText;

	[SerializeField]
	private ComboCounter playerComboCounter;

	[SerializeField]
	private PauseScreen pauseScreen;

	[SerializeField]
	private Button pauseButton;

	[SerializeField]
	private Toggle autoplayToggle;

	[SerializeField]
	private Text messageText;

	[SerializeField]
	private Transform fullscreenEffectsTransform;

	[SerializeField]
	private GameObject gearGO;

	[SerializeField]
	private GearHudItems playerGearHudItems;

	[SerializeField]
	private GearHudItems enemyGearHudItems;

	[SerializeField]
	private GameObject timerGO;

	[SerializeField]
	private TimerUI timer;

	[SerializeField]
	private AnimationClip constantPulseAnim;

	[SerializeField]
	private Color timerWarningColor;

	[SerializeField]
	private int timerPulseToRedThreshold;

	[SerializeField]
	private int timerConstantPulseThreshold;

	[SerializeField]
	private RawImage superDeathPortrait;

	[SerializeField]
	private GameObject superDeathGO;

	[SerializeField]
	private CanvasGroup superDeathCanvas;

	[SerializeField]
	private CanvasGroup superDeathPortraitCanvas;

	[SerializeField]
	private UILineRenderer innerPoccolaLineRenderer;

	[SerializeField]
	private UIGradient32 innerPoccolaGradient;

	[SerializeField]
	private UILineRenderer outerPoccolaLineRenderer;

	[SerializeField]
	private UIGradient32 outerPoccolaGradient;

	[SerializeField]
	private GameObject fightModifierGo;

	[SerializeField]
	private CanvasGroup fightModifierCanvasGroup;

	[SerializeField]
	private float fightModifierLingerAfterShowtimeTime;

	[SerializeField]
	private float fightModifierFadeTime;

	[SerializeField]
	private GuardMeter guardMeterP1;

	[SerializeField]
	private GuardMeter guardMeterP2;

	[SerializeField]
	private GameObject netInfoParent;

	[SerializeField]
	private SignalBarUI pingSignalBar;

	[SerializeField]
	private SpriteNumDisplayUI pingNumber;

	[SerializeField]
	private LocalizedUGUIText connectionTypeText;

	[SerializeField]
	private CanvasGroup connectyTypeCanvasGroup;

	[SerializeField]
	private PlayerNameTextUI playerNameTag;

	[SerializeField]
	private PlayerNameTextUI opponentNameTag;

	private ObjectPool<DamageText> damageTextPool;

	private List<DamageText> activeDamageTexts;

	private int playerStatusTextLastUpdatedFrame;

	private int enemyStatusTextLastUpdatedFrame;

	private Canvas uiCanvas;

	private FightController currentFightController;

	private Animation hudIntroAnim;

	private int flashCount;

	private float flashTimer;

	private const float kFlashTimeTotal = 0.1f;

	private const float kFlashTimeVisible = 0.05f;

	private bool showingSuperDeath;

	private int superDeathTimer;

	private BaseCharacterData superDeathBaseCharacter;

	private const int kSuperDeathFramesHold = 30;

	private const int kSuperDeathFramesSlideIn = 5;

	private const int kSuperDeathFramesFade = 5;

	private const int kSuperDeathFramesTotal = 40;

	private Vector3 superDeathScale;

	private bool timerToRedThresholdPassed;

	private bool damageTextEnabled;

	private const string kNetInfoDirectLocKey = "HUD_NetInfo_Direct";

	private const string kNetInfoRelayLocKey = "HUD_NetInfo_Relay";

	private AnimatePosition outroTopBarAnimatePosition;

	private AnimatePosition outroPlayerIconAnimatePosition;

	private AnimatePosition outroEnemyIconAnimatePosition;

	private Vector2 inner1;

	private Vector2 inner2;

	private Vector2 mid1;

	private Vector2 mid2;

	private Vector2 outer1;

	private Vector2 outer2;

	private List<Vector2> innerLinePoints;

	private List<Vector2> outerLinePoints;

	private Color32[] lineColors;

	private Color32 outerColor;

	private Color32 innerColor;

	private const float kXPos = 960f;

	private const float kPanDist = 50f;

	protected override void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}

	public void Init(FightController fightController)
	{
	}

	public void Shutdown()
	{
	}

	public void Flash(int count = 1)
	{
	}

	public IEnumerator PlayActionAnim()
	{
		return null;
	}

	public IEnumerator FightModifierFade()
	{
		return null;
	}

	public IEnumerator ConnectionTypeFade()
	{
		return null;
	}

	public void PlayShowAnim()
	{
	}

	public IEnumerator PlayOutroAnim(string headerText, string footerText)
	{
		return null;
	}

	public IEnumerator WaitForOutroAnim()
	{
		return null;
	}

	public void UndoOutroAnim()
	{
	}

	public IEnumerator ContinueOutroAnim(WinState winState, Team playerTeam, Team enemyTeam, FightResultServerData fightResultData, bool isTutorialFight = false)
	{
		return null;
	}

	public void AddSignatureAbilityStatusText(TeamType teamType, string signatureAbilityText, bool ignoreClearRequests = false)
	{
	}

	public void AddModifierStatusText(TeamType teamType, string modifierText, ModifierType modifierType = ModifierType.None)
	{
	}

	public void AddStatusText(TeamType teamType, string text, DamageType damageType = DamageType.NORMAL)
	{
	}

	public void ClearStatusText(TeamType teamType)
	{
	}

	public void DisplayDamageText(Actor actor, int damage, DamageType damageType = DamageType.NORMAL, string textOverride = "")
	{
	}

	public void ClearCombatTextDuringRollback(int frameRolledBackTo)
	{
	}

	public IEnumerator DoBlockbusterIntro(Character character)
	{
		return null;
	}

	public void RefreshTeamIcons(TeamType teamType)
	{
	}

	public void RefreshGearIcons()
	{
	}

	public void RefreshAutoplayIcon()
	{
	}

	public void ShowModifierIcon(Modifier modifier, TeamType teamType)
	{
	}

	public void AddModifierIcon(ModifierIcon icon, TeamType teamType)
	{
	}

	public void SetElementActive(HUDElement element, bool active)
	{
	}

	public void SetElementInteractivity(HUDElement element, bool interactive)
	{
	}

	public Transform GetPosition(IndicatorTarget target)
	{
		return null;
	}

	public CharacterAbilityButton GetCharacterAbilityButton(TeamType teamType)
	{
		return null;
	}

	public List<CharacterAbilityButton> GetCharacterAbilityAuxButtons(TeamType teamType)
	{
		return null;
	}

	public void ShowPauseScreen(bool playShowSfx)
	{
	}

	public PauseScreen GetPauseScreen()
	{
		return null;
	}

	public Transform GetFullscreenTransform()
	{
		return null;
	}

	public bool CanPause()
	{
		return false;
	}

	public void SetAIStatusText(string status, TeamType teamType = TeamType.ENEMY)
	{
	}

	public void SetComboCounterTrueCombo(bool isTrueCombo)
	{
	}

	public void DoGuardMeterCrushFlash(int team)
	{
	}

	public void DoGuardMeterDamagedFlash(int team)
	{
	}

	public void ShowMessage(string message)
	{
	}

	public void HideMessage()
	{
	}

	public void ShowAdvantageDisadvantageText()
	{
	}

	public void UGUI_PlayerPointButtonPress()
	{
	}

	public void UGUI_PlayerAssist1ButtonPress()
	{
	}

	public void UGUI_PlayerAssist2ButtonPress()
	{
	}

	public void UGUI_PauseButtonPress()
	{
	}

	public void UGUI_ModifierAlertPress()
	{
	}

	public void UGUI_AutoplayToggle(bool on)
	{
	}

	public void ShowSuperDeath(Actor actor)
	{
	}

	public void ShowCharacterAbilityAuxButtons(CharacterAbility ability, bool immediate = false)
	{
	}

	public void HideCharacterAbilityAuxButtons(TeamType teamType, bool immediate = false)
	{
	}

	public void SetCharacterAbilityAuxButtonFrame(TeamType teamType, Sprite sprite, int index = 0)
	{
	}

	public void ShowHideNetInfo(bool show)
	{
	}

	public void ShowHideGuardMeter(bool show)
	{
	}

	public void RefreshGuardMeterActors()
	{
	}

	public void SetPingDisplayValue(int ping)
	{
	}

	public void SetIsUsingDirectConnect(bool value)
	{
	}

	private void OnFightTimerTicked(object passed)
	{
	}

	private void CleanupSuperDeath()
	{
	}

	private DamageText CreateNewDamageText()
	{
		return null;
	}

	private void OnPointCharacterChanged(Team team, Character character)
	{
	}

	private void UpdateSuperDeath()
	{
	}

	public HUD()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
