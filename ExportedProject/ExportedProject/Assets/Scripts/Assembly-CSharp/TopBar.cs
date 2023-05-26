using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopBar : MonoSingleton<TopBar>
{
	public enum TopBarUIElement
	{
		Settings = 1,
		Profile = 2,
		Back = 4,
		Home = 8,
		Currencies = 0x10,
		ChatShort = 0x100000,
		ChatFull = 0x200000
	}

	public const int kHidden = 0;

	public const int kBackAndHome = 12;

	public const int kBackHomeChat = 1048588;

	public const int kProfileCur = 18;

	public const int kProfileCurBack = 22;

	public const int kProfileCurBackHome = 30;

	public const int kProfileCurBackHomeChatShort = 1048606;

	public const int kProfileCurBackHomeChatFull = 2097182;

	private const int kProfileSection = 15;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private Canvas navigationCanvas;

	[SerializeField]
	private Button settingsButton;

	[SerializeField]
	private Button backButton;

	[SerializeField]
	private Button homeButton;

	[SerializeField]
	private Button chatButton;

	[SerializeField]
	private GameObject chatPreview;

	[SerializeField]
	private Transform backButtonTarget;

	[SerializeField]
	private PlayerSummary playerSummary;

	[SerializeField]
	private Badge profileBadge;

	[SerializeField]
	private Canvas currenciesCanvas;

	[SerializeField]
	private CanvasGroup currenciesCanvasGroup;

	[SerializeField]
	private TopBarCurrencyItem[] topBarCurrencyItemPool;

	[SerializeField]
	private AdvancedButton claimDailyEventTicketsButton;

	[SerializeField]
	private GameObject claimDailyEventTicketsHelpButton;

	[SerializeField]
	private Badge claimDailyEventTicketsBadge;

	private static bool tutorialMode;

	private int disabledButtonMask;

	private int currentConfiguration;

	private readonly List<CurrencyType> currencyTypePriorityList;

	private SortedList<int, TopBarCurrencyItem> activeTopBarCurrencyItems;

	private string prevCurrencyConfig;

	private int prevNavConfig;

	private bool prevCurrencyPoppedToTop;

	protected override void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected override void OnDestroy()
	{
	}

	public static void SetTutorialMode(bool active)
	{
	}

	public int GetCurrentConfiguration()
	{
		return 0;
	}

	public bool IsShowing()
	{
		return false;
	}

	public void RefreshBestCharacter()
	{
	}

	public void AddToDisabledButtonMask(int input)
	{
	}

	public void RemoveFromDisabledButtonMask(int input)
	{
	}

	public void DEBUG_ClearDisabledButtonMask()
	{
	}

	public void DEBUG_ResetDefaultVisibilityOnSplash()
	{
	}

	public void SetPoppedToTop(bool popToTop)
	{
	}

	public void SetCurrencyPoppedToTop(bool popToTop)
	{
	}

	public void RefreshVisibility(int elementMask, bool immediate = false)
	{
	}

	public void Refresh()
	{
	}

	public void RefreshTutorialVisibility(int elementMask, bool immediate = false)
	{
	}

	public Transform GetPosition(IndicatorTarget target)
	{
		return null;
	}

	public void ResetCurrencyTypesBeingDisplayed()
	{
	}

	public void AddCurrencyToBeDisplayed(Currency currency)
	{
	}

	public void AddCurrencyTypeToBeDisplayed(CurrencyType type)
	{
	}

	public void AddCurrencyTypeToBeDisplayed(CurrencyType type, Element? contextElement)
	{
	}

	public void AddCurrencyTypeToBeDisplayed(CurrencyType type, RarityTier? contextRarity)
	{
	}

	public void AddCurrencyTypeToBeDisplayed(CurrencyType type, BaseCharacterData contextBaseCharacter)
	{
	}

	public TopBarCurrencyItem GetVisibleCurrencyTypeDisplay(CurrencyType type)
	{
		return null;
	}

	public TopBarCurrencyItem GetVisibleCurrencyTypeDisplay(CurrencyType type, Element contextElement)
	{
		return null;
	}

	public TopBarCurrencyItem GetVisibleCurrencyTypeDisplay(CurrencyType type, RarityTier contextRarity)
	{
		return null;
	}

	public TopBarCurrencyItem GetVisibleCurrencyTypeDisplay(CurrencyType type, BaseCharacterData contextBaseCharacter)
	{
		return null;
	}

	public string GetCurrentCurrencyDisplayConfig()
	{
		return null;
	}

	public bool GetCurrencyPoppedToTop()
	{
		return false;
	}

	public void RestoreCurrencyDisplayFromConfigString(string config)
	{
	}

	public void AddTempCurrency(Price price)
	{
	}

	public void RevertToPrevCurrencyConfig()
	{
	}

	public void SetClaimDailyEventTicketsButtonActive(bool active)
	{
	}

	public void RefreshClaimDailyEventTicketsButton(bool hasClaimedTickets)
	{
	}

	public void DisableHomeAndBackButton()
	{
	}

	public void UGUI_HomeButtonClicked()
	{
	}

	public void UGUI_BackButtonClicked()
	{
	}

	public void UGUI_ProfileClicked()
	{
	}

	public void UGUI_OptionsClicked()
	{
	}

	public void UGUI_ChatClicked()
	{
	}

	public void UGUI_ClaimDailyEventTicketsClicked()
	{
	}

	private bool IsButtonDisabled(TopBarUIElement type)
	{
		return false;
	}

	private bool IsElementVisible(TopBarUIElement type, int mask)
	{
		return false;
	}

	private void ToggleSettingsButton(bool active)
	{
	}

	private void ToggleBackButton(bool active)
	{
	}

	private void ToggleHomeButton(bool active)
	{
	}

	private void ToggleChatShort(bool active)
	{
	}

	private void ToggleChatFull(bool active)
	{
	}

	private void ToggleProfileSection(bool active, bool immediate)
	{
	}

	private void ToggleProfile(bool active, bool immediate)
	{
	}

	private void ToggleCurrencyGroup(bool active, bool immediate)
	{
	}

	private void Refresh(int elementMask, bool immediate = false)
	{
	}

	private void OnCurrenciesChanged(int softCurrency, int hardCurrency)
	{
	}

	private void OnProfileUpdated(Profile profile)
	{
	}

	private void OnChatInitialized()
	{
	}

	private TopBarCurrencyItem GetVisibleCurrencyTypeDisplay(CurrencyType type, Element? contextElement, RarityTier? contextRarity, BaseCharacterData contextBaseCharacter)
	{
		return null;
	}

	private void AddCurrencyTypeToBeDisplayed(CurrencyType type, Element? contextElement, RarityTier? contextRarity, BaseCharacterData contextBaseCharacter)
	{
	}

	private int GetListPriorityKey(CurrencyType type, Element? element, RarityTier? rarity, BaseCharacterData baseCharacter)
	{
		return 0;
	}

	private void UpdateCurrencyItemsDisabledState()
	{
	}

	private void CurrencyItemsCallback(CurrencyType type)
	{
	}

	public TopBar()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
