using Bolt;
using UnityEngine;

public interface IClickToMoveCommandInput : INetworkCommandData
{
	Vector3 click { get; set; }
}
