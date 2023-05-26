using System.Collections.Generic;
using UnityEngine;

public class LoginRewardsCalendarItem : RewardsChecklistItem
{
	[SerializeField]
	private AnimationHelper checkmarkAnimationHelper;

	[SerializeField]
	private RewardItem rewardItem;

	[SerializeField]
	private float rewardHeight;

	public override void Populate(string header, bool completed, List<Loot> loots)
	{
	}

	public void Populate(string header, bool completed, Loot loot, bool animate = false, RewardCalendar.CalenderIconOverride overrideIcon = null)
	{
	}

	public override void Clear()
	{
	}
}
