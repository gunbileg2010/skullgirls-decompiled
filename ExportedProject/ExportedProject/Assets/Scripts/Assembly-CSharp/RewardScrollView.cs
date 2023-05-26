using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RewardScrollView : MonoBehaviour, IBeginDragHandler, IEventSystemHandler
{
	[SerializeField]
	private int allowScrollingAfterCount;

	[SerializeField]
	private TextAlignment alignment;

	private ScrollRect scrollRect;

	private List<RewardItem> rewardItems;

	private bool userWantsToSkipAnims;

	private RewardItem lastRewardItem;

	public ScrollRect ScrollRect => null;

	public event Action<RarityTier, int> ShowGachaShards
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public IEnumerator ShowRewards(List<Reward> rewards)
	{
		return null;
	}

	public IEnumerator ShowRewards(List<RewardServerData> rewardServerData)
	{
		return null;
	}

	public IEnumerator ShowReward(Reward reward, bool isNested = false, RewardItem.DisplayOptions extraOptions = null)
	{
		return null;
	}

	public IEnumerator ShowLoots(List<Loot> loots, bool immediate = false)
	{
		return null;
	}

	public IEnumerator ShowLoot(Loot loot, Reward reward = null, bool immediate = false, bool isNested = false, RewardItem.DisplayOptions extraOptions = null)
	{
		return null;
	}

	public void Clear()
	{
	}

	public void SkipToEnd()
	{
	}

	public void SetPosition(float pos)
	{
	}

	public void SetAlignment(TextAlignment alignment)
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public List<RewardItem> GetRewardItems()
	{
		return null;
	}

	public void SetAllowScrollingAfterCount(int itemCount)
	{
	}

	private void RefreshScrollRectEnabled()
	{
	}
}
