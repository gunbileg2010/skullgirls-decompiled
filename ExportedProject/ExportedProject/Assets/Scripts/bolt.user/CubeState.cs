using System;
using Bolt;
using UnityEngine;

internal class CubeState : Bolt.NetworkState, ICubeState, IState, IDisposable
{
	public NetworkTransform CubeTransform => null;

	public Color CubeColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public NetworkArray_Objects<WeaponSlot> WeaponArray => null;

	public int WeaponActiveIndex
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
