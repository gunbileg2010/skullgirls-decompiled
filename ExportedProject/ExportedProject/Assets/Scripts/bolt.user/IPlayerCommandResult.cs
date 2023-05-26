using Bolt;
using UnityEngine;

public interface IPlayerCommandResult : INetworkCommandData
{
	Vector3 position { get; set; }

	Vector3 velocity { get; set; }

	int jumpFrames { get; set; }

	bool isGrounded { get; set; }
}
