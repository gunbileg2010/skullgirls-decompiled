using System;
using Bolt;

public interface IBombState : IState, IDisposable
{
	NetworkTransform Transform { get; }
}
