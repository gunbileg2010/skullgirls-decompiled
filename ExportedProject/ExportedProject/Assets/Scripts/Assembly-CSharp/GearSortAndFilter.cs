using System.Collections.Generic;

public class GearSortAndFilter : SortAndFilter<Gear, GearSortAndFilter.FilterMask, GearSortAndFilter.SortBy>
{
	public enum FilterMask
	{
		All = 0,
		Bronze = 1,
		Silver = 2,
		Gold = 4,
		Blockbuster = 8,
		Special = 0x10,
		BigBand = 0x20,
		Cerebella = 0x40,
		Eliza = 0x80,
		Filia = 0x100,
		Painwheel = 0x200,
		Parasoul = 0x400,
		Peacock = 0x800,
		Valentine = 0x1000,
		Beowulf = 0x2000,
		Double = 0x4000,
		Squigly = 0x8000,
		MsFortune = 0x10000,
		RoboFortune = 0x20000,
		Fukua = 0x40000,
		Annie = 0x80000,
		Umbrella = 0x100000,
		BlackDahlia = 0x200000,
		Locked = 0x400000,
		Unlocked = 0x800000,
		NewlyRewarded = 0x1000000,
		PreviouslyRewarded = 0x2000000
	}

	public enum SortBy
	{
		Level = 0,
		Tier = 1,
		Type = 2,
		Alphabetical = 3,
		Equipped = 4,
		Locked = 5,
		Timestamp = 6
	}

	private const int kAllTiers = 7;

	private const int kAllTypes = 24;

	private const int kAllCharacters = 4194272;

	private const int kAllLockStates = 12582912;

	private const int kAllTemporalStates = 50331648;

	private static Dictionary<RarityTier, FilterMask> filterTier;

	private static Dictionary<GearType, FilterMask> filterType;

	private const SortBy kDefaultSort = SortBy.Level;

	private const bool kDefaultAscending = false;

	public static int CompareByLevel(Gear gear1, Gear gear2)
	{
		return 0;
	}

	public static int CompareByTier(Gear gear1, Gear gear2)
	{
		return 0;
	}

	public static int CompareByCharacterName(Gear gear1, Gear gear2)
	{
		return 0;
	}

	public static int CompareByLocked(Gear gear1, Gear gear2)
	{
		return 0;
	}

	public static int CompareByGearName(Gear gear1, Gear gear2)
	{
		return 0;
	}

	public static int CompareByGearType(Gear gear1, Gear gear2)
	{
		return 0;
	}

	public static int CompareByEquipped(Gear gear1, Gear gear2)
	{
		return 0;
	}

	public static int CompareByTimestamp(Gear gear1, Gear gear2)
	{
		return 0;
	}

	public override List<Gear> ApplyFilters(List<Gear> unfiltered)
	{
		return null;
	}

	public override bool IsUsingDefaultSort()
	{
		return false;
	}

	public override void ResetSort()
	{
	}

	public override List<Gear> ApplySort(List<Gear> unsorted)
	{
		return null;
	}

	public override List<Gear> ApplySortSingle(List<Gear> alreadySorted, Gear unsorted)
	{
		return null;
	}

	private int CompareByLevelWithSubsorts(Gear gear1, Gear gear2)
	{
		return 0;
	}

	private int CompareAlphabeticalWithSubsorts(Gear gear1, Gear gear2)
	{
		return 0;
	}

	private int CompareByTierWithSubsorts(Gear gear1, Gear gear2)
	{
		return 0;
	}

	private int CompareByTypeWithSubsorts(Gear gear1, Gear gear2)
	{
		return 0;
	}

	private int CompareByEquippedWithSubsorts(Gear gear1, Gear gear2)
	{
		return 0;
	}

	private int CompareByLockedWithSubsorts(Gear gear1, Gear gear2)
	{
		return 0;
	}

	private int CompareByTimestampWithSubsorts(Gear gear1, Gear gear2)
	{
		return 0;
	}

	public GearSortAndFilter()
	{
		((SortAndFilter<, , >)(object)this)._002Ector();
	}
}
