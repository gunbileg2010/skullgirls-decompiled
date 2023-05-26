using System;
using Bolt;

internal class BuildingState : Bolt.NetworkState, IBuildingState, IState, IDisposable
{
	public NetworkTransform Transform => null;
}
