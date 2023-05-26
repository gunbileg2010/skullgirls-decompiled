using System;
using Bolt;

internal class BombState : Bolt.NetworkState, IBombState, IState, IDisposable
{
	public NetworkTransform Transform => null;
}
