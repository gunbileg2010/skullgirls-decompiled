using System;
using Bolt;
using UnityEngine;

internal class ElevatorState : Bolt.NetworkState, IElevatorState, IState, IDisposable
{
	public Vector3 NewProperty
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
