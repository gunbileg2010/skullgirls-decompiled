using System;
using Bolt;
using UnityEngine;

public interface IInteractiveState : IState, IDisposable
{
	NetworkTransform Transform { get; }

	Color Color { get; set; }
}
