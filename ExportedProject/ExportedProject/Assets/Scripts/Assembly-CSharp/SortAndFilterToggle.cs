using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SortAndFilterToggle : MonoBehaviour
{
	public enum ToggleType
	{
		Filter = 0,
		Sort = 1
	}

	public delegate void OnSortToggled(Toggle toggle, bool isAscending);

	[SerializeField]
	private ToggleType toggleType;

	[SerializeField]
	private Toggle toggle;

	[SerializeField]
	private BaseCharacterData baseCharacter;

	[SerializeField]
	private GameObject filterGroupParent;

	[SerializeField]
	private bool enabledForCharacter;

	[SerializeField]
	private CharacterSortAndFilter.FilterMask characterFilterMask;

	[SerializeField]
	private CharacterSortAndFilter.SortBy characterSortBy;

	[SerializeField]
	private bool enabledForGear;

	[SerializeField]
	private GearSortAndFilter.FilterMask gearFilterMask;

	[SerializeField]
	private GearSortAndFilter.SortBy gearSortBy;

	[SerializeField]
	private bool enabledForCollectibleNodes;

	[SerializeField]
	private CollectibleNodeModifierSortAndFilter.FilterMask collectibleNodeFilterMask;

	[SerializeField]
	private CollectibleNodeModifierSortAndFilter.SortBy collectibleNodeSortBy;

	[SerializeField]
	private bool enabledForFriends;

	[SerializeField]
	private FriendSort.SortBy friendSortBy;

	private bool blockUGUICallbacks;

	private CharacterSortAndFilter cachedCharacterSortAndFilter;

	private GearSortAndFilter cachedGearSortAndFilter;

	private CollectibleNodeModifierSortAndFilter cachedCollectibleNodeSortAndFilter;

	private FriendSort cachedFriendSort;

	public bool IsOn
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private event OnSortToggled SortToggled
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

	public void Set<T, U, V>(SortAndFilter<T, U, V> sortAndFilter, OnSortToggled sortToggledCallback, ToggleGroup sortToggleGroup = null) where U : IConvertible where V : IConvertible
	{
	}

	public bool MatchesSortBy(int sortBy)
	{
		return false;
	}

	public Toggle GetToggle()
	{
		return null;
	}

	public void SetToggleType(ToggleType toggleType)
	{
	}

	public void SetBlockUGUICallbacks(bool value)
	{
	}

	public void UGUI_Toggled(bool value)
	{
	}

	private void CacheSortAndFilterReference(CharacterSortAndFilter charSortFilter, GearSortAndFilter gearSortFilter, CollectibleNodeModifierSortAndFilter collectibleSortAndFilter, FriendSort friendSort)
	{
	}

	private void InternalSet(int filterMask, bool isFiltered, bool isFilterDisabled, ToggleGroup sortToggleGroup)
	{
	}

	private void InternalFilterToggled<T, U, V>(SortAndFilter<T, U, V> sortAndFilter, U filterMask, bool show) where U : IConvertible where V : IConvertible
	{
	}

	private void InternalSortToggled<T, U, V>(SortAndFilter<T, U, V> sortAndFilter, V sortBy, bool selected) where U : IConvertible where V : IConvertible
	{
	}
}
