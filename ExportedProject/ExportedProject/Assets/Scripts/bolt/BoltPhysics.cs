using UnityEngine;

internal static class BoltPhysics
{
	private static int maxWorldSnapshots;

	private static readonly BoltDoubleList<BoltHitboxBody> _hitboxBodies;

	private static readonly BoltDoubleList<BoltHitboxWorldSnapshot> _worldSnapshots;

	internal static void RegisterBody(BoltHitboxBody body)
	{
	}

	internal static void UnregisterBody(BoltHitboxBody body)
	{
	}

	internal static void SnapshotWorld()
	{
	}

	internal static void DrawSnapshot()
	{
	}

	internal static Vector3 PositionAtFrame(BoltHitboxBody hitbox, int frame)
	{
		return default(Vector3);
	}

	internal static BoltPhysicsHits Raycast(Ray ray)
	{
		return null;
	}

	internal static BoltPhysicsHits Raycast(Ray ray, int frame)
	{
		return null;
	}

	internal static BoltPhysicsHits OverlapSphere(Vector3 origin, float radius)
	{
		return null;
	}

	internal static BoltPhysicsHits OverlapSphere(Vector3 origin, float radius, int frame)
	{
		return null;
	}

	private static Vector3 PositionAtFrame(BoltHitboxBody hitbox, BoltHitboxWorldSnapshot sn)
	{
		return default(Vector3);
	}

	private static BoltPhysicsHits Raycast(Ray ray, BoltHitboxWorldSnapshot sn)
	{
		return null;
	}

	private static BoltPhysicsHits OverlapSphere(Vector3 origin, float radius, BoltHitboxWorldSnapshot sn)
	{
		return null;
	}
}
