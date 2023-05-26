using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PurchaseManager : MonoBehaviour
{
	public enum PurchaseResult
	{
		Success = 0,
		ProductNotAvailable = 1,
		OfferNotAvailable = 2,
		StorePurchaseCanceled = 3,
		StorePurchaseFailed = 4,
		RewardsAlreadyClaimed = 5,
		ValidateAndGrantRewardsFailed = 6,
		TryFinishIncompleteLater = 7
	}

	[SerializeField]
	private List<MoneyOfferData> moneyStoreOffers;

	[SerializeField]
	private List<SubscriptionOfferData> subscriptionStoreOffers;

	[SerializeField]
	private List<CurrencyOfferData> currencyStoreOffers;

	[SerializeField]
	private List<LimitedTimeOfferData> limitedTimeOffers;

	[SerializeField]
	private List<MultiOfferData> multiOfferDatas;

	[SerializeField]
	private List<FeaturedOfferData> featuredOfferDatas;

	private const string kDevGoogleIABPublicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA7+u5rsXqs0/3JRKeDUZu/AEl/UFxOlPdcWfhCD65OMg5xZiO0PPjhNetBFgz0DncZ0zzO9TJW8P5j9nff2SwbglhiI50TBOHCWz/+E0mJ+PLqPMgR6YB0resJi/pA35d//RUqtmXfY6PJc6H4bhxDnZ5SJwO7DrSzYBbSlY93Bw9y6sSTVxjmZwiaUgTI4PTNJ1acemr1KOc9owjgputZjqz6gja/84LUQMZL0ufnk7RqQsaOwDrfsa/QonTxyIeXh0ZIvxyPUGu/49XOeEQmE4Zst9e3fNEJ535BMkeg4Wvf9JNGMcar6iqpbrF2aDAF23bZwns23rQUUDgjivc2wIDAQAB";

	private const string kProdGoogleIABPublicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAlFvHUXE+6mILz/sCk6Rrkr8TeCNbZgfFJ01hoa8UmQOmX/9AmPPpTwj7OOMmsCClZktGyJVwqEkpL/8AC35vz+C5qNTWwBQ5RmKV1j0TcEVWtb8WCg4aMIkFj95OcPGX5Xx2jSZQkBWofOlTYS5anfNPq109CnoDRgmeLBnkPhUc7ZzVdZKqJEZy5rRaFt9pFB06ikZDexrgqGGBIhthyb3qb9+AfVhU0HB/s3YJGkZI0LCLaNwBRIxwVcdcvFa892zvQMRLLqZGnypjI50nF9IsprdkS9f91ykVp3C5L/nUQB8xGuP+dO2X24NAFHxzjPA6Tn1A5vxsVVdwqobpUwIDAQAB";

	private const string kOffersHashset = "offersHashset";

	private List<OfferServerData> availableMoneyStoreOffers;

	private List<OfferServerData> availableBonusMoneyStoreOffers;

	private List<OfferServerData> availableCurrencyStoreOffers;

	private List<OfferServerData> availableBundleStoreOffers;

	private List<OfferServerData> availableUserOffers;

	private List<OfferServerData> incompletePurchaseOffers;

	private List<OfferServerData> showImmediatelyUserOffers;

	private List<string> iapProductIds;

	private Dictionary<string, List<PurchaseAction>> pricePointsByProductId;

	private List<string> blockedMultiOfferGuids;

	private Dictionary<string, RewardCalendarInstanceServerData> activeSubscriptionCalendars;

	private HashSet<string> subscriptionCalendarGuids;

	private HashSet<string> viewedOfferGuids;

	private HashSet<string> featuredOfferGuids;

	public const string kTabbedStoreSeenSaveKey = "tabbedStoreSeen";

	public const int kMaxInitRetries = 3;

	public event Action OffersUpdated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public static bool UseDummyPurchaseFlow()
	{
		return false;
	}

	public static string GetGoogleIABKey()
	{
		return null;
	}

	public void Init()
	{
	}

	public void RefreshOffersFromServer(Action<bool, string> callback)
	{
	}

	public void FinishIncompletePurchases()
	{
	}

	public void FinishIncompletePurchasesWithoutErrorPopup()
	{
	}

	public List<OfferServerData> GetAvailableMoneyStoreOffers()
	{
		return null;
	}

	public List<OfferServerData> GetAvailableBonusMoneyStoreOffers()
	{
		return null;
	}

	public List<OfferServerData> GetAvailableCurrencyStoreOffers()
	{
		return null;
	}

	public List<OfferServerData> GetAvailableUserOffers()
	{
		return null;
	}

	public List<OfferServerData> GetAvailableBundleOffers()
	{
		return null;
	}

	public List<FeaturedOfferData> GetAvailableFeaturedOffers()
	{
		return null;
	}

	public OfferServerData GetMoneyStoreServerDataWithGuid(string guid)
	{
		return null;
	}

	public void SetViewedOffers(List<string> offerGuids)
	{
	}

	public int GetNewOfferCount()
	{
		return 0;
	}

	public bool HasFreeGifts()
	{
		return false;
	}

	public bool GetHasOfferBeenSeen(OfferData offer)
	{
		return false;
	}

	public bool GetHasOfferGuidBeenSeen(string offerGuid)
	{
		return false;
	}

	public bool HasAnAvailableLTO()
	{
		return false;
	}

	public OfferServerData GetHighestPriorityOfferNotOnPopupCooldown()
	{
		return null;
	}

	public List<string> GetKnownIapProductIds()
	{
		return null;
	}

	public bool HasNewOfferPopup()
	{
		return false;
	}

	public void ShowNewOfferPopupIfAny(Action callback, Action<bool, OfferServerData[]> offerPurchasedCallback = null, bool shouldQueue = true)
	{
	}

	public MoneyOfferData GetMoneyStoreOfferDataByGuid(string guid)
	{
		return null;
	}

	public SubscriptionOfferData GetSubscriptionStoreOfferDataByGuid(string guid)
	{
		return null;
	}

	public CurrencyOfferData GetCurrencyStoreOfferDataByGuid(string guid)
	{
		return null;
	}

	public LimitedTimeOfferData GetLimitedTimeOfferDataByGuid(string guid)
	{
		return null;
	}

	public OfferServerData GetBundleStoreServerOfferDataByGUID(string guid)
	{
		return null;
	}

	public bool IsOfferFeatured(OfferData offerData)
	{
		return false;
	}

	public MultiOfferData GetOverridingMultiOfferData(OfferServerData triggeringOfferServerData)
	{
		return null;
	}

	public FeaturedOfferData GetOverridingFeaturedOfferData(OfferServerData triggeringOfferServerData)
	{
		return null;
	}

	public void PurchaseStoreOffer(OfferServerData offerServerData, Action<PurchaseResult, List<Reward>> callback)
	{
	}

	public bool ShowOfferPopupIfPossible(Action<bool> callback)
	{
		return false;
	}

	public void UpdateActiveSubscriptionCalendars(List<RewardCalendarStateServerData> calendarList)
	{
	}

	public bool IsSubscriptionActive(SubscriptionOfferData subscriptionOfferData)
	{
		return false;
	}

	public RewardCalendarInstanceServerData GetSubscriptionCalendarState(string calendarGuid)
	{
		return null;
	}

	public void DEBUG_ClearOfferPopupsShown()
	{
	}

	public List<MoneyOfferData> GetIAPDatas()
	{
		return null;
	}

	public List<CurrencyOfferData> GetStoreSCBundles()
	{
		return null;
	}

	public List<LimitedTimeOfferData> GetLTODatas()
	{
		return null;
	}

	private bool ArePurchasesEnabled()
	{
		return false;
	}

	private void ShowPopup(OfferServerData offerServerData, List<OfferServerData> allServerData, Action<bool> callback)
	{
	}

	private void RefreshProductsFromIAPProvider(Action<bool, string> callback)
	{
	}

	private void ExecuteMoneyPurchase(PurchaseAction purchaseAction, string offerId, Action<PurchaseResult, List<Reward>> callback)
	{
	}

	private IEnumerator DoFinishIncompletePurchases(List<PurchaseData> incompletePurchases, bool suppressErrorPopup = false)
	{
		return null;
	}

	private void ValidateIncompletePurchase(PurchaseAction purchaseAction, PurchaseData purchaseData, Action<bool, bool, bool> callback)
	{
	}

	private void ValidatePurchase(PurchaseAction purchaseAction, string offerId, PurchaseData purchaseData, Action<PurchaseResult, List<Reward>> callback)
	{
	}

	private void RefreshProductIds()
	{
	}

	private bool IsUserOffer(string productId)
	{
		return false;
	}

	private string GetOfferIdByProductId(string productId)
	{
		return null;
	}

	private void ProcessPurchaseError(PurchaseResult result, string errorCode, string errorMessage, Action<PurchaseResult, List<Reward>> callback)
	{
	}

	private void OnOfferPurchased(OfferServerData offerServerData)
	{
	}

	private void OnLoggedIn(AuthenticateRequest authRequest)
	{
	}

	private void OnResponseDictionaryReceived(Dictionary<string, object> responseDictionary)
	{
	}

	private void RemoveMoneyPurchaseOffers(List<OfferServerData> offerServerDatas)
	{
	}
}
