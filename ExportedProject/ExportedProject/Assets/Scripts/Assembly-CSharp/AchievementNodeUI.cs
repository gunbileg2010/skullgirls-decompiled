using System;
using UnityEngine;

public class AchievementNodeUI : MonoBehaviour
{
	[SerializeField]
	private LocalizedUGUIText titleText;

	[SerializeField]
	private Transform iconPrefabParent;

	[SerializeField]
	private GameObject lockedGO;

	[SerializeField]
	private GameObject claimedGo;

	[SerializeField]
	private GameObject readyToClaimGlow;

	[SerializeField]
	private LocalizedUGUIText statusText;

	[SerializeField]
	private UIGradient32 statusGradient;

	private AchievementNode achievementNode;

	private Action<AchievementNodeUI> pressCallback;

	private AchievementIcon spawnedAchievementIconPrefab;

	public void Populate(AchievementNode achievementNode, Action<AchievementNodeUI> pressCallback)
	{
	}

	public void Refresh()
	{
	}

	public AchievementNode GetAchievementNode()
	{
		return null;
	}

	public void UGUI_OnNodePressed()
	{
	}

	public bool IsUnlocked()
	{
		return false;
	}
}
