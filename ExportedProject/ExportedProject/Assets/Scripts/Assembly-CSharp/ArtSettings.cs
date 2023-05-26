using System;
using System.Collections.Generic;
using UnityEngine;

public class ArtSettings : ScriptableObject
{
	[Serializable]
	public class ElementAffiliationArt
	{
		public Element elementAffiliation;

		public Gradient cardBackgroundGradient;

		public Gradient sigilGradient;

		public Gradient textGradient;

		public Color hitsparkTint;

		public Color uiShinySparkleTint;

		public Sprite elementIcon;
	}

	[Serializable]
	public class SkillTreeNodeArt
	{
		public SkillTreeNodeType nodeType;

		public DynamicResource dynamicIconSprite;

		public Sprite iconSprite;

		public Sprite glowSprite;

		public Sprite frameSprite;
	}

	[Serializable]
	public class GearStrengthGradient
	{
		public GearDamageTier gearStrengthTier;

		public Gradient gradientColor;
	}

	[Serializable]
	public class ModifierIconArt
	{
		public ModifierType modifierType;

		public ModifierStrength modifierStrength;

		public Sprite modifierSprite;

		public Color ringColor;

		public Gradient statusTextGradient;
	}

	public Gradient bronzeGradient;

	public Gradient silverGradient;

	public Gradient goldGradient;

	public Gradient diamondGradient;

	[SerializeField]
	private Material bronzeMaterial;

	[SerializeField]
	private Material silverMaterial;

	[SerializeField]
	private Material goldMaterial;

	[SerializeField]
	private Material diamondAirMaterial;

	[SerializeField]
	private Material diamondWaterMaterial;

	[SerializeField]
	private Material diamondFireMaterial;

	[SerializeField]
	private Material diamondLightMaterial;

	[SerializeField]
	private Material diamondDarkMaterial;

	[SerializeField]
	private Material diamondNeutralMaterial;

	[SerializeField]
	private Material airElementMaterial;

	[SerializeField]
	private Material waterElementMaterial;

	[SerializeField]
	private Material fireElementMaterial;

	[SerializeField]
	private Material lightElementMaterial;

	[SerializeField]
	private Material darkElementMaterial;

	[SerializeField]
	private Color bronzeMoveTint;

	[SerializeField]
	private Color silverMoveTint;

	[SerializeField]
	private Color goldMoveTint;

	public Gradient basicGradient;

	public Gradient advancedGradient;

	public Gradient expertGradient;

	public Gradient masterGradient;

	public Gradient signatureAbilityStatusTextGradient;

	public Gradient debuffStatusTextGradient;

	[SerializeField]
	private ModifierIcon modifierIconPrefab;

	[SerializeField]
	private List<ModifierIconArt> modifierIconArt;

	public Gradient genericButtonGradient;

	public Gradient fightButtonGradient;

	public Gradient upgradeButtonGradient;

	public Gradient buyButtonGradient;

	public Gradient destroyButtonGradient;

	public Gradient playerNameGradient;

	public Gradient playerSummaryGradient;

	public Gradient seedTeamGradient;

	public Gradient developerGradient;

	public Gradient inFightNameGradient;

	public Sprite developerIcon;

	public Gradient orangeScoreUIGradient;

	public Gradient grayScoreUIGradient;

	public Gradient greenScoreUIGradient;

	public Gradient redScoreUIGradient;

	[SerializeField]
	private CurrencyDisplayUI currencyDisplayPrefab;

	[SerializeField]
	private Sprite[] keyIcons;

	[SerializeField]
	private Sprite hardCurrencyIconSmall;

	[SerializeField]
	private Sprite hardCurrencyIconLarge;

	[SerializeField]
	private Color hardCurrencyGlowColor;

	[SerializeField]
	private Gradient hardCurrencyTextGradient;

	[SerializeField]
	private Sprite softCurrencyIconSmall;

	[SerializeField]
	private Sprite softCurrencyIconLarge;

	[SerializeField]
	private Color softCurrencyGlowColor;

	[SerializeField]
	private Gradient softCurrencyTextGradient;

	[SerializeField]
	private Sprite essenceIconSmall;

	[SerializeField]
	private Sprite essenceIconLarge;

	[SerializeField]
	private Sprite essenceShardIconSmall;

	[SerializeField]
	private Sprite essenceShardIconLarge;

	[SerializeField]
	private Sprite silverGachaShardIconLarge;

	[SerializeField]
	private Sprite goldGachaShardIconLarge;

	[SerializeField]
	private Sprite diamondGachaShardIconLarge;

	[SerializeField]
	private Sprite battleCurrencyIconLarge;

	[SerializeField]
	private Sprite battleCurrencyIconSmall;

	[SerializeField]
	private Sprite battleTicketFreeIconLarge;

	[SerializeField]
	private Sprite battleTicketFreeIconSmall;

	[SerializeField]
	private Sprite battleTicketPaidIconLarge;

	[SerializeField]
	private Sprite battleTicketPaidIconSmall;

