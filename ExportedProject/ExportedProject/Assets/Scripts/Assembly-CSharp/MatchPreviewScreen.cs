using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatchPreviewScreen : MonoSingleton<MatchPreviewScreen>
{
	public enum MatchPreviewButtonType
	{
		ChangeTeam = 2,
		Fight = 4,
		CharacterDetails = 8,
		FightMods = 0x10,
		Elements = 0x20
	}

	public enum SyncPvpMatchmakingState
	{
		Idle = 0,
		Initializing = 1,
		WaitingForOpponent = 2,
		Matched = 3
	}

	[SerializeField]
	private Transform cameraMarker;

	[SerializeField]
	private Transform cameraDefaultMarker;

	[SerializeField]
	private Button teamSelectButton;

	[SerializeField]
	private Button fightButton;

	[SerializeField]
	private LocalizedUGUIText fightButtonText;

	[SerializeField]
	private Button fightHelpButton;

	[SerializeField]
	private Button syncFindOpponentHelpButton;

	[SerializeField]
	private Button syncPrivateMatchHelpButton;

	[SerializeField]
	private Transform xpBoostTransform;

	[SerializeField]
	private FighterScoreComparison fighterScoresDial;

	[SerializeField]
	private FighterInfoColumn[] playerFighterInfos;

	[SerializeField]
	private FighterInfoColumn[] enemyFighterInfos;

	[SerializeField]
	private RectTransform dropFromAboveMarker;

	[SerializeField]
	private float delayBetweenActorDrops;

	[SerializeField]
	private float[] threeActorsPlacements;

	[SerializeField]
	private float[] twoActorsPlacements;

	[SerializeField]
	private float oneActorPlacement;

	[SerializeField]
	private EnergyUI energyUI;

	[SerializeField]
	private GameObject randomIndicatorsParent;

	[SerializeField]
	private GameObject[] randomIndicators;

	[SerializeField]
	private LocalizedUGUIText winStreakText;

	[SerializeField]
	private GameObject enemyNameGO;

	[SerializeField]
	private PlayerNameTextUI enemyName;

	[SerializeField]
	private Transform constraintsTransform;

	[SerializeField]
	private FightConstraintUI constraintIconPrefab;

	[SerializeField]
	private ContextualPopupItem contextualPopupItemPrefab;

	[SerializeField]
	private MatchModifierUI matchModifiersUI;

	[SerializeField]
	private MasterPopupData elementsAffiliationInformationPopup;

	[SerializeField]
	private GameObject syncFightGO;

	[SerializeField]
	private PopupData syncPvpInfoPopup;

	[SerializeField]
	private PopupData syncPvpHostJoinPopup;

	[SerializeField]
	private AdvancedButton syncFindOpponentButton;

	[SerializeField]
	private AdvancedButton syncPrivateMatchButton;

	[SerializeField]
	private AdvancedButton syncSettingsButton;

	[SerializeField]
	private AdvancedButton syncCancelButton;

	[SerializeField]
	private PlayerNameTextUI syncFightLocalPlayerName;

	[SerializeField]
	private GameObject syncFightRemotePlayerGO;

	[SerializeField]
	private PlayerNameTextUI syncFightRemotePlayerName;

	[SerializeField]
	private GameObject syncFightRemotePlayerHandshakeStatusParent;

	[SerializeField]
	private Text syncFightRemotePlayerHandshakeStatusText;

	[SerializeField]
	private GameObject syncSearchForOpponentGO;

	[SerializeField]
	private GameObject syncCountdownGO;

	[SerializeField]
	private Text syncCountdownText;

	[SerializeField]
	private PopupData syncSettingsPopupData;

	[SerializeField]
	private ContextualTutorial syncContextualTutorial;

	[SerializeField]
	private MasterPopupData bannedErrorPopup;

	[SerializeField]
	private GameObject attackerDiversityWarningGO;

	[SerializeField]
	private GameObject syncHostPrivateMatchGO;

	[SerializeField]
	private Text syncHostPrivateMatchText;

	[SerializeField]
	private InputField syncHostPrivateMatchHiddenInputField;

	[SerializeField]
	private Text matchNameText;

	[SerializeField]
	private Text syncPvpPingDebugDisplay;

	private const int kTopBarConfiguration = 1048588;

	private static bool tutorialMode;

	private static bool goToTeamSelectAfterPopulate;

	private GameState gameState;

	private SGMatch cachedMatch;

	private GameType gameType;

	private List<Actor> playerActors;

	private int playerTeamSize;

	private List<Actor> enemyActors;

	private int enemyTeamSize;

	private List<FightConstraintUI> fightConstraintIcons;

	private ContextualPopupItem contextualPopup;

	private Coroutine actorDropCoroutine;

	private Animation inOutAnim;

	private bool forceClearContextOnExit;

	private int screenInstanceId;

	private int disabledButtonMask;

	private Coroutine syncStartFight;

	private List<Character> syncEmptyOpponentList;

	private static bool cellularDataWarningShown;

	private bool metricsInPrivateMatch;

	private string cachedSyncRoomId;

	private List<GameObject> tutorialIndicators;

	private const string kBannedFighterError = "Popup_MatchPreview_SyncPvp_BannedFighterError---\n";

	private const string kBannedMoveError = "Popup_MatchPreview_SyncPvp_BannedMoveError---\n";

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	public static void SetTutorialMode(bool active)
	{
	}

	public static void GoToTeamSelectAfterPopulate()
	{
	}

	public void ToggleAttackerDiversityWarning(bool active)
	{
	}

	public Transform GetPosition(IndicatorTarget target)
	{
		return null;
	}

	public void AddToDisabledButtonMask(int input)
	{
	}

	public void RemoveFromDisabledButtonMask(int input)
	{
	}

	public void SetVisibilityFromTeamSelect(bool visible)
	{
	}

	public void ClearContext()
	{
	}

	public void StartFightRequestFailed()
	{
	}

	public void UGUI_FightButtonPressed()
	{
	}

	public void UGUI_ChooseTeamPressed()
	{
	}

	public void UGUI_SyncPvpInfoButtonPressed()
	{
	}

	public void UGUI_SyncCopyRoomIDButtonPressed()
	{
	}

	public void UGUI_SyncCopyRoomIDInputFieldChanged()
	{
	}

	public void UGUI_ShowFightModifiers()
	{
	}

	public void UGUI_DisplayElementsInfoTooltip()
	{
	}

	public void UGUI_FightButtonHelperPressed()
	{
	}

	public void UGUI_SyncFindOpponentPressed()
	{
	}

	public void UGUI_SyncFindPrivateMatchPressed()
	{
	}

	public void UGUI_SyncSettingsButtonPressed()
	{
	}

	public void UGUI_SyncCancelButtonPressed()
	{
	}

	public void HACKSetFightButtonInteractable(bool interactive)
	{
	}

	public void PointAtXPBoost(List<TutorialIndication> indications)
	{
	}

	public void DestroyTutorialIndicators()
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

	private void PrepMatch()
	{
	}

	private void OnFightPrepped(Action callback = null)
	{
	}

	private void ResetUI()
	{
	}

	private void RefreshMatchData(bool immediate, Action callback = null)
	{
	}

	private void RefreshPlayerData(Action callback = null)
	{
	}

	private void RefreshEnemyData(Action callback = null)
	{
	}

	private void RefreshActorLayout(List<Character> newCharacters, TeamType teamType, List<Character> playerCharacters)
	{
	}

	private void PopulateInfoColumns(List<Character> characters, List<Character> failedCharacters, TeamType teamType)
	{
	}

	private Vector3 GetActorPosition(TeamType teamType, int index)
	{
		return default(Vector3);
	}

	private void SpawnActor(Character character, TeamType teamType, int index, List<Character> playerCharacters)
	{
	}

	private void RefreshLoadedActorArtIfAnyIsUnloaded()
	{
	}

	private void RefreshLoadedActorArt()
	{
	}

	private void RefreshEnemyTinting(Character enemyCharacter, List<Character> playerCharacters)
	{
	}

	private void DropActor(TeamType teamType, int index)
	{
	}

	private void StartActorDropSequence()
	{
	}

	private IEnumerator DoActorDropSequence()
	{
		return null;
	}

	private void SetPlayerTeamTint(Color tint, float duration)
	{
	}

	private void Cleanup()
	{
	}

	private void TransitionToFight()
	{
	}

	private bool IsButtonDisabled(MatchPreviewButtonType type)
	{
		return false;
	}

	private void RefreshFighterInfoInteractability()
	{
	}

	private void OnCharacterDetailsDesired(Character character)
	{
	}

	private void OnEnemyDetailsPopup(Character character)
	{
	}

	private void OnStateChanged(string fromState, string toState)
	{
	}

	private void RefreshSyncPvpUI(SyncPvpMatchmakingState state)
	{
	}

	private void OnReadyToBeginFight()
	{
	}

	private void OnMatchmakingStatusChanged(SyncFightManager.MatchmakingStatus status, string statusLoc, bool isError = false, string errorCode = "", string errorMessage = "", string errorDetail = "")
	{
	}

	private void OnConnectedToGameServer(string roomCode)
	{
	}

	private void FireCellularDataWarning()
	{
	}

	private IEnumerator SyncFightCountdownAndStart()
	{
		return null;
	}

	private void UpdateDebugPingDisplay()
	{
	}

	private void PerformSyncPvpPrefightCheck(bool respectBannedVariants, Action successCallback)
	{
	}

	private void EnterFight()
	{
	}

	public MatchPreviewScreen()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
