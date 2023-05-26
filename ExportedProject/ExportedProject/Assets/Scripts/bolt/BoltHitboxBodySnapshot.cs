using System;
using System.Runtime.CompilerServices;
using UnityEngine;

internal class BoltHitboxBodySnapshot : BoltObject, IDisposable, IBoltListNode<BoltHitboxBodySnapshot>
{
	private static readonly BoltObjectPool<BoltHitboxBodySnapshot> _pool;

	private int _count;

	private BoltHitboxBody _body;

	private Matrix4x4 _wtl;

	private Matrix4x4 _ltw;

	private Matrix4x4[] _hbwtl;

	private Matrix4x4[] _hbltw;

	public BoltHitboxBody HitboxBody => null;

	private BoltHitboxBodySnapshot IBoltListNode_003CBoltHitboxBodySnapshot_003E_002Eprev
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private BoltHitboxBodySnapshot IBoltListNode_003CBoltHitboxBodySnapshot_003E_002Enext
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private object IBoltListNode_003CBoltHitboxBodySnapshot_003E_002Elist
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void Snapshot(BoltHitboxBody body)
	{
	}

	public void Dispose()
	{
	}

	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	public void OverlapSphere(Vector3 center, float radius, BoltPhysicsHits hits)
	{
	}

	public void Raycast(Vector3 origin, Vector3 direction, BoltPhysicsHits hits)
	{
	}

	public void Draw()
	{
	}

	public static BoltHitboxBodySnapshot Create(BoltHitboxBody body)
	{
		return null;
	}
}
