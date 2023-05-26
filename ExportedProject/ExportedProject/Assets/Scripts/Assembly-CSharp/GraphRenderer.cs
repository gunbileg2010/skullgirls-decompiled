using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.Extensions;

public class GraphRenderer : MonoBehaviour
{
	[SerializeField]
	private UILineRenderer normalConnection;

	[SerializeField]
	private UILineRenderer availableConnection;

	[SerializeField]
	private UILineRenderer lockedConnection;

	private List<Vector2> normalPoints;

	private List<Vector2> availablePoints;

	private List<Vector2> lockedPoints;

	public void RefreshPaths(Graph graph, object context = null)
	{
	}
}
