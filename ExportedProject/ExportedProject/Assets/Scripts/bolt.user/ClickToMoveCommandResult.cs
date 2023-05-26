using Bolt;
using UnityEngine;

internal class ClickToMoveCommandResult : Bolt.NetworkCommand_Data, IClickToMoveCommandResult, INetworkCommandData
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
