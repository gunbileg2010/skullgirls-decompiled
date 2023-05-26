using System;
using Bolt;

public interface IPlayerState : IState, IDisposable
{
	NetworkTransform transform { get; }

	int team { get; set; }

	string name { get; set; }

	float pitch { get; set; }

	int weapon { get; set; }

	int kills { get; set; }

	int deaths { get; set; }

	bool Dead { get; set; }

	int respawnFrame { get; set; }

	int health { get; set; }

	float MoveZ { get; set; }

	float MoveX { get; set; }

	Action OnJump { get; set; }

	bool Aiming { get; set; }

	Action OnFire { get; set; }

	IProtocolToken tokenTest { get; set; }

	void Jump();

	void Fire();
}
