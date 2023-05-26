using System;
using System.Collections.Generic;
using UnityEngine;

public class PopupCatalog : MonoBehaviour
{
	public class TextInputDefaultStrings
	{
		public string text;

		public string placeholderText;

		public TextInputDefaultStrings(string text, string placeholderText)
		{
		}
	}

	public enum ContextualPopupType
	{
		Generic = 0,
		MatchChallenge = 1,
		Collectibles = 2
	}

	[SerializeField]
	private MasterPopupData oneButtonPopup;

	[SerializeField]
	private MasterPopupData twoButtonPopup;

	[SerializeField]
	private MasterPopupData textInputPopup;

	[SerializeField]
	private ContextualPopupItem contextualPopup;

	[SerializeField]
	private ContextualPopupMatchChallenges matchChallengeContextualPopup;

	[SerializeField]
	private ContextualPopupItem CollectiblesContextualPopup;

	[SerializeField]
	private RewardsPopupData claimedRewardsPopupData;

	[SerializeField]
	private RewardsPopupData purchasedRewardsPopupData;

	[SerializeField]
	private RewardsPopupData socialGiftRewardsPopupData;

	[SerializeField]
	private RewardsPopupData conversionRewardsPopupData;

	[SerializeField]
	private RewardsPopupData deploymentCompletedRewardsPopupData;

	[SerializeField]
	private PopupData loginRewardCalendarPopupData;

	[SerializeField]
	private PopupData inventoryPopupData;

	[SerializeField]
	private PopupData socialPopupData;

	[SerializeField]
	private PopupData rewardedVideoAdsPopupData;

	[SerializeField]
	private PopupData energyRefillPopupData;

	[SerializeField]
	private MasterPopupData errorOnlyOKPopupData;

	[SerializeField]
	private MasterPopupData errorOnlyRetryPopupData;

	[SerializeField]
	private MasterPopupData errorRetryCancelPopupData;

	[SerializeField]
	private PopupData convertPopup;

	[SerializeField]
	private PopupData inventorySoftCapPopupData;

	[SerializeField]
	private PopupData inventorySoftCapExpandPopupData;

	[SerializeField]
	private PopupData insufficientCurrencyPopupData;

	[SerializeField]
	private PopupData insufficientCurrencyGetMorePopupData;

	[SerializeField]
	private GachaData insufficientBattleCurrencyGachaContext;

	[SerializeField]
	private MasterPopupData purchaseConfirmationPopup;

	[SerializeField]
	private PopupData quitGamePopupData;

	[SerializeField]
	private PopupData changeHandlePopupData;

	[SerializeField]
	private PopupData fightModifiersPopupData;

	[SerializeField]
	private FightResultsPopupData fightResultsPopupData;

	[SerializeField]
	private LeaderboardEventDefenseHistoryPopupData leaderboardDefenseHistoryPopupData;

	[SerializeField]
	private FanfarePopupData fanfarePopupData;

	[SerializeField]
	private PopupData fighterPreviewPopupData;

	[SerializeField]
	private GearDetailsPopupData gearDetailsPopupData;

	[SerializeField]
	private PopupData profilePopupData;

	[SerializeField]
	private PopupData riftBattlesTutorialDefenseNotSet;

	[SerializeField]
	private PopupData riftBattlesNotEnoughEnergy;

	[SerializeField]
	private MasterPopupData riftBattlesAutoCompletePopupData;

	[SerializeField]
	private PopupData collectibleNodeModifierDetailsPopup;

	[SerializeField]
	private PopupData replayPreviewPopupData;

	[SerializeField]
	private RelicOddsPopupData relicOddsPopupData;

	[SerializeField]
	private PopupData prestigeAbilityUpgradeDetails;

	[SerializeField]
	private PopupData sessionExpiredPopupData;

	[SerializeField]
	private PopupData userSuspendedPopupData;

