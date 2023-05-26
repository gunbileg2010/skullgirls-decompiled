using UnityEngine;

public class FeaturedBundleView : MonoBehaviour
{
	[SerializeField]
	private GameObject unavailableGO;

	[SerializeField]
	private LocalizedUGUIText purchaseHeaderText;

	[SerializeField]
	private GameObject diamondBanner;

	[SerializeField]
	private BundleOfferView bundleOfferView;

	[SerializeField]
	private BundleOfferStoreListItem bundleListItem;

	[SerializeField]
	private AdvancedButton purchaseButton;

	[SerializeField]
	private RectTransform saleSticker;

	[SerializeField]
	private GameObject relicOddsButton;

	[SerializeField]
	private RectTransform rewardsParent;

	private FeaturedOfferData.OfferWithDisplayParams offerDataWithParams;

	private OfferServerData serverData;

	private void OnEnable()
	{
	}

	public void Populate(FeaturedOfferData.OfferWithDisplayParams offerDataWithParams, string purchaseContext = "storeListPurchase")
	{
	}

	public void ReparentSaleSticker(RectTransform newParent)
	{
	}

	public void CleanUp()
	{
	}

	public void UGUI_ShowRelicOdds()
	{
	}

	public void UGUI_UnavailablePressed()
	{
	}

	private void SetupPurchaseButton()
	{
	}

	private void ToggleAvailability(bool isAvailable)
	{
	}

	private void OnBundlesPurchased(params OfferServerData[] purchasedOffers)
	{
	}
}
