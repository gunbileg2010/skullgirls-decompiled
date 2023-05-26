using System;
using Bolt;
using UnityEngine;

internal class BomberState : Bolt.NetworkState, IBomberState, IState, IDisposable
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

	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}
}
