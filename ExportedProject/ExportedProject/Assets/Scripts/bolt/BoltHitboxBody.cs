using System.Runtime.CompilerServices;
using Bolt;
using UnityEngine;

[Documentation]
public class BoltHitboxBody : MonoBehaviour, IBoltListNode<BoltHitboxBody>
{
	[SerializeField]
	internal BoltHitbox _proximity;

	[SerializeField]
	internal BoltHitbox[] _hitboxes;

	private BoltHitboxBody IBoltListNode_003CBoltHitboxBody_003E_002Eprev
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

	private BoltHitboxBody IBoltListNode_003CBoltHitboxBody_003E_002Enext
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

	private object IBoltListNode_003CBoltHitboxBody_003E_002Elist
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

	public BoltHitbox proximity
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BoltHitbox[] hitboxes
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
