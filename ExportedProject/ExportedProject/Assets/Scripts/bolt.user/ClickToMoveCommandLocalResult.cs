using Bolt;
using UnityEngine;

internal class ClickToMoveCommandLocalResult : Bolt.NetworkCommand_Data, IClickToMoveCommandLocalResult, INetworkCommandData
{
	public Vector3 position
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}
}
