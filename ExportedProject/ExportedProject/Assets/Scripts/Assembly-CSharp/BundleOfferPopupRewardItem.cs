using UnityEngine;

public class BundleOfferPopupRewardItem : MonoBehaviour
{
	[SerializeField]
	private RewardItem rewardItem;

	[SerializeField]
	private LocalizedUGUIText description;

	[SerializeField]
	private LootType lootFilter;

	public bool Populate(Reward reward, bool showDescription, ContextualPopupItem contextualPopup, string addToDescription = "")
	{
		return false;
	}

	public void Cleanup()
	{
	}
}
