using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementsView : MonoBehaviour
{
	[SerializeField]
	private Badge badge;

	[SerializeField]
	private ToggleGroupRowController categoryToggleController;

	[SerializeField]
	private AchievementCategoryItem categoryPrototype;

	[SerializeField]
	private RectTransform graphParent;

	[SerializeField]
	private ScrollRect graphScrollRect;

	[SerializeField]
	private GraphRenderer graphRenderer;

	[SerializeField]
	private AchievementNodeUI achievementNodePrefab;

	[SerializeField]
	private GameObject nodeInfoGO;

	[SerializeField]
	private LocalizedUGUIText nodeInfoTitleText;

	[SerializeField]
	private LocalizedUGUIText nodeInfoDescriptionText;

	[SerializeField]
	private LocalizedUGUIText nodeInfoProgressText;

	[SerializeField]
	private AchievementNodeUI rewardIcon;

	[SerializeField]
	private GameObject nodeInfoLockedGo;

	[SerializeField]
	private GameObject nodeInfoInProgressGo;

	[SerializeField]
	private GameObject nodeInfoClaimedGO;

	private List<AchievementCategoryItem> categoryItems;

	private List<GameObject> graphGOs;

	private List<List<AchievementNodeUI>> graphNodeUIs;

	private List<Vector2> graphScrollMemory;

	private int graphIndex;

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void ParentPopupHide()
	{
	}

	public void RefreshBadge()
	{
	}

	public void UGUI_OnClickOutsideNodeInfoPopup()
	{
	}

	public void UGUI_TestToast()
	{
	}

	private void ShowGraph(int index)
	{
	}

	private void RefreshStates()
	{
	}

	private void ShowNodeInfo(AchievementNode node, AchievementData achievementData, Achievement achievement, bool isUnlocked)
	{
	}

	private void HideNodeInfo()
	{
	}

	private void OnCategoryToggleActivated(Toggle toggle)
	{
	}

	private void OnAchievementNodePressed(AchievementNodeUI nodeUI)
	{
	}
}
