using UnityEngine;

public class DirectPurchaseStoreItem : MonoBehaviour
{
	public const string kPurchaseConfirmationAllTinted = "<color=#{0}>---{1}---</color>";

	public const string kPurchaseConfirmationPrefixTinted = "<color=#{0}>---{1}---</color>+++{2}";

	[SerializeField]
	private AdvancedButton purchaseButton;

	[SerializeField]
	private LocalizedUGUIText headerText;

	[SerializeField]
	private RewardItem rewardItem;

	[SerializeField]
	private PopupData fighterPreview;

	[SerializeField]
	private GameObject purchasedGroupParent;

	private DirectPurchaseOfferServerData cachedItemData;

	private DirectPurchaseStorePopup parent;

	public void Populate(DirectPurchaseStorePopup parent, DirectPurchaseOfferServerData directPurchaseItemData, string storeType)
	{
	}

	public void Clear()
	{
	}

	public void MarkAsPurchased()
	{
	}

	public DirectPurchaseOfferServerData GetItemData()
	{
		return null;
	}

	public string GetItemHumanReadableGUID()
	{
		return null;
	}

	public Price GetPrice()
	{
		return null;
	}

	public string GetHeaderLocKey()
	{
		return null;
	}

	public string GetItemConfirmPurchaseText()
	{
		return null;
	}

	public void UGUI_Buy()
	{
	}

	public void UGUI_MoreInfo()
	{
	}

	public void SetPurchased(bool purchased)
	{
	}

	private BaseCharacterData GetAssociatedBaseCharacter(Loot loot)
	{
		return null;
	}
}
