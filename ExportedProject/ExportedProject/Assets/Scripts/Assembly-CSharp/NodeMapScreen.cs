using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NodeMapScreen : MonoBehaviour
{
	public class NodeMapScreenContext
	{
		public bool viewMyDefenseMap;

		public bool viewDetailedHistory;

		public BattleInstanceServerData historyDefenseBattleInstance;
	}

	[SerializeField]
	private ScrollRect mapScrollRect;

	[SerializeField]
	private float firstNodeTravelTime;

	[SerializeField]
	private float additionalNodeTravelTime;

	[SerializeField]
	private Zone defaultZone;

	[SerializeField]
	private GameObject indicatorPrefab;

	[SerializeField]
	private UIGradient32 backgroundGradient;

	[SerializeField]
	private GameObject zoneAndDifficultyGO;

	[SerializeField]
	private GameObject buttonUnlockAndCompletionTextGO;

	[SerializeField]
	private LocalizedUGUIText zoneNameText;

	[SerializeField]
	private LocalizedUGUIText difficultyText;

	[SerializeField]
	private Text completionPercentText;

	[SerializeField]
	private GameObject matchChallengesParentGO;

	[SerializeField]
	private RectTransform noChallengeCompletionTextTarget;

	[SerializeField]
	private RectTransform challengeCompletionTextTarget;

	[SerializeField]
	private LocalizedUGUIText completedChallengesText;

	[SerializeField]
	private LocalizedUGUIText totalChallengesText;

	[SerializeField]
	private GameObject riftBattlesGO;

	[SerializeField]
	private GameObject activeBattleGO;

	[SerializeField]
	private GameObject setupBattleGO;

	[SerializeField]
	private GameObject revengeParent;

	[SerializeField]
	private GameObject lossesRemainingWarningGlow;

	[SerializeField]
	private GameObject defenderDiversityWarningGO;

	[SerializeField]
	private LocalizedUGUIText mainMapStateText;

	[SerializeField]
	private LocalizedUGUIText subMapStateText;

	[SerializeField]
	private LocalizedUGUIText scoreText;

	[SerializeField]
	private LocalizedUGUIText scoreToBeatText;

	[SerializeField]
	private LocalizedUGUIText lossesRemainingText;

	[SerializeField]
	private GameObject ltaTimerGO;

	[SerializeField]
	private TimerUI ltaTimer;

	[SerializeField]
	private GameObject battleAutoCompletedGO;

	[SerializeField]
	private GameObject buttonUnlockGO;

	private RectTransform scrollRectTransform;

	private RectTransform mapContainer;

	private NodeMap currentMap;

	private NodeMap currentMapPrefab;

	private Zone currentZone;

	private UIRectAutoSizer boundsSizer;

	private PinchAndZoom pinchAndZoom;

	private Transform envCameraTransform;

	private Vector3 originalPosition;

	private float widthScale;

	private float heightScale;

	private NodeMapScreenContext currentContext;

	private int lastRiftBattleMatchPreviewVisited;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void ShowIndicator(int matchIndex)
	{
	}

	public void CleanupAllIndicators()
	{
	}

	public void UGUI_ConfirmButtonPressed()
	{
	}

	public void UGUI_ViewDefenseWinsToggled(bool isOn)
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

	private void Populate(NodeMap nodeMap, Zone zone, SGMatch[] matches)
	{
	}

	private void CalculateParallaxScale()
	{
	}

	private void OnZoomUpdated(float newZoom)
	{
	}

	private void DisplayMatchModifiers(SGMatch match)
	{
	}

	private void OnNodePressed(MapNode node)
	{
	}

	private void MovePickAndTransitionToNextState(MapNode node)
	{
	}

	private void TransitionToNextState(IPopup popup, MapNode node)
	{
	}

	private bool IsInValidStateToTransition(SGMatch match)
	{
		return false;
	}

	private void ExitNodeMapToState(string popupLocKey, string exitState)
	{
	}

	private void ActivateScrollView()
	{
	}
}
