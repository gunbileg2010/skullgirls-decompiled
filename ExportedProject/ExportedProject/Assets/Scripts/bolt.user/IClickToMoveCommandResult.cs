using Bolt;
using UnityEngine;

public interface IClickToMoveCommandResult : INetworkCommandData
{
	Vector3 position { get; set; }
}
