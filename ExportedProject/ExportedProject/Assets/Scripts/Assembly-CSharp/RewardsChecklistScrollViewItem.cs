using System.Collections.Generic;
using UnityEngine;

public class RewardsChecklistScrollViewItem : RewardsChecklistItem
{
	[SerializeField]
	private RewardScrollView rewardsScrollView;

	public override void Populate(string header, bool completed, List<Loot> loots)
	{
	}

	public override void Clear()
	{
	}
}
