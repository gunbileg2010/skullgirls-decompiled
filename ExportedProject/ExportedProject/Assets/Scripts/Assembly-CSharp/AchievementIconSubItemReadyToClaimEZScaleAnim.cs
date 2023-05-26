using UnityEngine;

public class AchievementIconSubItemReadyToClaimEZScaleAnim : AchievementIconSubItemBase
{
	[SerializeField]
	private ScaleEZSelfContainedAnimator ezScaleAnim;

	public override void Refresh(Achievement achievement, AchievementData achievementData, Achievement.Status status, bool locked)
	{
	}
}
