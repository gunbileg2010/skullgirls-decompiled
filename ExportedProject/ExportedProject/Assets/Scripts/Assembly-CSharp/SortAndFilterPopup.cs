using UnityEngine;
using UnityEngine.UI;

public class SortAndFilterPopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private SortAndFilterUI sortAndFilterUI;

	[SerializeField]
	private GameObject filterResetButtonGO;

	[SerializeField]
	private GameObject sortResetButtonGO;

	[SerializeField]
	private ScrollRect filterScrollRect;

	[SerializeField]
	private ScrollRect sortScrollRect;

	private CharacterSortAndFilter characterSortAndFilter;

	private GearSortAndFilter gearSortAndFilter;

	private CollectibleNodeModifierSortAndFilter collectibleNodeModifierSortAndFilter;

	private FriendSort friendSort;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public override void SetData(PopupData newPopupData)
	{
	}

	public void UGUI_ResetFilters()
	{
	}

	public void UGUI_ResetSort()
	{
	}

	private void OnSortOrFilterChanged()
	{
	}
}
