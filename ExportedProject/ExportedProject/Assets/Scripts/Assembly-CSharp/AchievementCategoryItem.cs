using UnityEngine;

public class AchievementCategoryItem : MonoBehaviour
{
	[SerializeField]
	private LocalizedUGUIText categoryText;

	[SerializeField]
	private LocalizedUGUIText progressText;

	[SerializeField]
	private Badge badge;

	private AchievementGraph achievementGraph;

	public void Populate(AchievementGraph achievementGraph)
	{
	}

	public void Refresh()
	{
	}

	public AchievementGraph GetAchievementGraph()
	{
		return null;
	}
}
