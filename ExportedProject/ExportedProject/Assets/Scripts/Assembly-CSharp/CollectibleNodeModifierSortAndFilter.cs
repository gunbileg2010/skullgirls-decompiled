using System;
using System.Collections.Generic;

public class CollectibleNodeModifierSortAndFilter : SortAndFilter<CollectibleNodeModifier, CollectibleNodeModifierSortAndFilter.FilterMask, CollectibleNodeModifierSortAndFilter.SortBy>
{
	public enum FilterMask
	{
		All = 0,
		Bronze = 1,
		Silver = 2,
		Gold = 4,
		Fire = 8,
		Water = 0x10,
		Air = 0x20,
		Light = 0x40,
		Dark = 0x80,
		Neutral = 0x100,
		BigBand = 0x200,
		Cerebella = 0x400,
		Eliza = 0x800,
		Filia = 0x1000,
		Painwheel = 0x2000,
		Parasoul = 0x4000,
		Peacock = 0x8000,
		Valentine = 0x10000,
		Beowulf = 0x20000,
		Double = 0x40000,
		Squigly = 0x80000,
		MsFortune = 0x100000,
		RoboFortune = 0x200000,
		Fukua = 0x400000,
		Annie = 0x800000,
		Umbrella = 0x1000000,
		BlackDahlia = 0x2000000,
		Locked = 0x4000000,
		Unlocked = 0x8000000,
		NewlyRewarded = 0x10000000,
		PreviouslyRewarded = 0x20000000
	}

	public enum SortBy
	{
		Tier = 0,
		Alphabetical = 1,
		Level = 2,
		InUse = 3,
		Locked = 4,
		Timestamp = 5
	}

	private const int kAllTiers = 7;

	private const int kAllElements = 504;

	private const int kAllCharacters = 67108352;

	private const int kAllLockStates = 201326592;

	private const int kAllTemporalStates = 805306368;

	private static Dictionary<RarityTier, FilterMask> filterTier;

	private static Dictionary<Element, FilterMask> filterElement;

	private bool useCustomFilterFunction;

	private Func<CollectibleNodeModifier, bool> customFilterFunction;

	private const SortBy kDefaultSort = SortBy.Level;

	private const bool kDefaultAscending = false;

	public static int CompareByTier(CollectibleNodeModifier nodeModifier1, CollectibleNodeModifier nodeModifier2)
	{
		return 0;
	}

	public static int CompareByLevel(CollectibleNodeModifier nodeModifier1, CollectibleNodeModifier nodeModifier2)
	{
		return 0;
	}

	public static int CompareByLocked(CollectibleNodeModifier nodeModifier1, CollectibleNodeModifier nodeModifier2)
	{
		return 0;
	}

	public static int CompareByName(CollectibleNodeModifier nodeModifier1, CollectibleNodeModifier nodeModifier2)
	{
		return 0;
	}

	public static int CompareByInUse(CollectibleNodeModifier nodeModifier1, CollectibleNodeModifier nodeModifier2)
	{
		return 0;
	}

	public static int CompareByTimestamp(CollectibleNodeModifier nodeModifier1, CollectibleNodeModifier nodeModifier2)
	{
		return 0;
	}

	public override void Reset()
	{
	}

	public override List<CollectibleNodeModifier> ApplyFilters(List<CollectibleNodeModifier> unfiltered)
	{
		return null;
	}

	public void SetCustomFilterFunction(Func<CollectibleNodeModifier, bool> customFilterFunction)
	{
	}

	public void SetUseCustomFilterFunction(bool use)
	{
	}

	public bool IsUsingCustomFilterFunction()
	{
		return false;
	}

	public override bool IsUsingDefaultSort()
	{
		return false;
	}

	public override void ResetSort()
	{
	}

	public override List<CollectibleNodeModifier> ApplySort(List<CollectibleNodeModifier> unsorted)
	{
		return null;
	}

	public override List<CollectibleNodeModifier> ApplySortSingle(List<CollectibleNodeModifier> alreadySorted, CollectibleNodeModifier unsorted)
	{
		return null;
	}

	public CollectibleNodeModifierSortAndFilter()
	{
		((SortAndFilter<, , >)(object)this)._002Ector();
	}
}
