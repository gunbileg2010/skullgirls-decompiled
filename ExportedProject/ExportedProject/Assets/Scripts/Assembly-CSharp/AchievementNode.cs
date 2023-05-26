using UnityEngine;

[ExecuteInEditMode]
public class AchievementNode : GraphNode
{
	[SerializeField]
	private AchievementData achievementData;

	public AchievementData GetAchievementData()
	{
		return null;
	}

	public Achievement GetAchievement()
	{
		return null;
	}

	public bool IsCompleted()
	{
		return false;
	}

	public bool IsClaimed()
	{
		return false;
	}

	public bool IsUnlocked()
	{
		return false;
	}

	public void Unlock()
	{
	}

	public override GraphConnectionType GetConnectionType(GraphNode connection, object context)
	{
		return default(GraphConnectionType);
	}
}
