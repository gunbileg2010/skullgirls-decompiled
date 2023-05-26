using Bolt;
using UnityEngine;

internal class PlayerCommandLocalResult : Bolt.NetworkCommand_Data, IPlayerCommandLocalResult, INetworkCommandData
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

	public Vector3 velocity
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public int jumpFrames
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool isGrounded
	{
		get
		{
			return false;
		}
		set
		{
		}
	}
}
