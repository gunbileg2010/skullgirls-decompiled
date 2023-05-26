using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortraitChooserPopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private CharacterPortrait selectedCharacterPortrait;

	[SerializeField]
	private RecycledScrollList portraitRecycledScrollList;

	[SerializeField]
	private PopupData sortAndFilterPopupData;

	[SerializeField]
	private GameObject activeFilterSortGlowGO;

	private CharacterSortAndFilter characterSortAndFilter;

	private List<Character> characterCollection;

	private List<Character> filteredAndSortedCharacterCollection;

	private Stack<CharacterPortrait> availablePortraits;

	private Character selectedCharacter;

	protected override void Awake()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_FilterSortButtonClicked()
	{
	}

	protected override void ButtonPressed(int index)
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

	private void OnCharacterPortraitClicked(CharacterPortrait portrait)
	{
	}
}
