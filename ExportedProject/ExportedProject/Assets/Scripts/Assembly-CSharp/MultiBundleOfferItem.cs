using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MultiBundleOfferItem : MonoBehaviour
{
	[SerializeField]
	private BundleOfferView bundleOfferView;

	[SerializeField]
	private BundleOfferPopupRewardItem rewardItemPrefab;

	[SerializeField]
	private RectTransform rewardItemParent;

	[SerializeField]
	private AdvancedButton purchaseButtonObject;

	[SerializeField]
	private LocalizedUGUIText purchaseButtonLocText;

	[SerializeField]
	private GameObject stickerParent;

	[SerializeField]
	private Button relicOddsButton;

	private List<BundleOfferPopupRewardItem> rewardItems;

	private MultiBundleOfferPopup parent;

	public OfferServerData cachedOfferServerData
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Populate(OfferServerData offerServerData, MultiBundleOfferPopup parent)
	{
	}

	public void Cleanup()
	{
	}

	public void UGUI_PurchaseButtonPressed()
	{
	}

	public void UGUI_ShowRelicOdds()
	{
	}

	public bool IsAvailableForPurchase()
	{
		return false;
	}

	public void SetInteractable(bool value)
	{
	}

	private void InternalRefreshUI()
	{
	}
}
