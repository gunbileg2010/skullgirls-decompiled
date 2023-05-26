using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SortAndFilterUI : MonoBehaviour
{
	[SerializeField]
	private Transform sortDirectionIndicator;

	[SerializeField]
	private GameObject sortScrollGO;

	[SerializeField]
	private List<SortAndFilterToggle> sortToggles;

	[SerializeField]
	private ToggleGroup sortToggleGroup;

	[SerializeField]
	private GameObject filterScrollGO;

	[SerializeField]
	private List<SortAndFilterToggle> filterToggles;

	[SerializeField]
	private List<GameObject> filterGroupParents;

	[SerializeField]
	private SortAndFilterToggle newFilterToggle;

	[SerializeField]
	private SortAndFilterToggle favoriteFilterToggle;

	[SerializeField]
	private List<SortAndFilterToggle> offForCompetitiveFilterToggles;

	public void Set<T, U, V>(SortAndFilter<T, U, V> sortAndFilter, bool isCompetitive = false) where U : IConvertible where V : IConvertible
	{
	}

	private void OnSortToggled(Toggle toggle, bool sortDirectionIsAscending)
	{
	}

	private void SetFilterToggleOnOff(SortAndFilterToggle filterToggle, bool isActive)
	{
	}
}
