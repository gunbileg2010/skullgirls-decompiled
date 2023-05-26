using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeamSelectScreen : MonoSingleton<TeamSelectScreen>
{
	public class TeamSelectScreenContext
	{
		public bool isDefenseTeamSelection;

		public bool isTeamValid;

		public int nodeIndex;
	}

	[Serializable]
	public class NodeModifierCircularPosData
	{
		public float radius;

		public float initialRotation;
	}

	public static int localPvpStage;

	[SerializeField]
	private Transform cameraTargetMarker;

	[SerializeField]
	private FighterScoreComparison teamFighterScore;

	[SerializeField]
	private LocalizedUGUIText instructionsText;

	[SerializeField]
	private DragTutorial dragTutorial;

	[SerializeField]
	private RectTransform teamCardsPosition;

	[SerializeField]
	private Transform[] teamCardMarkers;

	[SerializeField]
	private RecycledScrollList recycledScrollList;

	[SerializeField]
	private RectTransform dragCardParent;

	[SerializeField]
	private CardSlotTeamSelect scrollViewCardRemovalSlot;

	[SerializeField]
	private Vector2 cardSizeFighters;

	[SerializeField]
	private Vector2 cardSizeNodeModifiers;

	[SerializeField]
	private float cardSizeFighterMultiplierForTabBar;

	[SerializeField]
	private float cardSizeNodeModifiersMultiplierForTabBar;

	[SerializeField]
	private GameObject sortAndFilterButton;

	[SerializeField]
	private PopupData sortAndFilterPopupData;

	[SerializeField]
	private GameObject activeFilterSortGlowGO;

	[SerializeField]
	private Toggle availableFilterToggle;

	[SerializeField]
	private GameObject clearTeamCardsButtonGO;

	[SerializeField]
	private Transform backButtonTarget;

	[SerializeField]
	private Button fightButton;

	[SerializeField]
	private LocalizedUGUIText fightButtonText;

	[SerializeField]
	private Button fightHelpButton;

	[SerializeField]
	private EnergyUI fightEnergy;

	[SerializeField]
	private MatchModifierUI matchModifiersUI;

	[SerializeField]
	private GameObject defenseHistoryButtonGO;

	[SerializeField]
	private Button defenseHistoryButton;

	[SerializeField]
	private Badge defenseHistoryBadge;

	[SerializeField]
	private Transform constraintsTransform;

	[SerializeField]
	private FightConstraintUI constraintIconPrefab;

	[SerializeField]
	private RectTransform[] nodeModifiersParents;

	[SerializeField]
	private RectTransform[] nodeModifierCardMarkers;

	[SerializeField]
	private GameObject attackerDiversityWarningGO;

	[SerializeField]
	private GameObject defenderDiversityWarningGO;

	[SerializeField]
	private List<NodeModifierCircularPosData> nodeModifierCardMarkersCircleLayoutInfo;

	[SerializeField]
	private ContextualTutorial nodeModifierContextualTutorial;

	private static bool tutorialMode;

	private bool initialized;

	private static CharacterSortAndFilter characterSortAndFilter;

	private CollectibleNodeModifierSortAndFilter nodeModifierSortAndFilter;

	private GameState gameState;

	private List<Character> originalTeamCharacters;

	private List<Character> teamCharacters;

	private List<CollectibleNodeModifier> originalTeamNodeModifiers;

	private List<CollectibleNodeModifier> teamNodeModifiers;

	private List<Character> characterCollection;

	private List<Character> filteredAndSortedCharacterCollection;

	private List<CollectibleNodeModifier> nodeModifierCollection;

	private List<CollectibleNodeModifier> filteredAndSortedNodeModifierCollection;

	private Stack<CharacterCard> availableCharacterCards;

	private Stack<CollectibleNodeModifierCard> availableNodeModifierCards;

	private List<FightConstraintUI> fightConstraintIcons;

	private TeamSelectScreenContext currentContext;

	private SGMatch currentMatch;

	private Fight currentFight;

	private EventServerData currentEvent;

	private Animation inOutAnim;

	private MatchPreviewScreen matchPreviewScreen;

	private bool showNodeModifiers;

	private TeamSelectSlotMode lastScrollListTab;

	private CollectibleNodeModifierCard lastNodeModifierHolder;

	private bool pressedConfirmButton;

	private List<Card> draggedCards;

	private bool canRemoveCards;

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

	public TeamSelectScreenContext GetContext()
	{
		return null;
	}

	public void SetTeamCharacter(int index, Character character)
	{
	}

	public void SetNodeModifier(int index, CollectibleNodeModifier nodeModifier)
	{
	}

	public bool CanPlaceCardInTeamArea(int index, DragCardTeamSelect nonTeamAreaCard, DragCardTeamSelect teamAreaCard = null)
	{
		return false;
	}

	public void AddCollectionCard(Card cardToPutInScrollList)
	{
	}

	public void RemoveCollectionCard(Card cardToPutInTeam)
	{
	}

	public void AddDraggingCard(Card card)
	{
	}

	public void RemoveDraggingCard(Card card)
	{
	}

	public void SwapCollectionCards(Card cardToPutInScrollList, Card cardToPutInTeam)
	{
	}

	public Transform GetPosition(IndicatorTarget target)
	{
		return null;
	}

	public void ToggleDragTutorial(bool show)
	{
	}

	public List<Character> GetTeamCharacters()
	{
		return null;
	}

	public void UGUI_FightButtonPressed()
	{
	}

	public void UGUI_FightButtonHelperPressed()
	{
	}

	public void UGUI_FilterSortButtonClicked()
	{
	}

	public void UGUI_AvailableTogglePressed(bool on)
	{
	}

	public void UGUI_ShowFightModifiers()
	{
	}

	public void UGUI_DefenseHistoryButtonPressed()
	{
	}

	public void UGUI_ClearTeamCardsPressed()
	{
	}

	public void UGUI_TabButtonTeamSelectPressed(int index, Action callback = null)
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

	private void BuildScrollListForCharacters(Action callback = null)
	{
	}

	private RectTransform OnAddCharacterScrollItem(int index)
	{
		return null;
	}

	private void OnRemoveCharacterScrollItem(RectTransform item)
	{
	}

	private void OnCharacterSortOrFilterChanged()
	{
	}

	private CharacterCard TakeCharacterCard(Character character, bool isInTeamArea, bool allowDrag, bool allowSwap = true)
	{
		return null;
	}

	private bool DoesCharacterJeopardizeAttackerDiversity(Character character)
	{
		return false;
	}

	private bool DoesTeamJeopardizeAttackerDiversity()
	{
		return false;
	}

	private void OnDefenderVariantCountsUpdated()
	{
	}

	private bool DoesCharacterExistOnAnotherNode(Character character)
	{
		return false;
	}

	private void TryShowDefenderDiversityWarning()
	{
	}

	private void TryShowDefenderDiversityWarningForCard(CharacterCard card)
	{
	}

	private void BuildScrollListForNodeModifiers()
	{
	}

	private RectTransform OnAddNodeModifierScrollItem(int index)
	{
		return null;
	}

	private void OnRemoveNodeModifierScrollItem(RectTransform item)
	{
	}

	private void OnNodeModifierSortOrFilterChanged()
	{
	}

	private CollectibleNodeModifierCard TakeNodeModifierCard(CollectibleNodeModifier nodeModifier, bool isInTeamArea, bool allowDrag, bool allowSwap = true)
	{
		return null;
	}

	private void OnNodeModifierPressed(Card card)
	{
	}

	private void OnNodeModifierSold(CollectibleNodeModifierCard soldCard)
	{
	}

	private void OnNodeModifierUpgraded(CollectibleNodeModifierCard upgradedCard)
	{
	}

	private bool DoesNodeModifierExistOnAnotherNode(CollectibleNodeModifier nodeModifier)
	{
		return false;
	}

	private void RecycleAllCards()
	{
	}

	private void OnTeamUpdated()
	{
	}

	private void OnBeginDrag()
	{
	}

	private void OnEndDrag()
	{
	}

	private IEnumerator ConfirmTeamChoice(Action callback, bool callbackOnNetworkFailure = false, bool showConfirmationPopup = false)
	{
		return null;
	}

	private void OnSetTeamNetworkRequestFinished(NetworkRequest request, Action callback, bool callbackOnNetworkFailure = false)
	{
	}

	private bool IsCharacterExcluded(Character character, bool excludeDeployment = false, List<Character> characterList = null)
	{
		return false;
	}

	private int GetCharacterUseCountInRiftBattle(Character character)
	{
		return 0;
	}

	private bool CanCharacterBeUsedInRiftBattle(Character character)
	{
		return false;
	}

	private void CheckFightConstraints(Action callback = null)
	{
	}

	private void CreateFightConstraintIcons()
	{
	}

	private void OnStateChanged(string fromState, string toState)
	{
	}

	private void OnDefenseHistoryPointsClaimed()
	{
	}

	private void UpdateCardEnergyDisplay(GameType gameType, CharacterCard card)
	{
	}

	private void TryShowAttackerDiversityWarningOnCard(CharacterCard card)
	{
	}

	private bool IsDefenseTeamFullyFilled()
	{
		return false;
	}

	private bool CheckForPlacementErrorsAndShowPopup(int index, DragCardTeamSelect nonTeamAreaCard, DragCardTeamSelect teamAreaCard = null)
	{
		return false;
	}

	private void TransitionToFight()
	{
	}

	private void EnterFight(GameType gameType)
	{
	}

	public TeamSelectScreen()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
