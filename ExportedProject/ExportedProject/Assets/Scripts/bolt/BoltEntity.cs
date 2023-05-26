using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Bolt;
using UnityEngine;

[ExecuteInEditMode]
[Documentation]
public class BoltEntity : MonoBehaviour, IBoltListNode<BoltEntity>
{
	internal Entity _entity;

	[SerializeField]
	internal string _sceneGuid;

	[SerializeField]
	internal string _serializerGuid;

	[SerializeField]
	internal int _prefabId;

	[SerializeField]
	internal int _updateRate;

	[SerializeField]
	internal int _autoFreezeProxyFrames;

	[SerializeField]
	internal bool _clientPredicted;

	[SerializeField]
	internal bool _allowInstantiateOnClient;

	[SerializeField]
	internal bool _persistThroughSceneLoads;

	[SerializeField]
	internal bool _sceneObjectDestroyOnDetach;

	[SerializeField]
	internal bool _sceneObjectAutoAttach;

	[SerializeField]
	internal bool _alwaysProxy;

	[SerializeField]
	internal bool _detachOnDisable;

	[SerializeField]
	internal bool _allowFirstReplicationWhenFrozen;

	[SerializeField]
	internal bool _autoRemoveChildEntities;

	[SerializeField]
	internal QueryComponentOptions _entityBehaviourQueryOption;

	[SerializeField]
	internal QueryComponentOptions _entityPriorityCalculatorQueryOption;

	[SerializeField]
	internal QueryComponentOptions _entityReplicationFilterQueryOption;

	private BoltEntity IBoltListNode_003CBoltEntity_003E_002Eprev
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

	private BoltEntity IBoltListNode_003CBoltEntity_003E_002Enext
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

	private object IBoltListNode_003CBoltEntity_003E_002Elist
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

	internal Entity Entity => null;

	internal UniqueId SceneGuid
	{
		get
		{
			return default(UniqueId);
		}
		set
		{
		}
	}

	[Obsolete]
	internal UniqueId sceneGuid
	{
		get
		{
			return default(UniqueId);
		}
		set
		{
		}
	}

	internal UniqueId SerializerGuid
	{
		get
		{
			return default(UniqueId);
		}
		set
		{
		}
	}

	[Obsolete]
	internal UniqueId serializerGuid
	{
		get
		{
			return default(UniqueId);
		}
		set
		{
		}
	}

	public PrefabId PrefabId => default(PrefabId);

	[Obsolete]
	public PrefabId prefabId => default(PrefabId);

	public BoltConnection Source => null;

	[Obsolete]
	public BoltConnection source => null;

	public IProtocolToken AttachToken => null;

	[Obsolete]
	public IProtocolToken attachToken => null;

	public IProtocolToken DetachToken => null;

	[Obsolete]
	public IProtocolToken detachToken => null;

	public IProtocolToken ControlGainedToken => null;

	[Obsolete]
	public IProtocolToken controlGainedToken => null;

	public IProtocolToken ControlLostToken => null;

	[Obsolete]
	public IProtocolToken controlLostToken => null;

	public NetworkId NetworkId => default(NetworkId);

	[Obsolete]
	public NetworkId networkId => default(NetworkId);

	public bool CanFreeze
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete]
	public bool canFreeze
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public BoltConnection Controller => null;

	[Obsolete]
	public BoltConnection controller => null;

	public bool IsAttached => false;

	[Obsolete]
	public bool isAttached => false;

	public bool IsControlled => false;

	[Obsolete]
	public bool isControlled => false;

	public bool IsControllerOrOwner => false;

	[Obsolete]
	public bool isControllerOrOwner => false;

	public bool IsFrozen => false;

	[Obsolete]
	public bool isFrozen => false;

	public bool IsSceneObject => false;

	[Obsolete]
	public bool isSceneObject => false;

	public bool IsOwner => false;

	[Obsolete]
	public bool isOwner => false;

	public bool HasControl => false;

	[Obsolete]
	public bool hasControl => false;

	public bool HasControlWithPrediction => false;

	[Obsolete]
	public bool hasControlWithPrediction => false;

	public bool PersistsOnSceneLoad => false;

	[Obsolete]
	public bool persistsOnSceneLoad => false;

	public bool HasParent => false;

	public BoltEntitySettingsModifier ModifySettings()
	{
		return null;
	}

	public void SetScopeAll(bool inScope)
	{
	}

	public void SetScope(BoltConnection connection, bool inScope)
	{
	}

	public void SetParent(BoltEntity parent)
	{
	}

	public void TakeControl()
	{
	}

	public void TakeControl(IProtocolToken token)
	{
	}

	public void ReleaseControl()
	{
	}

	public void ReleaseControl(IProtocolToken token)
	{
	}

	public void AssignControl(BoltConnection connection)
	{
	}

	public void AssignControl(BoltConnection connection, IProtocolToken token)
	{
	}

	public void RevokeControl()
	{
	}

	public void RevokeControl(IProtocolToken token)
	{
	}

	public bool IsController(BoltConnection connection)
	{
		return false;
	}

	public bool QueueInput(INetworkCommandData data)
	{
		return false;
	}

	public void Idle(BoltConnection connection, bool idle)
	{
	}

	public void Freeze(bool pause)
	{
	}

	public void AddEventListener(MonoBehaviour behaviour)
	{
	}

	public void AddEventCallback<T>(Action<T> callback) where T : Bolt.Event
	{
	}

	public void RemoveEventListener(MonoBehaviour behaviour)
	{
	}

	public void RemoveEventCallback<T>(Action<T> callback) where T : Bolt.Event
	{
	}

	public TState GetState<TState>()
	{
		return default(TState);
	}

	public bool TryFindState<TState>(out TState state)
	{
		state = default(TState);
		return false;
	}

	public bool StateIs<TState>()
	{
		return false;
	}

	public bool StateIs(Type t)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public void DestroyDelayed(float time)
	{
	}

	public void InvokeOnce(Command cmd, int delay, CommandCallback callback)
	{
	}

	public void InvokeMany(Command cmd, int duration, CommandCallback callback)
	{
	}

	internal void VerifyNotAttached()
	{
	}

	private IEnumerator DestroyDelayedInternal(float time)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDrawGizmos()
	{
	}

	public static implicit operator GameObject(BoltEntity entity)
	{
		return null;
	}
}
