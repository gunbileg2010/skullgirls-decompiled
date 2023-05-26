using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IAPStoreScreen : MonoBehaviour
{
	public enum StoreTab
	{
		Featured = 0,
		Subscription = 1,
		UserLTOs = 2,
		LTOs = 3,
		Currency = 4
	}

	private class TabBadgeCount
	{
		public int count;

		public bool hasFree;
	}

	public const int kMainMenuButtonContext = 0;

	public const int kFromNavBarContext = 1;

	public const int kFromSizzleButtonContext = 2;

	[SerializeField]
	private LoadingView loadingView;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private BundleOfferStoreListItem offerListItem;

	[SerializeField]
	private GameObject offerListGO;

	[SerializeField]
	private Transform offerListContent;

	[SerializeField]
	private IAPListItem hcscListItemPrefab;

	[SerializeField]
	private GameObject hcscListGO;

	[SerializeField]
	private Transform hcListContent;

	[SerializeField]
	private Transform scListContent;

	[SerializeField]
	private GameObject bonusBannerGO;

	[SerializeField]
	private FeaturedOfferView featuredListItem;

	[SerializeField]
	private GameObject featureOfferListGO;

	[SerializeField]
	private Transform featuredOfferListContent;

	[SerializeField]
	private ToggleGroupRowController sectionToggleController;

	[SerializeField]
	private Toggle featuredToggle;

	[SerializeField]
	private Toggle limitedOffersToggle;

	[SerializeField]
	private Toggle subscriptionToggle;

	[SerializeField]
	private Toggle recurringToggle;

	[SerializeField]
	private Toggle currencyToggle;

	[SerializeField]
	private CheapLayoutGroup tabLayoutGroup;

	[SerializeField]
	private Badge featuredBadge;

	[SerializeField]
	private Badge limitedOffersBadge;

	[SerializeField]
	private Badge subscriptionBadge;

	[SerializeField]
	private Badge recurringBadge;

	[SerializeField]
	private GameObject recurringTextBadgeGO;

	[SerializeField]
	private Badge currencyBadge;

	[SerializeField]
	private GameObject featuredHighlight;

	[SerializeField]
	private GameObject limitedOffersHighlight;

	[SerializeField]
	private GameObject subscriptionHighlight;

	[SerializeField]
	private GameObject recurringHighlight;

	[SerializeField]
	private GameObject currencyHighlight;

	[SerializeField]
	private DynamicAdButton adButton;

	private List<IAPListItem> iapListItems;

	private List<BundleOfferStoreListItem> bundleItems;

	private List<FeaturedOfferView> featuredItems;

	private bool haveFeaturedOffer;

	private IAPStoreContext storeContext;

	private StoreTab? currentStoreTab;

	private List<GameObject> unseenOffers;

	private HashSet<GameObject> seenOffers;

	private bool refreshStoreSuccess;

	private string refreshStoreErrorCode;

	private Vector3[] objectCorners;

	private void Awake()
	{
	}

	public void UGUI_RewardedVideoAdsPressed()
	{
	}

	public void DEBUG_RefreshButtonPressed()
	{
	}

	private IEnumerator OnStateEntered(IGameState prevState, object context)
	{
		return null;
	}

	private IEnumerator OnStateExited(IGameState nextState)
	{
		return null;
	}

	private void InitializeOffers()
	{
	}

	private void RefreshStore(Action callback = null)
	{
	}

	private void ActivateToggleForStoreTab(StoreTab storeTab)
	{
	}

	private StoreTab GetTabForOffer(OfferData offer)
	{
		return default(StoreTab);
	}

	private bool ShouldOfferBeActiveForTab(OfferData offerData, StoreTab? currentTab)
	{
		return false;
	}

	private bool ShouldOfferHaveBadge(OfferServerData offer, ref Dictionary<StoreTab, TabBadgeCount> tabBadgeCounts)
	{
		return false;
	}

	private void PopulateHCSCStoreLists(List<OfferServerData> hcOffers, List<OfferServerData> scOffers, ref Dictionary<StoreTab, TabBadgeCount> tabBadgeCounts)
	{
	}

	private OfferServerData GetBonusOffer(string guid)
	{
		return null;
	}

	private IAPListItem GetHCSCListItem(int idx, Transform parent)
	{
		return null;
	}

	private void RemoveHCSCListItem(IAPListItem iapListItem)
	{
	}

	private void PopulateBundleStoreList(List<OfferServerData> offers, ref Dictionary<StoreTab, TabBadgeCount> tabBadgeCounts)
	{
	}

	private void PopulateFeatureStoreList(List<FeaturedOfferData> offers, ref Dictionary<StoreTab, TabBadgeCount> tabBadgeCounts)
	{
	}

	private void ClearAllListItems()
	{
	}

	private void OnHCBonusOfferPurchased(OfferServerData serverData, IAPListItem iapListItem)
	{
	}

	private void OnBundlesPurchased(params OfferServerData[] purchasedOffers)
	{
	}

	private bool HasFreeGiftInTab(StoreTab storeTab = StoreTab.LTOs)
	{
		return false;
	}

	private void OnAdButtonUpdated(DateTime adPacingExpiration)
	{
	}

	private void OnSectionToggleActivated(Toggle toggle)
	{
	}

	private bool OfferVisible(RectTransform offerTransform)
	{
		return false;
	}

	private void OnScroll(Vector2 pointerEventData)
	{
	}

	private void LogMetrics(StoreTab? storeTab)
	{
	}

	private string GetMetricsContext(StoreTab? storeTab)
	{
		return null;
	}
}