	[SerializeField]
	private PopupData userBannedPopupData;

	[SerializeField]
	private PopupData forcedUpdatePopupData;

	[SerializeField]
	private PopupData guestWarningPopupData;

	[SerializeField]
	private PopupData loginDataLossPopupData;

	[SerializeField]
	private SGAccountPopupData sgAccountBindPopupData;

	[SerializeField]
	private SGAccountPopupData sgAccountCreatePopupData;

	[SerializeField]
	private SGAccountPopupData sgAccountLoginPopupData;

	[SerializeField]
	private SGAccountPopupData sgAccountForgotPasswordPopupData;

	[SerializeField]
	private SGAccountPopupData sgAccountChangeEmailPopupData;

	[SerializeField]
	private MasterPopupData sgLeavingAppPopup;

	[SerializeField]
	private PopupData featuredOfferPopupData;

	private const string kNetworkErrorNoInternetKey = "NetworkError_NoInternet";

	private const string kNetworkErrorServerConnectionKey = "NetworkError_Connection";

	private const string kNetworkErrorGenericKey = "NetworkError_General";

	private CollectibleNodeModifierDetailsPopup.Context nodeModifierContextStorage;

	private Dictionary<string, ContextualPopupItem> contextualPopups;

	public static IAPStoreContext? insufficientCurrencyContext;

	public void HandleFailedPurchaseNetworkRequest(NetworkRequest networkRequest, Action callback = null, Action retryCallback = null, int? overrideLayer = null)
	{
	}

	public void HandleFailedEnergyNetworkRequest(NetworkRequest networkRequest, Action callback = null, Action retryCallback = null, int? overrideLayer = null)
	{
	}

	public void HandleFailedNetworkRequest(NetworkRequest networkRequest, Action callback = null, Action retryCallback = null, int? overrideLayer = null)
	{
	}

	public void HandleFailedNetworkRequestBase(NetworkRequest networkRequest, string defaultMessage, Action callback = null, Action retryCallback = null, int? overrideLayer = null)
	{
	}

	public void ShowConnectionOrInternetError(string errorCode = "", Action callback = null, Action retryCallback = null)
	{
	}

	public void ShowGenericServerError(string errorCode = "", string errorMessage = "", Action callback = null, Action retryCallback = null)
	{
	}

	public void ShowError(string message, string errorCode = "", string errorMessage = "", Action callback = null, Action retryCallback = null, int? overrideLayer = null)
	{
	}

	public void ShowInsufficientCurrency(CurrencyType currencyType, Action popupHideCallback = null, int? overrideLayer = null)
	{
	}

	public void CheckEnergyAndShowRefill(Fight currentFight, Action<bool> callback, Action refilledCallback, Action teamSelectCallback, Action failedCallback)
	{
	}

	public void ShowConversionPopup(Character currentCharacter, Action<IPopup> successfullConversionCallback, Action<IPopup> negativeButtonCallback = null)
	{
	}

	public void ShowSessionExpiredError(Action callback = null)
	{
	}

	public void ShowInventoryCapError(Action<IPopup> onLeaveAction = null)
	{
	}

	public void ShowInventoryPopup()
	{
	}

	public void ShowSocialPopup()
	{
	}

	public void ShowRewardedVideoAdsPopup(string fromScreenName)
	{
	}

	public void ShowRiftBattleDefenseNotSetPopup()
	{
	}

	public void ShowRiftBattleDefenseNotSetPopup(Action<IPopup> teamSelectCallback, Action<IPopup> cancelCallback)
	{
	}

	public void ShowExpandCollectionPopup(CollectionType collectionType, Action onPurchaseMadeCallback = null)
	{
	}

	public void ShowOneButtonPopup(string message, Action callback = null, bool immediatelyNext = false, int? overrideLayer = null, DateTime? expirationDate = null)
	{
	}

