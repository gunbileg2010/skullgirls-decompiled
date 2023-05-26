using System;
using Bolt;
using UnityEngine;

public interface IBomberState : IState, IDisposable
{
	NetworkTransform Transform { get; }

	Color Color { get; set; }

	string Name { get; set; }
}
