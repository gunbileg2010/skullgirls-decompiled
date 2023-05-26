using UnityEngine;
using UnityEngine.UI;

public class AchievementIcon : MonoBehaviour
{
	[SerializeField]
	private Image templateImage;

	[SerializeField]
	private AchievementIconSubItemBase[] subitems;

	public void Refresh(Achievement achievement, AchievementData achievementData, Achievement.Status status, bool locked)
	{
	}
}
