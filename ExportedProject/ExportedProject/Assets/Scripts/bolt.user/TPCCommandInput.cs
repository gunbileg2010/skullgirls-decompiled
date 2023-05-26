using Bolt;
using UnityEngine;

internal class TPCCommandInput : Bolt.NetworkCommand_Data, ITPCCommandInput, INetworkCommandData
{
	public Vector3 move
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public bool crouch
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float forward
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float turn
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool jump
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
