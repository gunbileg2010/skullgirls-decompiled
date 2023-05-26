using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GearMultiSellPopup : MasterPopup
{
	[SerializeField]
	private Transform cardsAnchor;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private int allowScrollingAfterCount;

	private List<Gear> gearToSell;

	public override void SetData(PopupData newPopupData)
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private void OnHide(IPopup popup)
	{
	}
}
