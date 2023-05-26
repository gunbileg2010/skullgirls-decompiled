using UnityEngine;

public class StatusItemWithReward : StatusItem
{
	[SerializeField]
	private RewardItem rewardItem;

	public override void Populate(string title, string description, Status status)
	{
	}

	public void Populate(string title, string description, Status status, Loot lootToShow)
	{
	}
}
