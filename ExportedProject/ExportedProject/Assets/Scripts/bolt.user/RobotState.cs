using System;
using Bolt;

internal class RobotState : Bolt.NetworkState, IRobotState, IState, IDisposable
{
	public float AngularSpeed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float Speed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float Shot => 0f;

	public bool PlayerInSight
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float AimWeight => 0f;

	public NetworkTransform Transform => null;
}
