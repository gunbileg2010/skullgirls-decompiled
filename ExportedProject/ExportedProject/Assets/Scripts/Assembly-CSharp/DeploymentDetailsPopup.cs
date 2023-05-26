using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeploymentDetailsPopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private AdvancedButton assignButton;

	[SerializeField]
	private RecycledScrollList portraitRecycledScrollList;

	[SerializeField]
	private MapNodeGraphics singleMapNode;

	[SerializeField]
	private MapNodeGraphics doubleMapNode;

	[SerializeField]
	private MapNodeGraphics tripleMapNode;

	[SerializeField]
	private List<FightConstraintUI> constraintIcons;

	[SerializeField]
	private LocalizedUGUIText titleText;

	[SerializeField]
	private LocalizedUGUIText flavorText;

	[SerializeField]
	private LocalizedUGUIText durationText;

	[SerializeField]
	private LocalizedUGUIText xpText;

	[SerializeField]
	private RewardItem rewardItem;

	[SerializeField]
	private Slider bonusChanceSlider;

	[SerializeField]
	private LocalizedUGUIText bonusChancePercentage;

	[SerializeField]
	private PopupData sortAndFilterPopupData;

	[SerializeField]
	private Toggle availableToggle;

	[SerializeField]
	private GameObject activeFilterSortGlowGO;

	[SerializeField]
	private ContextualTutorial detailsContextualTutorial;

	private CharacterSortAndFilter characterSortAndFilter;

	private List<Character> characterCollection;

	private List<Character> filteredAndSortedCharacterCollection;

	private Stack<CharacterPortrait> availablePortraits;

	private DeploymentItem deploymentItem;

	private DeploymentServerData deployment;

	private MapNodeGraphics activeMapNodeGraphics;

	private Character[] charactersToAssign;

	private string[] charactersIdsToAssign;

	private List<ConstraintPair> cachedBonusConstraints;

	private ContextualPopupItem contextualPopup;

	private EZAnimOptions sliderAnimOptions;

	protected override void Awake()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_FilterSortButtonClicked()
	{
	}

	public void UGUI_BonusConstraintPressed(int index)
	{
	}

	public void UGUI_AvailableTogglePressed(bool on)
	{
	}

	public void UGUI_MapNodeGraphicPressed(int index)
	{
	}

	protected override void ButtonPressed(int index)
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

	private void OnCharacterPortraitClicked(CharacterPortrait portrait)
	{
	}

	private int? GetNextOpenSlot()
	{
		return null;
	}

	private void SetFilterToTierConstraint()
	{
	}

	private void CalculateBonusChance()
	{
	}

	private void AnimateSlider(float toValue)
	{
	}
}
