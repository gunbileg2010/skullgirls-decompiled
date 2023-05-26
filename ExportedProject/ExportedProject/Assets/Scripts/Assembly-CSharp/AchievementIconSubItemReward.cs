using UnityEngine;

public class AchievementIconSubItemReward : AchievementIconSubItemBase
{
	[SerializeField]
	private RewardItem rewardItem;

	[SerializeField]
	private LocalizedUGUIText countText;

	private void OnDisable()
	{
	}

	public override void Refresh(Achievement achievement, AchievementData achievementData, Achievement.Status status, bool locked)
	{
	}
}
