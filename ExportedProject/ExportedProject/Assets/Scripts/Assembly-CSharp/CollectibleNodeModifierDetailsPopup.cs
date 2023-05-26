using System;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleNodeModifierDetailsPopup : SGUGUIPopup
{
	public class Context
	{
		public CollectibleNodeModifier modifier;

		public bool isFavoriteEnabled;

		public bool areSellAndUpgradeDisabled;

		public bool suppressRewardPopupOnSell;
	}

	public Action NodeModifierSold;

	public Action NodeModifierUpgraded;

	public Action NodeModifierLockStateChanged;

	[SerializeField]
	private Transform iconAnchor;

	[SerializeField]
	private LocalizedUGUIText modifierNameText;

	[SerializeField]
	private GameObject buttonsGO;

	[SerializeField]
	private AdvancedButton sellButton;

	[SerializeField]
	private AdvancedButton upgradeButton;

	[SerializeField]
	private Toggle favoriteToggle;

	[SerializeField]
	private FavoriteButtonController favoriteButtonLogic;

	[SerializeField]
	private LocalizedUGUIText abilityText;

	[SerializeField]
	private MasterPopupData confirmSellPopupData;

	[SerializeField]
	private MasterPopupData confirmUpgradePopupData;

	[SerializeField]
	private MasterPopupData sellLockedPopupData;

	[SerializeField]
	private RewardsPopupData rewardsPopupData;

	private CollectibleNodeModifier collectibleNodeModifier;

	private CollectibleNodeModifierCard collectibleNodeModifierCard;

	private CollectibleNodeModifierData collectibleNodeModifierData;

	private Currency upgradeCost;

	private Context recievedDataAsContext;

	private bool isNodeModifierInitiallyLocked;

	private bool isSellRequestInProgress;

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public override void SetData(PopupData newPopupData)
	{
	}

	public void Release()
	{
	}

	public void Populate()
	{
	}

	public void UGUI_LockNodeModifierToggle()
	{
	}

	public void UGUI_SellNodeModifier()
	{
	}

	public void UGUI_UpgradeNodeModifier()
	{
	}

	private void FireLockRequest(Action LocalCallback = null)
	{
	}

	private void InitiateSellConfirmation()
	{
	}

	private void SellNodeModifier()
	{
	}

	private void UpgradeCollectibleNodeModifier()
	{
	}

	private CollectibleNodeModifierCard GetIcon()
	{
		return null;
	}

	private Currency GetSalePrice()
	{
		return null;
	}

	private Currency GetCostForUpgrade(int currentLevel, int desiredLevel)
	{
		return null;
	}

	private void SetSignatureAbility(SignatureAbility signatureAbility)
	{
	}

	private void ToggleButtonInteractivity(bool active)
	{
	}

	private void ConstructAndSendUpgradeActivityMessage()
	{
	}
}
