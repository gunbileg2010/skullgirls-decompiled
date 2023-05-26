using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BundleOfferStoreListItem : MonoBehaviour
{
	public delegate void BundleOfferStorePurchaseDelegate(params OfferServerData[] purchasedOffers);

	[SerializeField]
	private Badge badge;

	[SerializeField]
	private CollectibleIcon collectibleIconPrefab;

	[SerializeField]
	private GameObject rewardsRowsGO;

	[SerializeField]
	private RectTransform rewardsRow1Parent;

	[SerializeField]
	private RectTransform rewardsRow2Parent;

	[SerializeField]
	private HorizontalLayoutGroup rewardsRow1LayoutGroup;

	[SerializeField]
	private HorizontalLayoutGroup rewardsRow2LayoutGroup;

	[SerializeField]
	private Text subscriptionLootText;

	[SerializeField]
	private GameObject subscriptionStateGO;

	[SerializeField]
	private LocalizedUGUIText subscriptionDaysLeftText;

	[SerializeField]
	private LocalizedUGUIText sidePanelHeaderText;

	private BundleOfferView bundleOfferView;

	private OfferServerData serverData;

	private OfferData clientData;

	private SubscriptionOfferData subscriptionClientData;

	private BundleOfferStorePurchaseDelegate purchaseCallback;

	private List<CollectibleIcon> spawnedCollectibleIcons;

	private string purchaseContext;

	private void OnEnable()
	{
	}

	public void Populate(OfferServerData serverData, BundleOfferStorePurchaseDelegate purchaseCallback, string purchaseContext = "storeListPurchase")
	{
	}

	public void PopulateRewardIcons(OfferData offerData)
	{
	}

	public void SetBadgeActive(bool isActive)
	{
	}

	public void Clear()
	{
	}

	public void Hide()
	{
	}

	public OfferServerData GetServerData()
	{
		return null;
	}

	public OfferData GetClientData()
	{
		return null;
	}

	public void UGUI_PurchaseButtonPressed()
	{
	}

	public void UGUI_ShowPopupButtonPressed()
	{
	}

	private void OnTimerExpired()
	{
	}
}
