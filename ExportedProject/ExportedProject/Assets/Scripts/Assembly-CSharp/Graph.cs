using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Graph : MonoBehaviour
{
	[NonSerialized]
	private List<GraphNode> allNodes;

	private Queue<GraphNode> toVisit;

	private List<GraphNode> visited;

	private Dictionary<GraphNode, GraphNode> visitedFrom;

	protected virtual void Update()
	{
	}

	public List<GraphNode> GetNodes()
	{
		return null;
	}

	public void TraverseNodesBFS<T>(T startNode, Action<T> nodeCallback) where T : GraphNode
	{
	}

	public List<T> FindPathFromTo<T>(T startNode, T endNode) where T : GraphNode
	{
		return null;
	}

	public virtual GraphConnectionType GetOverrideConnectionType()
	{
		return default(GraphConnectionType);
	}
}
