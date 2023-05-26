using System;
using System.Collections.Generic;
using UnityEngine;

public class EconomySettings : ScriptableObject, IServerUploadable
{
	[Serializable]
	public class LevelUpReward
	{
		public int level;

		public List<Loot> loots;
	}

	[Serializable]
	public struct ThresholdReward
	{
		public List<Loot> loots;
	}

	[SerializeField]
	private List<Loot> startingLoot;

	public int fightBaseSoftCurrencyReward;

	[SerializeField]
	private List<LevelUpReward> playerLevelUpRewards;

	public const int kMaxEgretPoints = 100;

	[SerializeField]
	private List<ThresholdReward> challengesThresholdRewards;

	[SerializeField]
	private int[] characterDupeShardsPerTier;

	[SerializeField]
	private int essenceShardsPerEssence;

	public int gearCollectionSoftCap;

	public int gearCollectionFinalSoftCap;

	public Price gearCollectionExpansionCost;

	public int gearCollectionExpansionAmount;

	public int characterCollectionSoftCap;

	public int characterCollectionFinalSoftCap;

	public int characterCollectionExpansionAmount;

	public Price characterCollectionExpansionCost;

	public int socialGiftRewardCap;

	public int collectionHardCapDelta;

	public int nodeModifierCollectionSoftCap;

	public int nodeModifierCollectionFinalSoftCap;

	public Price nodeModifierCollectionExpansionCost;

	public int nodeModifierCollectionExpansionAmount;

	public int[] specialEvolutionCosts;

	public int[] specialEvolutionCostsTierMultiplier;

	[SerializeField]
	private int[] baseGearSalePricePerTier;

	public float gearSalePercent;

	[SerializeField]
	private int[] nodeModifierUpgradeCosts;

	[SerializeField]
	private int[] nodeModifierUpgradeCostsTierMultiplier;

	[SerializeField]
	private int[] baseNodeModifierSalePricePerTier;

	[SerializeField]
	private float nodeModifierSalePercent;

	[SerializeField]
	private List<int> cardsRequiredForEvolutionByTier;

	[SerializeField]
	private List<Price> priceForEvolutionByTier;

	[SerializeField]
	private int[] evolveMaxGearPointsIncreases;

	public int elementalEssenceConversionCount;

	public int skillPointConversionCount;

	public int gachaShardConversionCount;

	[SerializeField]
	private int[] skillNodeSCCostTierMultipliers;

	[SerializeField]
	private int[] skillNodeHCCostTierMultipliers;

	[SerializeField]
	private int[] superAbilityCostTierMultipliers;

	[SerializeField]
	private Price superAbilityUnlockCost;

	[SerializeField]
	private Price superAbilityUpgradeCost;

	[SerializeField]
	private Price superAbilitySwapCost;

	public int skillPointsOnCharacterLevelUp;

	[SerializeField]
	private int[] skillPointTierMultipliers;

	public int energyRefillCost;

	public List<LootTable.WeightedLoot> versusRandomDropLoot;

	public List<LootTable.WeightedLoot> socialGiftsRandomDropLoot;

	[SerializeField]
	private int adPacingDurationMinutes;

	[SerializeField]
	private int maxNumberOfAdsPerDay;

	[SerializeField]
	private List<float> feedingXpByTier;

	[SerializeField]
	private float feedingMultiplierOfTotalXp;

	[SerializeField]
	private float feedingMultiplierForSameElement;

	[SerializeField]
	private float feedingMultiplierForSameBaseCharacter;

	[SerializeField]
	private int feedingCardLimit;

	[SerializeField]
	private List<Loot> loginRewardCalendar;

	[SerializeField]
	private List<RewardCalendar> rewardCalendars;

	[SerializeField]
	private float globalOfferPopupCooldownHours;

	public Currency refreshLeaderboardEventFightCost;

	public Price restoreLeaderboardStreakCostPerStreak;

	public Price changeHandleCost;

	public Price paidBattleTicketCost;

	public int maxFreeBattleTickets;

	public int battleOpponentRefreshCost;

	public int battleHoursBetweenFreeRefreshes;

	public List<LootTable.WeightedLoot> battleDefeatAllOpponentsLoots;

	public int maxDailyEventTickets;

	public int claimableDailyEventTicketsPerDay;

	public Price playDailyEventPrice;

	public Price skipDailyEventPrice;

