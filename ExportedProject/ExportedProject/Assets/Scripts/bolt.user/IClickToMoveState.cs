using System;
using Bolt;

public interface IClickToMoveState : IState, IDisposable
{
	NetworkTransform Transform { get; }

	float Forward { get; }

	float Turn { get; }

	bool Crouch { get; }

	bool OnGround { get; }

	float Jump { get; }

	float JumpLeg { get; }
}
