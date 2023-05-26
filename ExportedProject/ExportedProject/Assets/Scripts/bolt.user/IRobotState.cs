using System;
using Bolt;

public interface IRobotState : IState, IDisposable
{
	float AngularSpeed { get; set; }

	float Speed { get; set; }

	float Shot { get; }

	bool PlayerInSight { get; set; }

	float AimWeight { get; }

	NetworkTransform Transform { get; }
}
