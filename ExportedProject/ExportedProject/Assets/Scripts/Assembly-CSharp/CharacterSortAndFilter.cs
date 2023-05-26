using System;
using System.Collections.Generic;

public class CharacterSortAndFilter : SortAndFilter<Character, CharacterSortAndFilter.FilterMask, CharacterSortAndFilter.SortBy>
{
	public enum FilterMask
	{
		All = 0,
		Bronze = 1,
		Silver = 2,
		Gold = 4,
		Diamond = 8,
		Fire = 16,
		Water = 32,
		Air = 64,
		Light = 128,
		Dark = 256,
		Neutral = 512,
		Locked = 1024,
		NewlyRewarded = 2048,
		Shiny = 4096,
		BigBand = 1073741824,
		Cerebella = 536870912,
		Eliza = 268435456,
		Filia = 134217728,
		Painwheel = 67108864,
		Parasoul = 33554432,
		Peacock = 16777216,
		Valentine = 8388608,
		Beowulf = 4194304,
		Double = 2097152,
		Squigly = 1048576,
		MsFortune = 524288,
		RoboFortune = 262144,
		Fukua = 131072,
		Annie = 65536,
		Umbrella = 32768,
		BlackDahlia = 16384
	}

	public enum SortBy
	{
		FighterScore = 0,
		Tier = 1,
		Alphabetical = 2,
		Element = 3,
		Level = 4,
		Energy = 5,
		Locked = 6,
		Timestamp = 7
	}

	private const int kAllTiers = 15;

	private const int kAllElements = 1008;

	private const int kAllCharacters = 2147467264;

	private static Dictionary<RarityTier, FilterMask> filterTier;

	private static Dictionary<Element, FilterMask> filterElement;

	private bool useCustomFilterFunction;

	private Func<Character, bool> customFilterFunction;

	private const SortBy kDefaultSort = SortBy.FighterScore;

	private const bool kDefaultAscending = false;

	public static int CompareByFighterScore(Character character1, Character character2)
	{
		return 0;
	}

	public static int CompareByShiny(Character character1, Character character2)
	{
		return 0;
	}

	public static int CompareByLocked(Character character1, Character character2)
	{
		return 0;
	}

	public static int CompareByEnergy(Character character1, Character character2)
	{
		return 0;
	}

	public static int CompareByTier(Character character1, Character character2)
	{
		return 0;
	}

	public static int CompareByLevel(Character character1, Character character2)
	{
		return 0;
	}

	public static int CompareByBaseName(Character character1, Character character2)
	{
		return 0;
	}

	public static int CompareByVariantName(Character character1, Character character2)
	{
		return 0;
	}

	public static int CompareByElement(Character character1, Character character2)
	{
		return 0;
	}

	public static int CompareByTimestamp(Character character1, Character character2)
	{
		return 0;
	}

	public override void Reset()
	{
	}

	public override List<Character> ApplyFilters(List<Character> unfiltered)
	{
		return null;
	}

	public void SetCustomFilterFunction(Func<Character, bool> customFilterFunction)
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

	public override List<Character> ApplySort(List<Character> unsorted)
	{
		return null;
	}

	public override List<Character> ApplySortSingle(List<Character> alreadySorted, Character unsorted)
	{
		return null;
	}

	public CharacterSortAndFilter()
	{
		((SortAndFilter<, , >)(object)this)._002Ector();
	}
}
