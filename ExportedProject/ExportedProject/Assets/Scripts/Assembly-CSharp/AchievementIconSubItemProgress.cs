using UnityEngine;

public class AchievementIconSubItemProgress : AchievementIconSubItemBase
{
	[SerializeField]
	private GameObject progressParent;

	[SerializeField]
	private LocalizedUGUIText progressText;

	public override void Refresh(Achievement achievement, AchievementData achievementData, Achievement.Status status, bool locked)
	{
	}
}
