using Bolt;
using UnityEngine;

public interface IClickToMoveCommandLocalResult : INetworkCommandData
{
	Vector3 position { get; set; }
}
