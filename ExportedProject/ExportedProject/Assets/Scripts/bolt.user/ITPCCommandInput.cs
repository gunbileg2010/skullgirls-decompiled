using Bolt;
using UnityEngine;

public interface ITPCCommandInput : INetworkCommandData
{
	Vector3 move { get; set; }

	bool crouch { get; set; }

	float forward { get; set; }

	float turn { get; set; }

	bool jump { get; set; }
}
