using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Bolt
{
	internal class Entity : IBoltListNode<Entity>, IPriorityCalculator, IEntityReplicationFilter
	{
		private bool _canQueueCommands;

		private bool _canQueueCallbacks;

		internal UniqueId SceneId;

		internal NetworkId NetworkId;

		internal PrefabId PrefabId;

		internal EntityFlags Flags;

		internal bool AttachIsRunning;

		internal Vector3 SpawnPosition;

		internal Quaternion SpawnRotation;

		internal Entity Parent;

		internal BoltEntity UnityObject;

		internal BoltConnection Source;

		internal BoltConnection Controller;

		internal IProtocolToken DetachToken;

		internal IProtocolToken AttachToken;

		internal IProtocolToken ControlLostToken;

		internal IProtocolToken ControlGainedToken;

		internal IEntitySerializer Serializer;

		internal IEntityBehaviour[] Behaviours;

		internal IPriorityCalculator PriorityCalculator;

		internal IEntityReplicationFilter ReplicationFilter;

		internal bool IsOwner;

		internal bool IsFrozen;

		internal bool AutoRemoveChildEntities;

		internal bool AllowFirstReplicationWhenFrozen;

		internal QueryComponentOptions EntityBehaviourQueryOption;

		internal QueryComponentOptions EntityPriorityCalculatorQueryOption;

		internal QueryComponentOptions EntityReplicationFilterQueryOption;

		internal int UpdateRate;

		internal int LastFrameReceived;

		internal int AutoFreezeProxyFrames;

		internal bool CanFreeze;

		internal ushort CommandSequence;

		internal Command CommandLastExecuted;

		internal EventDispatcher EventDispatcher;

		internal BoltDoubleList<Command> CommandQueue;

		internal List<CommandCallbackItem> CommandCallbacks;

		internal BoltDoubleList<EntityProxy> Proxies;

		internal CommandHistory InputsSent;

		internal CommandHistory InputsReceived;

		internal CommandHistory ResultsSent;

		internal CommandHistory ResultsReceived;

		internal BoltRingBuffer<int> ProcessedCommandFrames;

		internal BoltRingBuffer<int> ProcessedCommandTypes;

		private BoltRingBuffer<int> _queuedCommandFrames;

		private BoltRingBuffer<int> _queuedCommandTypes;

		private BoltRingBuffer<int> _commandsCount;

		private int _commandDejitterDelay;

		private bool _dynamicCommandDejitterDelay;

		internal int Frame => 0;

		internal int SendRate => 0;

		internal bool IsSceneObject => false;

		internal bool HasParent => false;

		internal bool IsAttached => false;

		internal bool IsDummy => false;

		internal bool HasControl => false;

		internal bool HasPredictedControl => false;

		public bool PersistsOnSceneLoad => false;

		internal bool CanQueueCommands => false;

		private Entity IBoltListNode_003CBolt_002EEntity_003E_002Eprev
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

		private Entity IBoltListNode_003CBolt_002EEntity_003E_002Enext
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

		private object IBoltListNode_003CBolt_002EEntity_003E_002Elist
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

		private bool Bolt_002EIPriorityCalculator_002EAlways => false;

		internal bool QueueInput(Command cmd)
		{
			return false;
		}

		internal void TakeControl(IProtocolToken token)
		{
		}

		internal void TakeControlInternal(IProtocolToken token)
		{
		}

		internal void ReleaseControl(IProtocolToken token)
		{
		}

		internal void ReleaseControlInternal(IProtocolToken token)
		{
		}

		internal void AssignControl(BoltConnection connection, IProtocolToken token)
		{
		}

		internal void RevokeControl(IProtocolToken token)
		{
		}

		private void Reset()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal void SetParent(Entity entity)
		{
		}

		internal void SetParentInternal(Entity entity)
		{
		}

		internal void SetScopeAll(bool inScope)
		{
		}

		internal void SetScope(BoltConnection connection, bool inScope)
		{
		}

		internal void Freeze(bool freeze)
		{
		}

		internal EntityProxy CreateProxy()
		{
			return null;
		}

		internal void Attach()
		{
		}

		internal void Detach()
		{
		}

		internal void AddEventListener(MonoBehaviour behaviour)
		{
		}

		internal void RemoveEventListener(MonoBehaviour behaviour)
		{
		}

		internal bool IsController(BoltConnection connection)
		{
			return false;
		}

		internal void Render()
		{
		}

		private T[] QueryComponents<T>(QueryComponentOptions queryComponentOption, bool queryIncludesInactiveChildren, bool returnNullOnEmpty)
		{
			return null;
		}

		internal void Initialize()
		{
		}

		internal void SetIdle(BoltConnection connection, bool idle)
		{
		}

		private void RemoveOldCommandCallbacks(int number)
		{
		}

		internal void Simulate()
		{
		}

		private int ExecuteCommandsFromRemote()
		{
			return 0;
		}

		private bool LocalAndRemoteResultEqual(Command cmd)
		{
			return false;
		}

		private void ExecuteCommand(Command cmd, bool resetState)
		{
		}

		private int UnexecutedCommandCount()
		{
			return 0;
		}

		internal void InvokeOnce(Command command, CommandCallback callback, int delay)
		{
		}

		internal void InvokeRepeating(Command command, CommandCallback callback, int period)
		{
		}

		internal static Entity CreateFor(PrefabId prefabId, TypeId serializerId, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		internal static Entity CreateFor(GameObject instance, PrefabId prefabId, TypeId serializerId)
		{
			return null;
		}

		internal static Entity CreateFor(GameObject instance, PrefabId prefabId, TypeId serializerId, EntityFlags flags)
		{
			return null;
		}

		private static QueryComponentOptions GetQueryComponentOption(QueryComponentOptionsGlobal globalOption, QueryComponentOptions entityOption)
		{
			return default(QueryComponentOptions);
		}

		public static implicit operator bool(Entity entity)
		{
			return false;
		}

		public static bool operator ==(Entity a, Entity b)
		{
			return false;
		}

		public static bool operator !=(Entity a, Entity b)
		{
			return false;
		}

		private float Bolt_002EIPriorityCalculator_002ECalculateStatePriority(BoltConnection connection, int skipped)
		{
			return 0f;
		}

		private float Bolt_002EIPriorityCalculator_002ECalculateEventPriority(BoltConnection connection, Event evnt)
		{
			return 0f;
		}

		private bool Bolt_002EIEntityReplicationFilter_002EAllowReplicationTo(BoltConnection connection)
		{
			return false;
		}
	}
}
