using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeaturedOfferView : MonoBehaviour
{
	[SerializeField]
	private RawImage backgroundImage;

	[SerializeField]
	private LocalizedUGUIText titleText;

	[SerializeField]
	private LocalizedUGUIText descriptionText;

	[SerializeField]
	private LocalizedUGUIText limitedTimeText;

	[SerializeField]
	private TimerUI timerToExpirationDate;

	[SerializeField]
	private Transform tableauParent;

	[SerializeField]
	private RectTransform topWindowTransform;

	[SerializeField]
	private RectTransform offerPanelTransform;

	[SerializeField]
	private FeaturedBundleView bundleItemPrefab;

	[SerializeField]
	private Transform bundleItemParent;

	[SerializeField]
	private RectTransform saleStickersParent;

	private List<FeaturedBundleView> spawnedBundleItems;

	private OfferTableau tableau;

	private GameObject tableauPrefab;

	private DynamicResource cachedBackgroundResource;

	private FeaturedOfferData cachedFeaturedOfferData;

	private void OnEnable()
	{
	}

	public void Populate(FeaturedOfferData featuredOfferData, Action expirationCallback = null, string purchaseContext = "storeListPurchase")
	{
	}

	public void CleanUp()
	{
	}

	public void Hide()
	{
	}

	public string GetGuid()
	{
		return null;
	}

	public List<OfferData> GetOffersList()
	{
		return null;
	}
}
