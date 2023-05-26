using System;
using Bolt;

internal class ClickToMoveState : Bolt.NetworkState, IClickToMoveState, IState, IDisposable
{
	public NetworkTransform Transform => null;

	public float Forward => 0f;

	public float Turn => 0f;

	public bool Crouch => false;

	public bool OnGround => false;

	public float Jump => 0f;

	public float JumpLeg => 0f;
}
