using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public abstract class SortAndFilter<T, U, V> where U : IConvertible where V : IConvertible
{
	private static Dictionary<BaseCharacterData, U> characterToFilterMaskDict;

	protected int currentFilterMask;

	private int disabledFilterMask;

	protected V currentSort;

	protected const bool kHighToLow = false;

	protected const bool kAToZ = true;

	protected Dictionary<V, bool> sortAscending;

	public event Action SortAndFilterChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static U GetFilterMaskForBaseCharacter(BaseCharacterData baseCharacterData)
	{
		return default(U);
	}

	public SortAndFilter()
	{
	}

	public virtual void Reset()
	{
	}

	public virtual void AddFilter(U mask)
	{
	}

	public virtual void RemoveFilter(U mask)
	{
	}

	public virtual void ResetFilter()
	{
	}

	public virtual bool IsFiltered(U mask)
	{
		return false;
	}

	public virtual bool IsAnyFiltered()
	{
		return false;
	}

	public void ClearDisabledFilters()
	{
	}

	public void AddDisabledFilter(U mask)
	{
	}

	public bool IsFilterDisabled(U mask)
	{
		return false;
	}

	public abstract List<T> ApplyFilters(List<T> unfiltered);

	public virtual void SetSort(V sortBy)
	{
	}

	public virtual bool IsAscending(V sortBy)
	{
		return false;
	}

	public virtual V GetCurrentSort()
	{
		return default(V);
	}

	public abstract bool IsUsingDefaultSort();

	public abstract void ResetSort();

	public abstract List<T> ApplySort(List<T> unsorted);

	public abstract List<T> ApplySortSingle(List<T> alreadySorted, T unsorted);

	public List<T> ApplySortAndFilters(List<T> unsortedAndUnfiltered)
	{
		return null;
	}

	public List<T> InsertIntoSortedAndFilteredList(List<T> alreadySortedAndFiltered, T unfilteredAndUnsorted)
	{
		return null;
	}

	protected void RaiseSortAndFilterChanged()
	{
	}

	protected List<T> PerformSort(Func<T, T, int> func, bool ascending, List<T> unsorted)
	{
		return null;
	}
}