	[SerializeField]
	private Sprite dailyEventTicketIconLarge;

	[SerializeField]
	private Sprite dailyEventTicketIconSmall;

	[SerializeField]
	private Sprite socialGiftStandardIconLarge;

	[SerializeField]
	private Sprite socialGiftStandardIconSmall;

	[SerializeField]
	private Sprite socialGiftGoldIconLarge;

	[SerializeField]
	private Sprite socialGiftGoldIconSmall;

	[SerializeField]
	private Sprite energyRefillIconLarge;

	[SerializeField]
	private Sprite energyRefillIconSmall;

	[SerializeField]
	private Color energyRefillGlowColor;

	[SerializeField]
	private Gradient energyRefillTextGradient;

	[SerializeField]
	private Color battleCurrencyGlowColor;

	[SerializeField]
	private Gradient battleCurrencyGradient;

	[SerializeField]
	private Color battleTicketFreeGlowColor;

	[SerializeField]
	private Gradient battleTicketFreeGradient;

	[SerializeField]
	private Color battleTicketPaidGlowColor;

	[SerializeField]
	private Gradient battleTicketPaidGradient;

	[SerializeField]
	private Color dailyEventTicketGlowColor;

	[SerializeField]
	private Gradient dailyEventTicketTextGradient;

	[SerializeField]
	private Gradient socialGiftStandardGradient;

	[SerializeField]
	private Gradient socialGiftGoldGradient;

	[SerializeField]
	private Color socialGiftStandardColor;

	[SerializeField]
	private Color socialGiftGoldColor;

	[SerializeField]
	private Sprite universalRerollRuneIconLarge;

	[SerializeField]
	private Sprite universalRerollRuneIconSmall;

	public Color currentUpgradeColor;

	public Color possibleUpgradeColor;

	public Color nextUpgradeColor;

	public Gradient nextUpgradeGradient;

	public Gradient damageGradientNormal;

	public Gradient damageGradientFury;

	public Gradient damageGradientBlocked;

	public Gradient damageGradientRegen;

	public Gradient damageGradientBleed;

	public Gradient damageGradientCritical;

	public Gradient damageGradientElementalAdvantage;

	public Gradient damageGradientElementalDisadvantage;

	public Gradient damageGradientBarrier;

	public Color zoneLockedColor;

	public Color lightsLockedColor;

	[SerializeField]
	private List<ElementAffiliationArt> elementAffiliationArt;

	[SerializeField]
	private Sprite standardEnergyIcon;

	[SerializeField]
	private Gradient standardEnergyGradient;

	[SerializeField]
	private Sprite multiplayerEnergyIcon;

	[SerializeField]
	private Gradient multiplayerEnergyGradient;

	[SerializeField]
	private List<SkillTreeNodeArt> skillTreeNodeArt;

	public Color lockedColor;

	public Color unlockedColor;

	[SerializeField]
	private List<GearStrengthGradient> gearStrengthGradients;

	[SerializeField]
	private List<Sprite> timerNumberSprites;

	public Color chatHandleColor;

	public Color chatDevHandleColor;

	public Color chatStatusColor;

	public Color chatActivityColor;

	public Color socialOnlineRecentlyColor;

	public Color socialOnlineLongAgoColor;

	public Color socialOnlineNowColor;

	public Sprite rookieRatingBanner;

	public Sprite bronzeRatingBanner;

	public Sprite silverRatingBanner;

	public Sprite goldRatingBanner;

	public Sprite diamondRatingBanner;

	public Sprite rank3RatingBanner;

	public Sprite rank2RatingBanner;

	public Sprite rank1RatingBanner;

	public Color rookieRatingTextColor;

	public Color bronzeRatingTextColor;

	public Color silverRatingTextColor;

	public Color goldRatingTextColor;

	public Color diamondRatingTextColor;

	public Color rank3RatingTextColor;

	public Color rank2RatingTextColor;

	public Color rank1RatingTextColor;

	public Color rookieRatingTextShadowColor;

	public Color bronzeRatingTextShadowColor;

	public Color silverRatingTextShadowColor;

	public Color goldRatingTextShadowColor;

	public Color diamondRatingTextShadowColor;

	public Color rank3RatingTextShadowColor;

	public Color rank2RatingTextShadowColor;

	public Color rank1RatingTextShadowColor;

	public Color32 riftBattleAttackMapBackground;

	public Color32 riftBattleDefenseMapBackground;

	public Color versusThrowInvincibilityFlashColor;

	public float versusThrowInvincibilityIntensity;

	public DynamicResource prestigeAbilityVFX;

	public Color dailyEventExpirationColor;

	public Gradient bonusOfferHCGradient;

	private GameObjectPool<CurrencyDisplayUI> currencyObjectPool;

	private GameObjectPool<ModifierIcon> modifierIconPool;

	public Sprite GetSoftCurrencyIcon(bool large)
	{
		return null;
	}

	public Sprite GetHardCurrencyIcon(bool large)
	{
		return null;
	}

