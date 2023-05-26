using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedingScreen : MonoBehaviour
{
	public enum FeedingScreenView
	{
		XPConsumables = 0,
		Collection = 1
	}

	[Serializable]
	public struct FeedingStat
	{
		public enum FeedingStatType
		{
			Level = 0,
			Health = 1,
			Attack = 2,
			Prestige = 3
		}

		[HideInInspector]
		public string name;

		public FeedingStatType statType;

		public LocalizedUGUIText current;

		public LocalizedUGUIText next;

		public GameObject decoration;

		public void Populate(Character character, long fedXP, bool foodHasCompatibleShiny, int prestigeGain)
		{
		}
	}

	[SerializeField]
	private FeedingCardHolder feedingCardHolderPrefab;

	[SerializeField]
	private CollectionView collectionView;

	[SerializeField]
	private GameObject collectionViewCards;

	[SerializeField]
	private GameObject xpConsumablesView;

	[SerializeField]
	private ConsumableItem[] xpConsumableItems;

	[SerializeField]
	private Toggle availableFilterToggle;

	[SerializeField]
	private Toggle prestigeFilterToggle;

	[SerializeField]
	private Toggle xpConsumablesToggle;

	[SerializeField]
	private Toggle collectionToggle;

	[SerializeField]
	private RectTransform parentOfSortAndFilter;

	[SerializeField]
	private float xCordOfSortAndFilterWhenAvailableToggleInactive;

	[SerializeField]
	private ToggleGroupRowController sectionToggleController;

	[SerializeField]
	private CharacterPortrait characterPortrait;

	[SerializeField]
	private LocalizedUGUIText characterFighterScore;

	[SerializeField]
	private ElementAffiliationUI characterElementalIcon;

	[SerializeField]
	private LocalizedUGUIText characterBase;

	[SerializeField]
	private LocalizedUGUIText characterVariant;

	[SerializeField]
	private GameObject shinyParent;

	[SerializeField]
	private Image[] shinyIcons;

	[SerializeField]
	private FeedingStat[] feedingStats;

	[SerializeField]
	private GameObject powerUpStatsGO;

	[SerializeField]
	private Text characterExperience;

	[SerializeField]
	private GameObject foodSlotsContanierGo;

	[SerializeField]
	private List<FoodSlot> foodSlots;

	[SerializeField]
	private LocalizedUGUIText instructions;

	[SerializeField]
	private Image levelBar;

	[SerializeField]
	private Image levelProjectionBar;

	[SerializeField]
	private RectTransform levelBarTransform;

	[SerializeField]
	private RectTransform levelBarBorder;

	[SerializeField]
	private LocalizedUGUIText characterLevel;

	[SerializeField]
	private GradientColor characterLevelGradient;

	[SerializeField]
	private Gradient standardFighterScoreColor;

	[SerializeField]
	private Gradient standardLevelColor;

	[SerializeField]
	private GameObject evolutionRequirementsGO;

	[SerializeField]
	private LocalizedUGUIText evolutionRequirements;

	[SerializeField]
	private AdvancedButton evolveOrConvertButton;

	[SerializeField]
	private AdvancedButton powerupButton;

	[SerializeField]
	private GameObject evolutionButtonAlternative;

	[SerializeField]
	private GameObject evolveOrConvertShinyTransferGameObject;

	[SerializeField]
	private GameObject powerUpShinyTransferGameObject;

	[SerializeField]
	private PopupData evolvePopup;

	[SerializeField]
	private PopupData powerupPopup;

	[SerializeField]
	private PopupData evolutionCelebration;

	[SerializeField]
	private Animator characterXpAnimator;

	[SerializeField]
	private CurrencyDisplayUI skillPointGainUI;

	[SerializeField]
	private float animationDuration;

	[SerializeField]
	private EZAnimation.EASING_TYPE animationInterpolator;

	[SerializeField]
	private bool playBarStinger;

	[SerializeField]
	private bool relateTierToStinger;

	[SerializeField]
	private GameObject inputBlockerGO;

	private Character currentCharacter;

	private ObjectPool<FeedingCardHolder> _feedingCardPool;

	private Coroutine powerupAnimationCoroutine;

	private bool didFirstCollectionPopulation;

	private bool didFirstXPConsumablesPopulation;

	private long xpAmountFromConsumables;

	private FeedingScreenView currentView;

	private ConsumableItem consumableItemBeingInteractedWith;

	private ConsumableManager consumableManager;

	private Dictionary<string, int> consumablesToConsume;

	private ObjectPool<FeedingCardHolder> feedingCardPool => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void UGUI_OnEvolveButtonPressed()
	{
	}

	public void UGUI_OnPowerUpButtonPressed()
	{
	}

	public void UGUI_OnPrestigeInfoButtonPressed()
	{
	}

	public void UGUI_OnPrestigeFilterButtonPressed(bool on)
	{
	}

	public void UGUI_OnAvailableTogglePressed(bool on)
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

	private void DefaultToCorrectView()
	{
	}

	private void RefreshCollectionView(Action callback = null)
	{
	}

	private void RefreshPowerUpOrEvolveUI()
	{
	}

	private void FinishRefresh(FeedingScreenView newView)
	{
	}

	private void UpdateExperienceView()
	{
	}

	private void UpdateLevelBar(float progression)
	{
	}

	private void OnConvertButtonPressed()
	{
	}

	private bool CharacterCanTransferShinyCheck(Character character)
	{
		return false;
	}

	private void RefreshAutomaticFilterAndSort()
	{
	}

	private void PopulateStats()
	{
	}

	private string GetEvolutionRequirementsText()
	{
		return null;
	}

	private bool IsEvolving()
	{
		return false;
	}

	private bool IsMaxedOut()
	{
		return false;
	}

	private bool CanEvolve()
	{
		return false;
	}

	private int GetFoodLimit()
	{
		return 0;
	}

	private void DisableButtons()
	{
	}

	private void RefreshButtons()
	{
	}

	private void UpdatePowerUpButton()
	{
	}

	private void UpdateEvolveOrConvertButton()
	{
	}

	private void OnToggleActivated(Toggle toggle)
	{
	}

	private void RefreshXPAmountFromConsumables(ConsumableItem consumableItem)
	{
	}

	private void OnConsumableXPIncreased(ConsumableItem consumableItem)
	{
	}

	private void OnConsumableXPDecreased(ConsumableItem consumableItem)
	{
	}

	private void OnAutoIncrementOrDecrementBegan(ConsumableItem consumableItem)
	{
	}

	private void OnCharacterCardClicked(Card card)
	{
	}

	private void ClearFood()
	{
	}

	private Card OnAddCard(Character character)
	{
		return null;
	}

	private void OnRemoveCard(Card card)
	{
	}

	private void GetFeedingState(Character character, Action<FeedingCardHolder.FeedingState> callback)
	{
	}

	private void ReturnFoodAt(int i)
	{
	}

	private void MakeFood(Character character, int index)
	{
	}

	private bool IsFood(Character character)
	{
		return false;
	}

	private bool GetFoodHasCompatibleShiny()
	{
		return false;
	}

	private bool IsThereEnoughSpaceForXPConsumable()
	{
		return false;
	}

	private bool IsFoodXPValid()
	{
		return false;
	}

	private Character GetCompatibleShinyFromFood()
	{
		return null;
	}

	private int GetPrestigeGainFromFood()
	{
		return 0;
	}

	private bool OnlyPrestigeCompatibleCharactersSelected()
	{
		return false;
	}

	private long GetFoodXP()
	{
		return 0L;
	}

	private int GetFoodCount()
	{
		return 0;
	}

	private void RefreshFoodInstructions()
	{
	}

	private void RefreshXPProjections()
	{
	}

	private int FindFoodIndex(Character character)
	{
		return 0;
	}

	private List<Character> GetFoodAsCharacters()
	{
		return null;
	}

	private IEnumerator CompletePowerupAction(int skillPointsGranted, float startingLevel, float nextLevel, List<Reward> rewards, int gainedPrestige, bool wasPrestigeUnlocked)
	{
		return null;
	}

	private void RequestEvolution()
	{
	}

	private void RequestPowerUp(List<Character> foodCharacters)
	{
	}

	private void ConstructAndSendEvolutionActivityMessage()
	{
	}

	private bool CharacterFilter_CustomFilter(Character character)
	{
		return false;
	}

	private bool CharacterFilter_IsCharacterExcluded(Character character)
	{
		return false;
	}

	private bool CharacterFilter_IsDupe(Character character)
	{
		return false;
	}

	private bool AreCharactersShinyCompatible(Character targetCharacer, Character foodCharacter)
	{
		return false;
	}

	private bool AreCharactersPrestigeCompatible(Character targetCharacer, Character foodCharacter)
	{
		return false;
	}

	private void FinishUpgradeFlow(List<Reward> rewards, int gainedPrestige, bool wasPrestigeUnlocked)
	{
	}

	private void ShowPrestigeFanfareIfNeeded(int gainedPrestige, bool wasPrestigeUnlocked, Action callback)
	{
	}
}
