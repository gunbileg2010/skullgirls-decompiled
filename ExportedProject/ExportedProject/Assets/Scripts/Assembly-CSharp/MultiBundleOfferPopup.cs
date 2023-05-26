using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiBundleOfferPopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private float[] popupWidthsForOfferCount;

	[SerializeField]
	private MultiBundleOfferItem offerItemPrefab;

	[SerializeField]
	private RectTransform offerItemsParent;

	[SerializeField]
	private TimerUI timerToExpirationDate;

	[SerializeField]
	private GameObject misalignedExpirationDatesIndicator;

	[SerializeField]
	private int offerCountBeforeScrollViewIsLeftAligned;

	private List<MultiBundleOfferItem> spawnedOfferItems;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void MakePurchase(OfferServerData offerServerData)
	{
	}

	private string GetMetricStringFromContext(MultiOfferData.MultiOfferPopupContext context)
	{
		return null;
	}
}
