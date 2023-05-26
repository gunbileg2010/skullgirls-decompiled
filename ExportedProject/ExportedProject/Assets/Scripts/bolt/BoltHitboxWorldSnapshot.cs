using System;
using System.Runtime.CompilerServices;

internal class BoltHitboxWorldSnapshot : BoltObject, IDisposable, IBoltListNode<BoltHitboxWorldSnapshot>
{
	internal static readonly BoltObjectPool<BoltHitboxWorldSnapshot> _pool;

	internal int _frame;

	internal BoltSingleList<BoltHitboxBodySnapshot> _bodySnapshots;

	private BoltHitboxWorldSnapshot IBoltListNode_003CBoltHitboxWorldSnapshot_003E_002Eprev
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

	private BoltHitboxWorldSnapshot IBoltListNode_003CBoltHitboxWorldSnapshot_003E_002Enext
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

	private object IBoltListNode_003CBoltHitboxWorldSnapshot_003E_002Elist
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

	internal void Snapshot(BoltHitboxBody body)
	{
	}

	public void Dispose()
	{
	}

	public void Draw()
	{
	}
}
