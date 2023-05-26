using UnityEngine;
using UnityEngine.UI;

public class CharacterCard : Card
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private UIGradientMapped backgroundGradientMap;

	[SerializeField]
	private Button cardButton;

	[SerializeField]
	private CharacterCardRarityElement[] rarityUIElements;

	[SerializeField]
	private UISheen frameSheen;

	[SerializeField]
	private GameObject glowGO;

	[SerializeField]
	private PalettizedUIImage characterImage;

	[SerializeField]
	private RectTransform elementFrameParent;

	[SerializeField]
	private Vector2 diamondElementFrameOffset;

	[SerializeField]
	private LocalizedUGUIText nameText;

	[SerializeField]
	private LocalizedUGUIText variantNameText;

	[SerializeField]
	private Text levelText;

	[SerializeField]
	private GameObject fighterScoreGO;

	[SerializeField]
	private Text fighterScoreText;

	[SerializeField]
	private GameObject energyGO;

	[SerializeField]
	private Image[] energyImages;

	[SerializeField]
	private Sprite emptyEnergySprite;

	[SerializeField]
	private Image refillingEnergyImage;

	[SerializeField]
	private ElementAffiliationUI elementAffiliationUI;

	[SerializeField]
	private GameObject behindLevelBadgeGlow;

	[SerializeField]
	private Color defaultLevelTextColor;

	[SerializeField]
	private Color evolutionReadyLevelTextColor;

	[SerializeField]
	private LocalizedUGUIText infoBannerText;

	[SerializeField]
	private GameObject infoBannerGO;

	[SerializeField]
	private GameObject battleEnergyGO;

	[SerializeField]
	private Image[] battleUsePips;

	[SerializeField]
	private GameObject generalAlertGO;

	public const string kInUseKey = "Character_InUse";

	public const string kNoBonusKey = "Key_NoBonus";

	[SerializeField]
	private UIShinyEffect uiShinyEffect;

	private const int kCharacterImageAboveSiblingIndex = 4;

	private const int kCharacterImageBelowSiblingIndex = 3;

	private Character myCharacter;

	private void Update()
	{
	}

	public void PopulateFromCharacter(Character character)
	{
	}

	public override void Clear()
	{
	}

	public void SetClickable(bool clickable)
	{
	}

	public void SetGlow(bool glow)
	{
	}

	public void SetFade(bool isFaded = true, float value = 0.4f)
	{
	}

	public void SetFade(Color color)
	{
	}

	public void SetRarityTier(RarityTier tier)
	{
	}

	public void SetFighterScoreVisible(bool visible)
	{
	}

	public void SetEnergyVisible(bool visible)
	{
	}

	public void SetRiftBattleEnergyVisible(bool visible, int timesUsed = 0)
	{
	}

	public void SetShowingXpOverlay(bool isShowingXpOverlay)
	{
	}

	public void SetInfoBanner(string infoKey)
	{
	}

	public void SetRewardDisplay()
	{
	}

	public void SetCompetitiveDisplay()
	{
	}

	public void RefreshDisplayedStatsFromMockData(int level)
	{
	}

	public void OverrideFighterScore(int fighterScore)
	{
	}

	public Character GetCharacter()
	{
		return null;
	}

	public void ShowElementAffiliationAdvantagesDisadvantages(Fight currentFight)
	{
	}

	public void SetEvolutionTeaseVisibility(bool shouldShow, bool force = false)
	{
	}

	public void UGUI_CardButtonPress()
	{
	}

	public void ForceFrameSheenOff()
	{
	}

	public void SetShinyStatus(bool onOff, Element? elementOverride = null)
	{
	}

	public void ToggleGeneralAlert(bool active)
	{
	}

	private void RefreshImage()
	{
	}

	private void RefreshEnergyBars()
	{
	}
}
