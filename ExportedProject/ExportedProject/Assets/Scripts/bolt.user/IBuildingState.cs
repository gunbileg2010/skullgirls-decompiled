using System;
using Bolt;

public interface IBuildingState : IState, IDisposable
{
	NetworkTransform Transform { get; }
}
