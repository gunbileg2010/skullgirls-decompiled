using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GearDetailsView : MonoBehaviour
{
	public Action GearSold;

	public Action GearUpgraded;

	public Action GearLockStateChanged;

	public Action GearUpgradeOfferPurchased;

	[SerializeField]
	private Transform iconAnchor;

	[SerializeField]
	private Text gearPointText;

	[SerializeField]
	private GameObject unblockableGO;

	[SerializeField]
	private GameObject informationAnchor;

	[SerializeField]
	private LocalizedUGUIText gearNameText;

	[SerializeField]
	private Image characterTypeSigil;

	[SerializeField]
	private Toggle favoriteToggle;

	[SerializeField]
	private FavoriteButtonController favoriteButtonLogic;

	[SerializeField]
	private GearStatsContainerView statsContainerView;

	[SerializeField]
	private GameObject buttonsGO;

	[SerializeField]
	private AdvancedButton sellButton;

	[SerializeField]
	private AdvancedButton upgradeButton;

	[SerializeField]
	private GameObject rerollButton;

	[SerializeField]
	private GameObject closeButtonGO;

	[SerializeField]
	private GameObject abilityTextGO;

	[SerializeField]
	private LocalizedUGUIText abilityLevelText;

	[SerializeField]
	private Image abilityBackground;

	[SerializeField]
	private GameObject abilityLockedGO;

	[SerializeField]
	private GameObject abilityUnlockedGO;

	[SerializeField]
	private Sprite abilityLockedBackground;

	[SerializeField]
	private Sprite abilityUnlockedBackground;

	[SerializeField]
	private MasterPopupData confirmSellGearPopupData;

	[SerializeField]
	private MasterPopupData confirmUpgradeGearPopupData;

	[SerializeField]
	private MasterPopupData sellLockedPopupData;

	[SerializeField]
	private RewardsPopupData rewardsPopupData;

	[SerializeField]
	private MasterPopupData statRerollPopupData;

	[SerializeField]
	private MasterPopupData statRerollResultsPopupData;

	[SerializeField]
	private Animator gearUpgradeFanfare;

	[SerializeField]
	private LocalizedUGUIText gearUpgradeFanfareHeader;

	private Character character;

	private GearCard gearCard;

	private Gear gear;

	private bool isGearInitiallyLocked;

	private Currency upgradeCost;

	private bool tutorialMode;

	private bool isSellAndUpgradeAllowed;

	private bool isSellRequestInProgress;

	private bool suppressRewardsPopupOnSell;

	private int savedNavConfig;

	private string savedCurrencyConfig;

	private int previousRerolledStatIndex;

	private void OnEnable()
	{
	}

	public void SetTutorialMode(bool active)
	{
	}

	public void UGUI_CloseButtonPressed()
	{
	}

	public void FireLockRequest(Action LocalCallback = null)
	{
	}

	public void UGUI_LockGearToggle()
	{
	}

	public void UGUI_FanfareSkipPressed()
	{
	}

	public void UGUI_DEBUG_RerollStatsPressed()
	{
	}

	public void Release()
	{
	}

	public void SetSellAndUpgradeAllowed(bool status)
	{
	}

	public void SetSuppressRewardsOnSell(bool status)
	{
	}

	public void Populate(Gear gear, Character character = null, bool highlightDifferences = false, bool isFavoriteButtonEnabled = false)
	{
	}

	public void UGUI_SellMove()
	{
	}

	public void UGUI_UpgradeMove()
	{
	}

	public void UGUI_RerollStatsButtonPressed()
	{
	}

	public Gear GetGear()
	{
		return null;
	}

	public Character GetCharacter()
	{
		return null;
	}

	public void StatsUpdated()
	{
	}

	public int GetPreviousRerolledStatIndex()
	{
		return 0;
	}

	public void SetPreviousRerolledStatIndex(int index)
	{
	}

	public void RestoreTopBarFromRerollPopups()
	{
	}

	private IEnumerator ExecuteNextFrame(Action method)
	{
		return null;
	}

	private void InitiateSellConfirmation()
	{
	}

	private void SellGear()
	{
	}

	private void UpgradeGear()
	{
	}

	private GearCard GetIcon(GearCard gearCardRef)
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

	private void SetTopBarForRerollPopups()
	{
	}

	private IEnumerator DoCheckOffersAfterFanfare()
	{
		return null;
	}
}
