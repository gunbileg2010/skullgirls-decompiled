using System;
using Bolt;

internal class TPCstate : Bolt.NetworkState, ITPCstate, IState, IDisposable
{
	public NetworkTransform transform => null;

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

	public bool grounded
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float jump
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float jumpleg
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}
}
