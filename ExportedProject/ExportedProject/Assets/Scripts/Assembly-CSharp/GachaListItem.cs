using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GachaListItem : MonoBehaviour
{
	[Serializable]
	private class GachaPurchaseButton
	{
		public GameObject containingObject;

		public AdvancedButton button;

		public LocalizedUGUIText amountText;

		public LocalizedUGUIText bonusText;
	}

	public delegate void PurchaseCallbackDelegate(GachaListItem gachaListItem, int amount, int denomination);

	[SerializeField]
	private LocalizedUGUIText titleText;

	[SerializeField]
	private LocalizedUGUIText descriptionText;

	[SerializeField]
	private Image gachaImage;

	[SerializeField]
	private RectTransform gachaTransform;

	[SerializeField]
	private Vector3 openButtonGachaImageNudge;

	[SerializeField]
	private GachaPurchaseButton[] purchaseButtons;

	[SerializeField]
	private TimerUI limitedTimeTimer;

	[SerializeField]
	private TeaseStickerParent teaseStickerParent;

	[SerializeField]
	private GameObject openButtonGO;

	[SerializeField]
	private GameObject voucherButtonGO;

	[SerializeField]
	private GachaRewardIcon voucherButtonIcon;

	[SerializeField]
	private float voucherAndClaimBothVisibleButtonYNudge;

	[SerializeField]
	private Badge gachaBadge;

	[SerializeField]
	private Badge voucherBadge;

	[SerializeField]
	private UIGradient backgroundGradient;

	[SerializeField]
	private Color ownedColor;

	[SerializeField]
	private Color unownedColor;

	[SerializeField]
	private GameObject earnOverTimeGO;

	[SerializeField]
	private GameObject readyToClaimGO;

	[SerializeField]
	private GameObject notReadyToClaimGO;

	[SerializeField]
	private TimerUI claimTimer;

	[SerializeField]
	private GameObject gachaShardsGO;

	[SerializeField]
	private Badge gachaShardsBadge;

	[SerializeField]
	private ProgressBarUI gachaShardsProgress;

	[SerializeField]
	private Button gachaShardsClaimButton;

	[HideInInspector]
	public ReelsScreen parentScreen;

	[SerializeField]
	private GameObject relicOddsPanelButton;

	private PurchaseCallbackDelegate purchaseCallback;

	private Action<GachaListItem, bool> openCallback;

	private GameObject indicator;

	public GachaData clientGachaData
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

	public GachaServerData serverGachaData
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

	private string cachedGuid => null;

	public void Populate(GachaServerData data)
	{
	}

	public void Cleanup()
	{
	}

	public void SetPurchaseClickCallback(PurchaseCallbackDelegate callback)
	{
	}

	public void SetOpenClickCallback(Action<GachaListItem, bool> callback)
	{
	}

	public GachaServerData GetGachaServerData()
	{
		return null;
	}

	public void UGUI_PurchaseButtonClicked(int idx)
	{
	}

	public void UGUI_OpenButtonClicked(bool useVoucher = false)
	{
	}

	public void UGUI_MoreInfoButtonClicked()
	{
	}

	public void ShowIndicator(GameObject indicatorPrefab)
	{
	}

	public void HideIndicator()
	{
	}

	private void RefreshPurchaseButtons()
	{
	}

	private void OnTutorialPurchase(GachaListItem item, int amount, int targetDenomination)
	{
	}
}
