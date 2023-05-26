using System;
using Bolt;
using UnityEngine;

internal class LobbyPlayerInfoState : Bolt.NetworkState, ILobbyPlayerInfoState, IState, IDisposable
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
