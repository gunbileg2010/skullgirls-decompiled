using System;
using Bolt;

internal class PlayerState : Bolt.NetworkState, IPlayerState, IState, IDisposable
{
	public NetworkTransform transform => null;

	public int team
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float pitch
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int weapon
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int kills
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int deaths
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool Dead
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int respawnFrame
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int health
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float MoveZ
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float MoveX
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Action OnJump
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool Aiming
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Action OnFire
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public IProtocolToken tokenTest
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void Jump()
	{
	}

	public void Fire()
	{
	}
}
