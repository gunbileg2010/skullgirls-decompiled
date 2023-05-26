using System;
using Bolt;

public interface ITPCstate : IState, IDisposable
{
	NetworkTransform transform { get; }

	float forward { get; set; }

	float turn { get; set; }

	bool crouch { get; set; }

	bool grounded { get; set; }

	float jump { get; set; }

	float jumpleg { get; set; }
}
