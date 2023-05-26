using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

[ExecuteInEditMode]
public class NodeMap : Graph
{
	[SerializeField]
	private MapNode startingNode;

	[SerializeField]
	private RectTransform boundsRect;

	[SerializeField]
	private GameObject playerIconPrefab;

	private static List<MapNode> mapNodes;

	private bool initialized;

	private ScrollRect scrollRect;

	private GameObject playerIconGO;

	private UILineRenderer pathRenderer;

	private UILineRenderer availablePathRenderer;

	private UILineRenderer lockedPathRenderer;

	private MapNode currentNode;

	private Coroutine movePlayerIconCoroutine;

	private AnimatePosition mapPanAnim;

	private AnimatePosition iconMoveAnim;

	private AnimateScale iconScaleAnim;

	private List<Vector2> completedPoints;

	private List<Vector2> availablePoints;

	private List<Vector2> lockedPoints;

	private bool allNodesUnlocked;

	private bool showPlayerIcon;

	private bool isDefenseMap;

	private bool viewingOpponentProgress;

	public float FirstNodeTravelTime
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float AdditionalNodeTravelTime
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void Init(SGMatch[] matches, NodeMapTileset tileset, Action<MapNode> nodePressedCallback, Action<SGMatch> displayMatchModifiersCallback, bool isDefenseMap = false, bool viewingOpponentProgress = false)
	{
	}

	public void MovePlayerIcon(MapNode toNode, Action atToNodeCallback, bool immediate = false, bool allowScrollAfter = false)
	{
	}

	public void PositionMapAtPlayer(bool immediate = false, bool allowScrollAfter = false)
	{
	}

	public void PositionMapAt(MapNode node, bool immediate = false, bool allowScrollAfter = false)
	{
	}

	public void HideAllGeneralAlerts()
	{
	}

	public void ShowGeneralAlerts(HashSet<string> variantGuidsToActivateAlertsFor)
	{
	}

	public void ShowIndicator(int matchIndex, GameObject indicatorPrefab)
	{
	}

	public void CleanupAllIndicators()
	{
	}

	public void UnlockAll()
	{
	}

	public bool IsPlayerIconMoving()
	{
		return false;
	}

	public RectTransform GetBounds()
	{
		return null;
	}

	public RectTransform GetNodesParent()
	{
		return null;
	}

	public void DisplayCurrentNodeDialog(bool force)
	{
	}

	public void ShowHideDefenseWins(bool show, Dictionary<int, MapNodeProgressServerData> progress, Dictionary<int, List<FightHistoryServerData>> fightHistories, int? nodeMapPositionIndex = null, bool userIsAttacker = false)
	{
	}

	public void PositionPlayerIconByIndex(int index)
	{
	}

	public override GraphConnectionType GetOverrideConnectionType()
	{
		return default(GraphConnectionType);
	}

	private void Refresh()
	{
	}

	private IEnumerator DoMovePlayerIcon(MapNode toNode, Action atToNodeCallback, bool immediate = false, bool allowScrollAfter = false)
	{
		return null;
	}

	private void StopMovePlayerIconRoutine()
	{
	}

	private void PlacePlayerIcon(MapNode atNode)
	{
	}

	private UILineRenderer CreatePathRenderer(string pathName, Texture texture, float width)
	{
		return null;
	}
}
