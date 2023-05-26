using System.Collections.Generic;
using UnityEngine;

public class GraphNode : MonoBehaviour
{
	[SerializeField]
	protected List<GraphNode> connections;

	protected virtual void OnDrawGizmos()
	{
	}

	public void AddConnection(GraphNode connection)
	{
	}

	public List<GraphNode> GetConnections()
	{
		return null;
	}

	public virtual GraphConnectionType GetConnectionType(GraphNode connection, object context)
	{
		return default(GraphConnectionType);
	}
}
