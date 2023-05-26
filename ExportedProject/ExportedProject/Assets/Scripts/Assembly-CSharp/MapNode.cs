using System;
using UnityEngine;

public class MapNode : GraphNode
{
	[SerializeField]
	private int matchIndex;

	[SerializeField]
	private bool visibleWhenLocked;

	private SGMatch match;

	private MapNodeGraphics mapNodeGraphics;

	private Action<SGMatch> displayMatchModifiersCallback;

	private Action<MapNode> nodePressedCallback;

	private bool isDefenseNode;

	private bool viewingOpponentProgress;

	protected override void OnDrawGizmos()
	{
	}

	public void Init(SGMatch myMatch, NodeMapTileset tileset, Action<MapNode> nodePressedCallback, Action<SGMatch> displayMatchModifiersCallback, bool isDefenseNode = false, bool viewingOpponentProgress = false)
	{
	}

	public void Refresh()
	{
	}

	public bool IsCompleted()
	{
		return false;
	}

	public void Unlock()
	{
	}

	public bool IsUnlocked()
	{
		return false;
	}

	public void SetMatchIndex(int index)
	{
	}

	public int GetMatchIndex()
	{
		return 0;
	}

	public SGMatch GetMatch()
	{
		return null;
	}

	public MapNodeGraphics GetMapNodeGraphics()
	{
		return null;
	}

	public MatchType GetNodeType()
	{
		return default(MatchType);
	}

	public Transform GetIconMarker()
	{
		return null;
	}

	public Vector3 GetFocusPosition()
	{
		return default(Vector3);
	}

	public void DisplayDialog(bool force, Action<IPopup> callback = null)
	{
	}

	public bool HasDialog()
	{
		return false;
	}

	public bool IsViewingOpponentsProgress()
	{
		return false;
	}

	public override GraphConnectionType GetConnectionType(GraphNode connection, object context)
	{
		return default(GraphConnectionType);
	}

	public void UGUI_NodePressed()
	{
	}

	public void UGUI_MatchModifierButtonPressed()
	{
	}
}
