using System;
using Bolt;
using UnityEngine;

public interface ILobbyPlayerInfoState : IState, IDisposable
{
	Color Color { get; set; }

	string Name { get; set; }

	bool Ready { get; set; }
}
