using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionView : MonoBehaviour
{
	[SerializeField]
	private RecycledScrollList recycledScrollList;

	[SerializeField]
	private PopupData sortAndFilterPopupData;

	[SerializeField]
	private GameObject activeFilterSortGlowGO;

	[SerializeField]
	private Toggle availableFilterToggle;

	[SerializeField]
	private Toggle prestigeFilterToggle;

	[SerializeField]
	private Button sortAndFilterButton;

	[SerializeField]
	private AspectRatioGridZoom gridZoom;

	[SerializeField]
	private Button zoomInButton;

	[SerializeField]
	private Button zoomOutButton;

	private static CharacterSortAndFilter characterSortAndFilter;

	private Func<Character, Card> addCard;

	private Action<Card> removeCard;

	private List<Character> characterCollection;

	private List<Character> filteredAndSortedCharacterCollection;

	private List<Card> activeCards;

	private bool blockFilterUpdate;

	private bool prestigeFilterIsOn;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Populate(List<Character> characters, Func<Character, Card> addCard, Action<Card> removeCard)
	{
	}

	public void Repopulate(List<Character> characters)
	{
	}

	public void RefreshFilterAndZoomButtons(bool interactable)
	{
	}

	public void Clear()
	{
	}

	public List<Card> GetCards()
	{
		return null;
	}

	public void SetDisabledFilters(CharacterSortAndFilter.FilterMask filter)
	{
	}

	public void SetFilterState(CharacterSortAndFilter.FilterMask filter)
	{
	}

	public void SetCustomFilterFunction(Func<Character, bool> filterFunc)
	{
	}

	public void SetUseCustomFilterFunction(bool useFilter)
	{
	}

	public void UGUIZoomOutClicked()
	{
	}

	public void UGUIZoomInClicked()
	{
	}

	public void UGUI_FilterSortButtonClicked()
	{
	}

	public void UGUI_AvailableTogglePressed(bool on)
	{
	}

	private RectTransform OnAddCharacterScrollItem(int index)
	{
		return null;
	}

	private void OnRemoveCharacterScrollItem(RectTransform item)
	{
	}

	private void OnCharacterSortOrFilterChanged()
	{
	}

	private void RefreshZoomButtons(bool allowInteraction = true)
	{
	}

	private void RefreshFilterAndSortGlowGO()
	{
	}
}
