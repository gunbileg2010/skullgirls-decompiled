using Bolt;
using UnityEngine;

public interface ILobbyCommandInput : INetworkCommandData
{
	Color Color { get; set; }

	string Name { get; set; }

	bool Ready { get; set; }
}
