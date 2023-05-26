using Bolt;
using UnityEngine;

public interface ITPCCommandLocalResult : INetworkCommandData
{
	Vector3 position { get; set; }

	Vector3 velocity { get; set; }

	bool isGrounded { get; set; }

	int jumpFrames { get; set; }
}
