using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BundleOfferPopup : SGUGUIPopup
{
	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private GridLayoutGroup rewardGrid;

	[SerializeField]
	private LocalizedUGUIText rewardGridFeaturedDescriptionText;

	[SerializeField]
	private ContextualPopupItem contextualPopupPrefab;

	[SerializeField]
	private BundleOfferPopupRewardItem rewardItemProtoype;

	[SerializeField]
	private Button relicOddsButton;

	[SerializeField]
	private LocalizedUGUIText popupHeader;

	private BundleOfferView bundleOfferView;

	private OfferData.OfferPopupParams popupParams;

	private OfferServerData serverData;

	private OfferData clientData;

	private ContextualPopupItem contextualPopup;

	private List<BundleOfferPopupRewardItem> rewardItems;

	protected override void Awake()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void UGUI_ShowRelicOdds()
	{
	}

	private void PopulateRewards()
	{
	}

	private void AddRewardItem(Reward reward, string addToDescription = "")
	{
	}

	private void SetHeader()
	{
	}
}
