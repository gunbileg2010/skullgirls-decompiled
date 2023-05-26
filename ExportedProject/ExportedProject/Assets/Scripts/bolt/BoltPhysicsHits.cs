using System;
using System.Collections.Generic;
using Bolt;

[Documentation]
public class BoltPhysicsHits : BoltObject, IDisposable
{
	internal static readonly BoltObjectPool<BoltPhysicsHits> _pool;

	internal List<BoltPhysicsHit> _hits;

	public int count => 0;

	public BoltPhysicsHit Item => default(BoltPhysicsHit);

	public BoltPhysicsHit GetHit(int index)
	{
		return default(BoltPhysicsHit);
	}

	public void Dispose()
	{
	}

	internal void AddHit(BoltHitboxBody body, BoltHitbox hitbox, float distance)
	{
	}
}
