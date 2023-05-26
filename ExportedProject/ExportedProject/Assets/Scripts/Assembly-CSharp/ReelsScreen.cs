using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelsScreen : MonoBehaviour
{
	[SerializeField]
	private GachaListItem reelItemPrefab;

	[SerializeField]
	private ScrollList scrollList;

	[SerializeField]
	private AutoScrollingList topLootDisplay;

	[SerializeField]
	private FilmstripLootContainer topLootContainerPrefab;

	[SerializeField]
	private AudioClip intro;

	[SerializeField]
	private AudioClip loop;

	private List<GachaListItem> gachaListItems;

	private ObjectPool<FilmstripLootContainer> topLootContainerObjectPool;

	private List<FilmstripLootContainer> topLootContainers;

	private List<Loot> topLoot;

	private int topLootIndex;

	private GachaData previousGachData;

	private int previousGachaIndex;

	private bool transitioningBetweenListItems;

	private static bool tutorialMode;

	private void Awake()
	{
	}

	public void EnterTutorialMode()
	{
	}

	public void PointAtGacha(int gachaIndex, GameObject indicatorPrefab)
	{
	}

	public int GachaListItemIndex(GachaListItem item)
	{
		return 0;
	}

	public void ScrollToGachaListIndex(int index)
	{
	}

	public int GetGachaScrollListIndex()
	{
		return 0;
	}

	public void GachaItemTimedOut(GachaListItem timedOutItem)
	{
	}

	private IEnumerator OnStateEntered(IGameState prevState, object context)
	{
		return null;
	}

	private IEnumerator OnStateExited(IGameState nextState)
	{
		return null;
	}

	private void RefreshGachaList(object context = null)
	{
	}

	private void OnGachaOpenButtonClicked(GachaListItem item, bool useVoucher)
	{
	}

	private void OnGachaClaimButtonClicked(GachaListItem item, int amount, int targetDenominationIndex)
	{
	}

	private void OnGachaPurchaseButtonClicked(GachaListItem item, int amount, int targetDenominationIndex)
	{
	}

	private void OnGachaPurchaseButtonClicked(GachaListItem item, int amount, int targetDenominationIndex, bool isVoucherPurchase)
	{
	}

	private void OnScrollListItemFocused(ScrollListItem item)
	{
	}

	private void OnScrollListItemUnfocused(ScrollListItem item)
	{
	}

	private GameObject OnAddItem()
	{
		return null;
	}

	private void OnRemoveItem(GameObject objectToRemove)
	{
	}

	private FilmstripLootContainer CreateNewLootContainer()
	{
		return null;
	}
}
