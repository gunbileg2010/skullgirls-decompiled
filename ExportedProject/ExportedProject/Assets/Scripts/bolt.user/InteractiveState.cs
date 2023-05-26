using System;
using Bolt;
using UnityEngine;

internal class InteractiveState : Bolt.NetworkState, IInteractiveState, IState, IDisposable
{
	public NetworkTransform Transform => null;

	public Color Color
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}
}
