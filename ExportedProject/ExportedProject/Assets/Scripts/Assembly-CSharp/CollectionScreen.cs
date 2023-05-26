using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionScreen : MonoBehaviour
{
	[SerializeField]
	private GameObject charactersGO;

	[SerializeField]
	private GameObject movesGO;

	[SerializeField]
	private GameObject nodeModifiersGO;

	[SerializeField]
	private RecycledScrollList characterRecycledScrollList;

	[SerializeField]
	private RecycledScrollList gearRecycledScrollList;

	[SerializeField]
	private float longPressScrollThreshold;

	[SerializeField]
	private RecycledScrollList nodeModifiersRecycledScrollList;

	[SerializeField]
	private Button charactersButton;

	[SerializeField]
	private Button specialMovesButton;

	[SerializeField]
	private Button nodeModifiersButton;

	[SerializeField]
	private Text characterCount;

	[SerializeField]
	private Text moveCount;

	[SerializeField]
	private Text nodeModifierCount;

	[SerializeField]
	private GameObject catalogButtonGO;

	[SerializeField]
	private Badge charactersBadge;

	[SerializeField]
	private Badge movesBadge;

	[SerializeField]
	private Badge nodeModifiersBadge;

	[SerializeField]
	private PopupData sortAndFilterPopupData;

	[SerializeField]
	private GameObject activeFilterSortGlowGO;

	[SerializeField]
	private AspectRatioGridZoom gridZoom;

	[SerializeField]
	private Button zoomInButton;

	[SerializeField]
	private Button zoomOutButton;

	[SerializeField]
	private RewardsPopupData rewardsPopupData;

	[SerializeField]
	private int multiSellMaxCount;

	[SerializeField]
	private Button multiSellSelectButton;

	[SerializeField]
	private Button multiSellConfirmButton;

	[SerializeField]
	private Button multiSellCancelButton;

	[SerializeField]
	private GameObject multiSelectedGO;

	[SerializeField]
	private LocalizedUGUIText sellInstructions;

	[SerializeField]
	private Text multiSelectCounterText;

	[SerializeField]
	private LocalizedUGUIText secondarySellInstructions;

	[SerializeField]
	private MasterPopupData confirmSellMultiGearPopupData;

	[SerializeField]
	private MasterPopupData confirmSellMultiNodeModifierPopupData;

	[SerializeField]
	private GameObject expandCharacterCollectionPrefab;

	[SerializeField]
	private GameObject expandGearCollectionPrefab;

	[SerializeField]
	private GameObject expandNodeModifierCollectionPrefab;

	[SerializeField]
	private ContextualTutorial contextualTutorial;

	private const string kMovesToSellBase = "({0:0} / {1:0})";

	private CharacterSortAndFilter characterSortAndFilter;

	private GearSortAndFilter gearSortAndFilter;

	private CollectibleNodeModifierSortAndFilter nodeModifierSortAndFilter;

	private List<Character> characterCollection;

	private List<Character> filteredAndSortedCharacterCollection;

	private Stack<CharacterCard> availableCharacterCards;

	private List<Gear> gearCollection;

	private List<Gear> filteredAndSortedGearCollection;

	private Stack<GearCardHolder> availableGearCardHolders;

	private List<CollectibleNodeModifier> nodeModifierCollection;

	private List<CollectibleNodeModifier> filteredAndSortedNodeModifierCollection;

	private Stack<CollectibleNodeModifierCard> availableNodeModifierCards;

	private GearCard showingDetailsGearCard;

	private bool multiSelectMode;

	private List<Gear> selectedGear;

	private List<CollectibleNodeModifier> selectedNodeModifiers;

	private GameObject expandCharacterCollectionGO;

	private GameObject expandGearCollectionGO;

	private GameObject expandNodeModifierCollectionGO;

	private GearCardHolder lastGearCardHolder;

	private CollectibleNodeModifierCard lastNodeModifierHolder;

	private CollectionType currentlyViewedCollection;

	private Dictionary<CollectionType, bool> haveNotYetViewed;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void UGUI_FighterCatalogButtonClicked()
	{
	}

	public void UGUI_MultiSellButtonClicked()
	{
	}

	public void UGUICharactersClicked()
	{
	}

	public void UGUISpecialMovesClicked()
	{
	}

	public void UGUI_NodeModifiersClicked()
	{
	}

	public void UGUIZoomOutClicked()
	{
	}

	public void UGUIZoomInClicked()
	{
	}

	public void UGUI_MultiSellToggled(bool modeOn)
	{
	}

	public void UGUI_FilterSortButtonClicked()
	{
	}

	public void UGUI_ExpandCharacterCollectionButtonClicked()
	{
	}

	public void UGUI_ExpandGearCollectionButtonClicked()
	{
	}

	public void UGUI_ExpandNodeModifierCollectionButtonClicked()
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

	private void UpdateNewTags(CollectionType upcomingCollection)
	{
	}

	private void DisplayCharacters()
	{
	}

	private void DisplayGear()
	{
	}

	private void DisplayNodeModifiers()
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

	private RectTransform OnAddGearScrollItem(int index)
	{
		return null;
	}

	private void OnRemoveGearScrollItem(RectTransform item)
	{
	}

	private void OnGearSortOrFilterChanged()
	{
	}

	private void OnGearSelected(GearCardHolder icon)
	{
	}

	private void PopulateGearDetails(GearCardHolder icon, bool shouldShowFavorites)
	{
	}

	private void OnGearUpgraded()
	{
	}

	private void OnGearSold()
	{
	}

	private void OnGearLockStateChanged()
	{
	}

	private void ClearSelectedGear()
	{
	}

	private void SellGear()
	{
	}

	private Currency GetGearSalePrice()
	{
		return null;
	}

	private void SellCollectibleNodeModifiers()
	{
	}

	private Currency GetNodeModifierSalePrice()
	{
		return null;
	}

	private void ClearSelectedNodeModifiers()
	{
	}

	private void OnNodeModifierUpgraded(CollectibleNodeModifierCard upgradedNodeModifierCard)
	{
	}

	private void OnNodeModifierSold()
	{
	}

	private void OnNodeModifierLockStateChanged()
	{
	}

	private RectTransform OnAddNodeModifierScrollItem(int index)
	{
		return null;
	}

	private void OnNodeModifierSelected(CollectibleNodeModifierCard nodeModifierCard)
	{
	}

	private void OnRemoveNodeModifierScrollItem(RectTransform item)
	{
	}

	private void OnNodeModifierSortOrFilterChanged()
	{
	}

	private bool IsInCharactersCollection()
	{
		return false;
	}

	private bool IsInGearCollection()
	{
		return false;
	}

	private bool IsInNodeModifierCollection()
	{
		return false;
	}

	private int GetDisplayedCharacterCount()
	{
		return 0;
	}

	private int GetDisplayedGearCount()
	{
		return 0;
	}

	private int GetDisplayedNodeModifierCount()
	{
		return 0;
	}

	private void MaybeShowPrestigeAbilityTutorial()
	{
	}

	private void OnStateChanged(string fromState, string toState)
	{
	}
}
