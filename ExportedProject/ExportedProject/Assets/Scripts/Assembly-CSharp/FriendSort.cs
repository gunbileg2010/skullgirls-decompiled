using System.Collections.Generic;

public class FriendSort : SortAndFilter<FriendInstance, FriendSort.FilterMask, FriendSort.SortBy>
{
	public enum FilterMask
	{
		All = 0
	}

	public enum SortBy
	{
		Alphabetical = 0,
		Level = 1,
		NumSent = 2,
		NumClaimed = 3,
		Timestamp = 4
	}

	private const SortBy kDefaultSort = SortBy.Alphabetical;

	private const bool kDefaultAscending = true;

	public override List<FriendInstance> ApplyFilters(List<FriendInstance> unfiltered)
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

	public override List<FriendInstance> ApplySort(List<FriendInstance> unsorted)
	{
		return null;
	}

	public override List<FriendInstance> ApplySortSingle(List<FriendInstance> alreadySorted, FriendInstance unsorted)
	{
		return null;
	}

	public static int CompareByPlayerHandle(FriendInstance friend1, FriendInstance friend2)
	{
		return 0;
	}

	public static int CompareByLevel(FriendInstance friend1, FriendInstance friend2)
	{
		return 0;
	}

	public static int CompareByGifts(FriendInstance friend1, FriendInstance friend2, bool sent = true)
	{
		return 0;
	}

	public static int CompareByTimestamp(FriendInstance friend1, FriendInstance friend2)
	{
		return 0;
	}

	public int CompareByPlayerHandleWithSortDir(FriendInstance friend1, FriendInstance friend2)
	{
		return 0;
	}

	public int CompareByLevelWithSubsort(FriendInstance friend1, FriendInstance friend2)
	{
		return 0;
	}

	public int CompareBySentWithSubsort(FriendInstance friend1, FriendInstance friend2)
	{
		return 0;
	}

	public int CompareByClaimedWithSubsort(FriendInstance friend1, FriendInstance friend2)
	{
		return 0;
	}

	public int CompareByTimestampWithSortDir(FriendInstance friend1, FriendInstance friend2)
	{
		return 0;
	}

	public FriendSort()
	{
		((SortAndFilter<, , >)(object)this)._002Ector();
	}
}
