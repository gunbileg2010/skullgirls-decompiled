using Bolt;
using UnityEngine;

internal class ClickToMoveCommandInput : Bolt.NetworkCommand_Data, IClickToMoveCommandInput, INetworkCommandData
{
	public Vector3 click
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
