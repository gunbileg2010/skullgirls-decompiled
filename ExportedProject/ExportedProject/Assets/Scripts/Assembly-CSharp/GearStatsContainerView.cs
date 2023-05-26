using UnityEngine;

public class GearStatsContainerView : MonoBehaviour
{
	[SerializeField]
	private Transform statsContainer;

	[SerializeField]
	private LocalizedUGUIText currentLevelText;

	[SerializeField]
	private Transform strengthMeter;

	[SerializeField]
	private Gradient strengthMeterEmptyGradient;

	[SerializeField]
	private LocalizedUGUIText damageTierText;

	[SerializeField]
	private LocalizedUGUIText rarityTierText;

	[SerializeField]
	private GameObject cooldownLabelGo;

	[SerializeField]
	private LocalizedUGUIText cooldownTimeText;

	[SerializeField]
	private CharacterStatView[] statsViews;

	[SerializeField]
	private LocalizedUGUIText abilityText;

	[SerializeField]
	private Color statColor;

	[SerializeField]
	private Color statUpdateColor;

	[SerializeField]
	private LocalizedUGUIText upgradeLevelText;

	[SerializeField]
	private LocalizedUGUIText specialMoveCooldownUpgradeText;

	[SerializeField]
	private Color beforeRerollTopColor;

	[SerializeField]
	private Color beforeRerollBottomColor;

	[SerializeField]
	private Color afterRerollTopColor;

	[SerializeField]
	private Color afterRerollBottomColor;

	[SerializeField]
	private Color statValueTopColor;

	[SerializeField]
	private Color statValueBottomColor;

	public void PopulateGearDetailsView(Gear gear, bool highlightDifferences = false)
	{
	}

	public void PopulateGearUpgradePopup(Gear gear)
	{
	}

	public void PopulateRerollStatsPopup(Gear gear)
	{
	}

	public void PopulateRerollStatResultsPopup(Gear gear)
	{
	}

	public void SetAlternateLineColors()
	{
	}

	public void SetSignatureAbilityText(Gear gear, SignatureAbility signatureAbility, bool isLocked, int unlockedLevel)
	{
	}

	public void SetCooldownTextsForSpecialMove(float currentLevelCooldown, float upgradedLevelCooldown)
	{
	}

	public void SetGearIconImage(Gear gear, GearCard gearCard, Transform iconAnchor, Character character, bool showLevelBadge, bool forceSetTint = false)
	{
	}

	private void SetSignatureAbility(Gear gear, GearData gearData)
	{
	}

	private void SetSignatureAbilityColorAndText(SignatureAbility signatureAbility, int level, Color textColor, Color digitsColor)
	{
	}

	private void SetSignatureAbilityForUpgradePopup(Gear gear, GearData gearData)
	{
	}

	private void SetAbilityTextActive(bool active)
	{
	}

	private void SetCooldown(float cooldown, bool active)
	{
	}

	private void SetUpgradedCooldown(float level, bool active)
	{
	}

	private void SetRarityTier(RarityTier gearTier)
	{
	}

	private void SetDamage(int gearLevel, GearData gearData, RarityTier gearTier, bool showEmptyStrengthMeter = false)
	{
	}

	private void SetLevelText(int level)
	{
	}

	private void SetUpgradeLevelText(int upgradedLevel)
	{
	}
}
