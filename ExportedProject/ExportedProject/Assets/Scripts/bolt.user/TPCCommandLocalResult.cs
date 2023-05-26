using Bolt;
using UnityEngine;

internal class TPCCommandLocalResult : Bolt.NetworkCommand_Data, ITPCCommandLocalResult, INetworkCommandData
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
}