	public Sprite GetKeySprite(RarityTier tier)
	{
		return null;
	}

	public Sprite GetEssenceShardSprite(bool large)
	{
		return null;
	}

	public Sprite GetEssenceSprite(bool large)
	{
		return null;
	}

	public Sprite GetBattleCurrencyIcon(bool large)
	{
		return null;
	}

	public Sprite GetBattleTicketIcon(bool paid, bool large)
	{
		return null;
	}

	public Sprite GetDailyEventTicketIcon(bool large)
	{
		return null;
	}

	public Sprite GetSocialGiftIcon(bool isGold, bool large)
	{
		return null;
	}

	public Sprite GetEnergyRefillIcon(bool large)
	{
		return null;
	}

	public Color GetSocialGiftColor(bool isGold)
	{
		return default(Color);
	}

	public Sprite GetUniversalRerollRuneIcon(bool large)
	{
		return null;
	}

	public Material GetElementMaterial(Element element)
	{
		return null;
	}

	public Color GetElementColor(Element element)
	{
		return default(Color);
	}

	public Sprite GetGachaShardSprite(RarityTier tier, bool large)
	{
		return null;
	}

	public Color GetCurrencyGlowColor(CurrencyType currencyType, bool paid = false)
	{
		return default(Color);
	}

	public Gradient GetCurrencyGradientColor(CurrencyType currencyType, bool paid = false)
	{
		return null;
	}

	public Sprite GetEnergySprite(EnergyType energyType)
	{
		return null;
	}

	public Gradient GetEnergyGradient(EnergyType energyType)
	{
		return null;
	}

	public Gradient GetRiftBattleEnergyGradient(bool fullEnergy)
	{
		return null;
	}

	public Material GetTierMaterial(RarityTier tier, Element element = Element.Neutral)
	{
		return null;
	}

	public Gradient GetTierTextGradient(RarityTier tier)
	{
		return null;
	}

	public Color GetTierTextColor(RarityTier tier)
	{
		return default(Color);
	}

	public Gradient GetDifficultyGradient(Act.Difficulty difficulty)
	{
		return null;
	}

	public Color GetDifficultyColor(Act.Difficulty difficulty, float value = 0.5f)
	{
		return default(Color);
	}

	public Gradient GetPlayerNameGradient(bool isSeedTeam, bool isDeveloper, bool isPlayerSummary = false)
	{
		return null;
	}

	public Gradient GetInFightNameGraident()
	{
		return null;
	}

	public Color GetMoveIconTint(RarityTier tier)
	{
		return default(Color);
	}

	public Gradient GetButtonGradient(ButtonType type)
	{
		return null;
	}

	public ModifierIcon GetModifierIcon(ModifierType type, ModifierStrength strength = ModifierStrength.Normal)
	{
		return null;
	}

	public void ReturnModifierIcon(ModifierIcon modifierIcon)
	{
	}

	public Sprite GetModifierSprite(ModifierType type, ModifierStrength strength = ModifierStrength.Normal)
	{
		return null;
	}

	public Gradient GetModifierStatusTextGradient(ModifierType type)
	{
		return null;
	}

	public Gradient GetDamageTypeGradient(DamageType type)
	{
		return null;
	}

	public Gradient GetElementalCardGradient(Element elementAffiliation)
	{
		return null;
	}

	public Gradient GetElementalSigilGradient(Element elementAffiliation)
	{
		return null;
	}

	public Gradient GetElementalTextGradient(Element elementAffiliation)
	{
		return null;
	}

	public Sprite GetElementalSprite(Element elementAffiliation)
	{
		return null;
	}

	public Color GetElementalHitsparkTint(Element elementAffiliation)
	{
		return default(Color);
	}

	public Color GetElementalUIShinyTint(Element elementAffiliation)
	{
		return default(Color);
	}

	public SkillTreeNodeArt GetArtForSkillTreeNodeType(SkillTreeNodeType nodeType)
	{
		return null;
	}

	public CurrencyDisplayUI TakeCurrencyDisplayUI()
	{
		return null;
	}

	public void ReturnCurrencyDisplayUI(CurrencyDisplayUI currencyDisplayUI)
	{
	}

	public Gradient GetGearStrengthGradient(GearDamageTier damageTier)
	{
		return null;
	}

	public Sprite GetNumberSprite(int number)
	{
		return null;
	}

	public Sprite GetRiftBattleRankBanner(RiftTier labTier)
	{
		return null;
	}

	public Color GetRiftBattleRankTextColor(RiftTier labTier)
	{
		return default(Color);
	}

	public Color GetRiftBattleRankTextShadowColor(RiftTier labTier)
	{
		return default(Color);
	}

	private ModifierIconArt GetArtForModifierIconType(ModifierType modifierType, ModifierStrength strength = ModifierStrength.Normal)
	{
		return null;
	}

	private CurrencyDisplayUI CreateCurrencyDisplayUI()
	{
		return null;
	}

	private ModifierIcon GetModifierIcon()
	{
		return null;
	}
}
