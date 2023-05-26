using Bolt;

internal class PlayerCommandInput : Bolt.NetworkCommand_Data, IPlayerCommandInput, INetworkCommandData
{
	public bool forward
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool backward
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool left
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool right
	{
		get
		{
			return false;
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

	public float yaw
	{
		get
		{
			return 0f;
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

	public bool aiming
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool fire
	{
		get
		{
			return false;
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
}
