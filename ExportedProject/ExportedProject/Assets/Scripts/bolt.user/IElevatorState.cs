using System;
using Bolt;
using UnityEngine;

public interface IElevatorState : IState, IDisposable
{
	Vector3 NewProperty { get; set; }
}
