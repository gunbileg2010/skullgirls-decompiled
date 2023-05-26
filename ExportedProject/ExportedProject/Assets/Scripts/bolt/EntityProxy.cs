using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Bolt;

internal class EntityProxy : BitSet, IBoltListNode<EntityProxy>
{
	public class PriorityComparer : IComparer<EntityProxy>
	{
		public static readonly PriorityComparer Instance;

		private PriorityComparer()
		{
		}

		private int System_002ECollections_002EGeneric_002EIComparer_003CEntityProxy_003E_002ECompare(EntityProxy x, EntityProxy y)
		{
			return 0;
		}
	}

	public NetworkState State;

	public NetworkId NetworkId;

	public ProxyFlags Flags;

	public Priority[] PropertyPriority;

	public Entity Entity;

	public BoltConnection Connection;

	public Queue<EntityProxyEnvelope> Envelopes;

	public IProtocolToken ControlTokenLost;

	public IProtocolToken ControlTokenGained;

	public int Skipped;

	public float Priority;

	private EntityProxy IBoltListNode_003CEntityProxy_003E_002Eprev
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

	private EntityProxy IBoltListNode_003CEntityProxy_003E_002Enext
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

	private object IBoltListNode_003CEntityProxy_003E_002Elist
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

	public EntityProxy()
		: base(0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL, 0uL)
	{
	}

	public EntityProxyEnvelope CreateEnvelope()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
