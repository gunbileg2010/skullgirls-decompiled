using UnityEngine;
using UnityEngine.UI;

public class IAPListItem : MonoBehaviour
{
	public delegate void IAPOfferPurchaseDelegate(OfferServerData purchasedOffer, IAPListItem iapListItem);

	[SerializeField]
	private Text lootBreakdownText;

	[SerializeField]
	private Text lootTextTotal;

	[SerializeField]
	private Badge badge;

	[SerializeField]
	private CurrencyDisplayUI priceText;

	[SerializeField]
	private GameObject saleStickerGO;

	[SerializeField]
	private LocalizedUGUIText saleStickerText;

	[SerializeField]
	private string regularBonusKey;

	[SerializeField]
	private string saleKey;

	[SerializeField]
	private Image currencyGlow;

	[SerializeField]
	private Image currencyImage;

	[SerializeField]
	private Transform decorationAnchor;

	[SerializeField]
	private UIGradient32 bonusFrameGradient;

	[SerializeField]
	private GameObject bonusDecorationsGO;

	[SerializeField]
	private Text bonusSaleBannerNumberText;

	[SerializeField]
	private GameObject bonusPurchaseLimitStickerGO;

	[SerializeField]
	private LocalizedUGUIText purchaseLimitText;

	[SerializeField]
	private LocalizedUGUIText standardLootAmountText;

	[SerializeField]
	private Text bonusOfferPaidLootText;

	[SerializeField]
	private Text bonusOfferBonusLootText;

	[SerializeField]
	private MasterPopupData confirmPurchasePopupData;

	private OfferServerData serverData;

	private OfferData clientData;

	private string productText;

	private IAPStoreContext storeContext;

	private GameObject decoration;

	private IAPOfferPurchaseDelegate purchaseCallback;

	public void Populate(OfferServerData serverData, IAPOfferPurchaseDelegate purchaseCallback = null)
	{
	}

	public void SetBadgeActive(bool isActive)
	{
	}

	public void Clear()
	{
	}

	public void SetStoreContext(IAPStoreContext context)
	{
	}

	public void UGUI_PurchaseButtonPressed()
	{
	}

	public OfferData GetClientData()
	{
		return null;
	}

	public OfferServerData GetServerData()
	{
		return null;
	}

	private void PopulateLoot(Loot baseLoot, Loot bonusLoot, int numDays = 0)
	{
	}

	private void PurchaseSCBundle(CurrencyPurchaseAction currencyPurchaseAction)
	{
	}

	private void ShowMoneyPurchaseConfirmPopup(string title, string price)
	{
	}

	private void LogPurchaseConversion()
	{
	}

	private void PurchaseMoneyOffer()
	{
	}

	private void SetBonusOfferEnabled(bool enabled)
	{
	}
}