	public void ShowOneButtonPopup(string message, string buttonText, Action callback = null, bool immediatelyNext = false, int? overrideLayer = null, DateTime? expirationDate = null, ButtonType buttonType = ButtonType.Generic)
	{
	}

	public void ShowOneButtonPopup(string header, string message, string buttonText, Action callback = null, PopupData overridePopupData = null, bool immediatelyNext = false, int? overrideLayer = null, DateTime? expirationDate = null, ButtonType buttonType = ButtonType.Generic, float changeTimerColorAtSeconds = 0f, Color? newTimerColor = null)
	{
	}

	public void ShowTwoButtonPopup(string message, Action positiveCallback = null, Action negativeCallback = null, int? overrideLayer = null)
	{
	}

	public void ShowTwoButtonPopup(string message, string positiveButtonText, string negativeButtonText, Action positiveCallback = null, Action negativeCallback = null, int? overrideLayer = null)
	{
	}

	public void ShowTwoButtonPopup(string message, string positiveButtonText, string negativeButtonText, ButtonType positiveButtonType, ButtonType negativeButtonType, Action positiveCallback = null, Action negativeCallback = null, int? overrideLayer = null)
	{
	}

	public ContextualPopupItem GetContextualPopup(Transform parent, string id = "", ContextualPopupType popupType = ContextualPopupType.Generic)
	{
		return null;
	}

	public ContextualPopupItem ShowContextualPopup(string message, Vector3 position, Transform parent, string id = "", float secondsVisible = -1f, bool hideOnPress = false, bool showBackground = false, ContextualPopupType popupType = ContextualPopupType.Generic)
	{
		return null;
	}

	public ContextualPopupMatchChallenges ShowMatchChallengeContextualPopup(Vector3 position, Transform parent, string id = "", float secondsVisible = -1f)
	{
		return null;
	}

	public void HideContextualPopup(string id = "", ContextualPopupType popupType = ContextualPopupType.Generic)
	{
	}

	public void ShowTextInputPopup(string header, string message, string defaultInput, string placeholderInput, Action<string> callback)
	{
	}

	public void ShowTextInputPopup(string header, string message, string defaultInput, string placeholderInput, Action<string> positiveCallback = null, Action<string> negativeCallback = null)
	{
	}

	public void ShowPurchaseConfirmationPopup(Price price, Action callback, Action cancelCallback = null, int quantity = 1, DateTime? endTime = null, int popupLayer = -1, bool changeNav = true, float changeTimerColorAtSeconds = 0f, Color? newTimerColor = null)
	{
	}

	public void ShowPurchaseConfirmationPopup(string message, Price price, Action callback, Action cancelCallback = null, int quantity = 1, DateTime? endTime = null, int popupLayer = -1, bool changeNav = true, Dictionary<CurrencyType, Action<CurrencyDisplayUI>> dynamicCurrencies = null, float changeTimerColorAtSeconds = 0f, Color? newTimerColor = null)
	{
	}

	public void ShowQuitGamePopup()
	{
	}

	public void ShowAccountBannedPopup()
	{
	}

	public void ShowAccountSuspendedPopup()
	{
	}

	public void ShowGuestWarningPopup(Action callback = null)
	{
	}

	public void ShowClaimedRewardsPopup(List<Reward> rewards, Action dismissCallback = null)
	{
	}

	public void ShowPurchaseRewardsPopup(string title, List<Reward> rewards, Action<IPopup> hideCallback = null)
	{
	}

	public void QueueRewardCalendarPopup(List<RewardCalendarStateServerData> calendarStates, string viewContext, Action<IPopup> hideCallback = null)
	{
	}

	public void ShowOpenedSocialGiftRewardsPopup(List<RewardServerData> rewardServerData)
	{
	}

	public void ShowDeploymentCompletedRewardsPopup(List<RewardServerData> rewardServerData)
	{
	}

	public void ShowConversionRewardsPopup(List<Reward> rewards, Action<IPopup> callback = null)
	{
	}

