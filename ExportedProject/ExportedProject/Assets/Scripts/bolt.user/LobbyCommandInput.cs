using Bolt;
using UnityEngine;

internal class LobbyCommandInput : Bolt.NetworkCommand_Data, ILobbyCommandInput, INetworkCommandData
{
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

	public bool Ready
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
