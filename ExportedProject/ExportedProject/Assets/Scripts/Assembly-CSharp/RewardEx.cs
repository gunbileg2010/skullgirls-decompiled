using System;
using System.Collections.Generic;

public static class RewardEx
{
	public static int GetTotalHardCurrency(this List<Reward> list)
	{
		return 0;
	}

	public static int GetTotalSoftCurrency(this List<Reward> list)
	{
		return 0;
	}

	public static int GetTotalBattleCurrency(this List<Reward> list)
	{
		return 0;
	}

	public static int GetTotalKeys(this List<Reward> list, RarityTier tier)
	{
		return 0;
	}

	public static int GetTotalSkillPoints(this List<Reward> list, BaseCharacterData baseData)
	{
		return 0;
	}

	public static int GetTotalGachaShards(this List<Reward> list, RarityTier tier)
	{
		return 0;
	}

	public static int GetTotalEssence(this List<Reward> list, Element element, bool shards)
	{
		return 0;
	}

	public static int GetTotalRerollRunes(this List<Reward> list, BaseCharacterData baseData)
	{
		return 0;
	}

	public static int GetTotalAmount(this List<Reward> list, LootType type)
	{
		return 0;
	}

	public static void Process(this List<Reward> list, LootType lootType, Action<Reward> callback)
	{
	}

	private static int GetAmountOfType(List<Reward> list, LootType type, object context = null)
	{
		return 0;
	}

	private static int GetAmountOfType(Reward reward, LootType type, object context = null)
	{
		return 0;
	}

	private static void Process(Reward reward, LootType lootType, Action<Reward> callback)
	{
	}
}