	public void ShowSGAccountPopup(SGAccountPopupData.AccountAction accountMode, Action completionCallback = null, Action cancelationCallback = null)
	{
	}

	public void ShowForcedUpdatedPopup()
	{
	}

	public void ShowDataLossPopups(Action callback = null)
	{
	}

	public void ShowChangeHandlePopup(bool allowCancel, Action completeCallback, Action cancelCallback)
	{
	}

	public void ShowFightModifiersPopup(Fight fight)
	{
	}

	public void ShowFightModifiersPopup(List<SignatureAbility> signatureAbilities)
	{
	}

	public void ShowFightResultsPopup(WinState winState, Team playerTeam, Team enemyTeam, FightResultServerData fightResultData, bool isTutorial = false, Action callback = null)
	{
	}

	public void ShowLeaderboardDefenseFightHistoryPopup(EventServerData eventServerData, Action claimCallback = null, bool shouldClaimPoints = true, bool riftIsAttackerPerspective = false)
	{
	}

	public void ShowFanfare(string body, string title = null, string subtitle = null, bool skipAllowed = true, AudioClip overrideSFX = null, Action callback = null)
	{
	}

	public void ShowFighterPreview(string variantGuid, List<object> gearStatGuids = null, bool isShiny = false)
	{
	}

	public void ShowFighterPreview(string characterId, bool fromCollection)
	{
	}

	public void ShowFighterPreview(Character character)
	{
	}

	public void ShowGearDetailsPopup(Gear gear, Character character = null, bool highlightDifferences = false, bool isFavoriteButtonEnabled = false, bool allowUpgradeAndSell = false, bool suppressRewardPopupOnSell = false, Action sellCallback = null, Action upgradeCallback = null, Action lockStateChangedCallback = null)
	{
	}

	public void ShowProfilePopup(string publicId)
	{
	}

	public void ShowProfilePopup(Profile profile)
	{
	}

	public void ShowLeavingAppPopup(string bodyTextKey, Action callback)
	{
	}

	public void ShowEnergyRefillPopup(List<Character> notEnoughEnergy, Action refilledCallback, Action teamSelectCallback, Action failedCallback, bool useHC = false)
	{
	}

	public void ShowNodeModifierDetailsPopupForChatActivity(string nodeModifierGuid, string baseCharacterGuid = null, string elementString = null)
	{
	}

	public void ShowNodeModifierDetailsPopup(CollectibleNodeModifier nodeModifier, Action sellCallback = null, Action upgradeCallback = null, Action lockStateChangedCallback = null, bool favoriteButtonValue = false, bool areSellAndUpgradeDisabled = false, bool suppressRewardPopupOnSell = false)
	{
	}

	public void ShowShinyTransferWarningPopupIfNeeded(Action callback, Character currentCharacter, List<Character> foodCharacters)
	{
	}

	public void ShowShinyForfeitWarningPopupIfNeeded(Action callback, Character currentCharacter, List<Character> foodCharacters)
	{
	}

	public void ShowFightReplayPreviewPopup(FightReplayServerData serverData)
	{
	}

	public void ShowRelicOddsPopup(int relicOddsIndex = -1)
	{
	}

	public void ShowFeaturedOfferPopup(FeaturedOfferData featuredOfferData, bool withDismissReminder, OfferData.OfferPopupShownDelegate callback, string additionalContext, bool shouldQueue = true)
	{
	}

	public void ShowPrestigeAbilityUpgradeDetailsPopup(Character character, int newLevel)
	{
	}

	private ContextualPopupItem GetContextualPopupForType(ContextualPopupType popupType)
	{
		return null;
	}

	private void SetupInsufficientCurrencyPopupWithRedirectButton(ref PopupData popupData, string redirectArea, IAPStoreContext? storeContext = null, GachaData reelsScreenContext = null)
	{
	}
}
