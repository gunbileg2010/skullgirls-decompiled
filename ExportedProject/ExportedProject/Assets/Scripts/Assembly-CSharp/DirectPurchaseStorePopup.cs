using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectPurchaseStorePopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private TalkingHeadController talkingHead;

	[SerializeField]
	private Canvas talkingHeadSubCanvas;

	[SerializeField]
	private TimerUI timeRemainingUI;

	[SerializeField]
	private DirectPurchaseStoreTabButton[] tabButtons;

	[SerializeField]
	private ToggleGroupRowController tabUnderline;

	[SerializeField]
	private Sprite[] tabIconRefs;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private DirectPurchaseStoreItem refItem;

	[SerializeField]
	private RectTransform[] rowRefs;

	[SerializeField]
	private ContextualTutorial contextTutorial;

	[SerializeField]
	private PopupData invalidOfferPopup;

	[SerializeField]
	private GameObject internalLoadingIndicator;

	[SerializeField]
	private int maxItemSlotsPerRow;

	private List<DirectPurchaseStoreItem> itemSlots;

	private DirectPurchaseStoreServerData storeData;

	private string currentStoreType;

	private bool ignoreToggles;

	private int topBarPrevElementMask;

	private string topBarPrevCurrencyLayout;

	private string currentMapping;

	protected override void Awake()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void PurchaseStoreItem(DirectPurchaseStoreItem sourceItem)
	{
	}

	public void UGUI_RefreshAll()
	{
	}

	public void ShowMapping(string mapping)
	{
	}

	private void HandleClockTimeout()
	{
	}

	private void Populate()
	{
	}

	private void PopulateOffers(string storeType)
	{
	}

	private void RefreshTabVisuals()
	{
	}

	private void LogPurchaseMetrics(DirectPurchaseStoreItem item)
	{
	}

	private void LogItemMetrics()
	{
	}

	private string GetImpressionConversionPrefix()
	{
		return null;
	}

	private void HandleDataRefresh(DirectPurchaseStoreServerData newStoreData, bool isFirstOpen = false)
	{
	}
}