	public Price directPurchaseRefreshCost;

	public int directPurchaseRefreshTimeSeconds;

	public LootTable directPurchaseGeneralLootTable;

	public int directPurchaseGeneralLootCount;

	public DirectPurchaseUploadTabInfo[] directPurchasePossibleTabs;

	public string[] directPurchaseTabsToShow;

	public MailRewardFilter[] mailRewardFilters;

	public BaseCharacterData featuredGachaCharacter;

	[SerializeField]
	private List<Loot> characterGachaShardConversionRate;

	public Sprite characterGachaShardIcon;

	public int rerollMoveStatCost;

	public ConsumableData xpBoostTutorialReward;

	public int xpBoostTutorialRewardAmount;

	private Dictionary<string, DirectPurchaseTabInfo> directPurchaseTabsDictionary;

	public int GetGearSalePrice(RarityTier tier, int level)
	{
		return 0;
	}

	public int GetBaseGearSalePriceForTier(RarityTier tier)
	{
		return 0;
	}

	public int GetGearUpgradeCost(int evolveTo)
	{
		return 0;
	}

	public int GetNodeModifierSalePrice(RarityTier tier, int level)
	{
		return 0;
	}

	public int GetBaseNodeModifierSalePriceForTier(RarityTier tier)
	{
		return 0;
	}

	public int GetNodeModifierUpgradeCost(int upgradeTo)
	{
		return 0;
	}

	public Price GetSuperAbilitySwapCost()
	{
		return null;
	}

	public Price GetSuperAbilityUnlockCost()
	{
		return null;
	}

	public Price GetSuperAbilityUpgradeCost()
	{
		return null;
	}

	public int GetCharacterLevelUpSkillPoints(RarityTier tier)
	{
		return 0;
	}

	public int GetSkillPointMultiplier(RarityTier tier)
	{
		return 0;
	}

	public int GetSkillNodeSCCostTierMultiplier(RarityTier tier)
	{
		return 0;
	}

	public int GetSkillNodeHCCostTierMultiplier(RarityTier tier)
	{
		return 0;
	}

	public int GetGearEvolutionCostTierMultiplier(RarityTier tier)
	{
		return 0;
	}

	public int GetNodeModifierUpgradeCostTierMultiplier(RarityTier tier)
	{
		return 0;
	}

	public int GetSuperAbilityCostTierMultiplier(RarityTier tier)
	{
		return 0;
	}

	public int GetGearPointIncreaseForEvolvingFrom(RarityTier tier)
	{
		return 0;
	}

	public int GetChallengesRewardThresholdCount()
	{
		return 0;
	}

	public int GetFeedingCardLimit()
	{
		return 0;
	}

	public int GetCardCountRequiredForEvolution(RarityTier fromTier)
	{
		return 0;
	}

	public Price GetEvolutionPrice(RarityTier fromTier)
	{
		return null;
	}

	public long CalculateFeedingXp(VariantCharacterData variantBeingFed, Character foodCharacter, out float baseXp, out float sameElementXpBonus, out float sameBaseCharacterXpBonus)
	{
		baseXp = default(float);
		sameElementXpBonus = default(float);
		sameBaseCharacterXpBonus = default(float);
		return 0L;
	}

	public int CalculateFeedingSkillPoints(Character foodCharacter)
	{
		return 0;
	}

	public int GetEssenceShardsPerEssence()
	{
		return 0;
	}

	public RewardCalendar GetRewardCalendarByGuid(string guid)
	{
		return null;
	}

	public List<Loot> GetChallengesRewardsForThreshold(int thresholdIndex)
	{
		return null;
	}

	public float GetGlobalOfferPopupCooldownHours()
	{
		return 0f;
	}

	public void SetGlobalOfferPopupCooldownHours(float globalOfferPopupCooldownHours)
	{
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public DirectPurchaseTabInfo GetDirectPurchaseTabInfo(string mappingName)
	{
		return null;
	}

	private float GetFeedingBaseXpFromTier(RarityTier tier)
	{
		return 0f;
	}

	private List<object> WeightedLootListToServerUploadData(List<LootTable.WeightedLoot> loots)
	{
		return null;
	}

	public int GetMaxNumberOfAdsPerDay()
	{
		return 0;
	}

	public void SetMaxNumberOfAdsPerDay(int maxNumberOfAdsPerDay)
	{
	}
}
