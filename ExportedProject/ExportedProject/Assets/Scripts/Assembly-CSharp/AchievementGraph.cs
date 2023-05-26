using System.Collections.Generic;
using UnityEngine;

public class AchievementGraph : Graph
{
	[SerializeField]
	private string category;

	[SerializeField]
	private List<AchievementNode> rootNodes;

	public string GetCategory()
	{
		return null;
	}

	public void Refresh(bool markToasts = false)
	{
	}

	public int GetClaimableCount()
	{
		return 0;
	}

	public int GetClaimedCount()
	{
		return 0;
	}
}
