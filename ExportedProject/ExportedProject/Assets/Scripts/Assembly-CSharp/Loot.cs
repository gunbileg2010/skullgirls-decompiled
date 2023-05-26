using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Loot
{
	[SerializeField]
	private LootType lootType;

	[SerializeField]
	private int amount;

	[SerializeField]
	private GearData gear;

	[SerializeField]
	private VariantCharacterData character;

	[SerializeField]
	private GachaData reel;

	[SerializeField]
	private ConsumableData consumable;

	[SerializeField]
	private BaseCharacterData baseCharacter;

	[SerializeField]
	private RarityTier rarityTier;

	[SerializeField]
	private Element elementType;

	[SerializeField]
	private CollectibleNodeModifierData nodeModifier;

	[SerializeField]
	private int voucherDenomination;

	[SerializeField]
	private LootTable nestedLootTable;

	public static Loot CreateHardCurrencyLoot(int amount)
	{
		return null;
	}

	public static Loot CreateSoftCurrencyLoot(int amount)
	{
		return null;
	}

	public static Loot CreateKeyLoot(RarityTier tier, int amount)
	{
		return null;
	}

	public static Loot CreateGachaShardLoot(RarityTier tier, int amount)
	{
		return null;
	}

	public static Loot CreateEssenceLoot(Element element, int amount)
	{
		return null;
	}

	public static Loot CreateEssenceShardLoot(Element element, int amount)
	{
		return null;
	}

	public static Loot CreateBattleCurrencyLoot(int amount)
	{
		return null;
	}

	public static Loot CreateBattleTicketLoot(bool paid, int amount)
	{
		return null;
	}

	public static Loot CreateDailyEventTicketLoot(int amount)
	{
		return null;
	}

	public static Loot CreateGachaVoucherLoot(GachaData voucherContext, int denomination, int amount)
	{
		return null;
	}

	public static Loot CreateSocialGiftLoot(bool isGold, int amount)
	{
		return null;
	}

	public static Loot CreateEnergyRefillLoot(int amount)
	{
		return null;
	}

	public static Loot CreateCharacterGachaShardLoot(int amount)
	{
		return null;
	}

	public static Loot CreateUniversalRerollRuneLoot(int amount)
	{
		return null;
	}

	public Loot()
	{
	}

	public Loot(LootType lootType, BaseCharacterData baseData, int amount = 1)
	{
	}

	public Loot(VariantCharacterData characterData)
	{
	}

	public Loot(GearData gearData)
	{
	}

	public Loot(GachaData gachaData, int amount = 1)
	{
	}

	public Loot(ConsumableData consumableData, int amount = 1)
	{
	}

	public Loot(LootTable lootTable)
	{
	}

	public Loot(CollectibleNodeModifierData nodeModifier, BaseCharacterData baseCharacter = null, Element elementType = Element.Neutral)
	{
	}

	public LootType GetLootType()
	{
		return default(LootType);
	}

	public int GetAmount()
	{
		return 0;
	}

	public VariantCharacterData GetVariantCharacter()
	{
		return null;
	}

	public GearData GetGearData()
	{
		return null;
	}

	public GachaData GetGachaData()
	{
		return null;
	}

	public ConsumableData GetConsumableData()
	{
		return null;
	}

	public LootTable GetLootTable()
	{
		return null;
	}

	public BaseCharacterData GetBaseCharacter()
	{
		return null;
	}

	public CollectibleNodeModifierData GetCollectibleNodeModifierData()
	{
		return null;
	}

	public RarityTier GetRarityTier()
	{
		return default(RarityTier);
	}

	public Element GetElementType()
	{
		return default(Element);
	}

	public int GetVoucherDenomination()
	{
		return 0;
	}

	public string GetVoucherDenominationString()
	{
		return null;
	}

	public bool VoucherStringNeedsPluralRelicName()
	{
		return false;
	}

	public string GetMetricsGUID()
	{
		return null;
	}

	public Color GetGlowColor()
	{
		return default(Color);
	}

	public Sprite GetIcon(bool large = true)
	{
		return null;
	}

	public Material GetIconMaterial()
	{
		return null;
	}

	public RewardItem.DisplayOptions GetDisplayOptionsForRewardItem()
	{
		return null;
	}

	public Dictionary<string, object> ToDictionary(Price price = null)
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public string GetDescription(bool includeAmount = true, bool isRandom = false, bool? overridePlural = null)
	{
		return null;
	}

	public string GetTooltipHeader()
	{
		return null;
	}

	public string GetTooltipBody()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public static bool SplitVoucherGuid(string input, out int voucherDenomination, out string gachaGuid)
	{
		voucherDenomination = default(int);
		gachaGuid = null;
		return false;
	}

	public void CleanUp()
	{
	}

	private string FormDescriptionOrHeaderForEssence(CurrencyType essenceType, int amount = 10)
	{
		return null;
	}
}
