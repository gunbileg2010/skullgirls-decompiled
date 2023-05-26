using System.Collections.Generic;
using Bolt;
using UnityEngine;

internal class EntityChannel : BoltChannel
{
	internal class CommandChannel : BoltChannel
	{
		private int inputFullSyncSendRate;

		private int resultFullSyncSendRate;

		private float nextInputSendRateUpdateTime;

		private float nextResultSendRateUpdateTime;

		private int pingFrames => 0;

		private Dictionary<NetworkId, EntityProxy> incommingProxiesByNetworkId => null;

		private Dictionary<NetworkId, EntityProxy> outgoingProxiesByNetworkId => null;

		public override void Pack(Packet packet)
		{
		}

		public override void Read(Packet packet)
		{
		}

		private bool EntityHasUnsentState(Entity entity)
		{
			return false;
		}

		private void PackResult(Packet packet)
		{
		}

		private void ReadResult(Packet packet)
		{
		}

		private void PackInput(Packet packet)
		{
		}

		private void ReadInput(Packet packet)
		{
		}

		private static void WriteInvalidReferenceCommandSequence(Packet packet, Command command, CommandHistory history)
		{
		}

		private static bool ReadAndRemoveInvalidReferenceCommandSequence(Packet packet, Command command, CommandHistory history)
		{
			return false;
		}

		private static void LogDeltaCompression(LogType type, string format, params object[] arguments)
		{
		}
	}

	internal EntityLookup _outgoingLookup;

	internal EntityLookup _incommingLookup;

	internal Dictionary<NetworkId, EntityProxy> _outgoingDict;

	internal Dictionary<NetworkId, EntityProxy> _incommingDict;

	private List<EntityProxy> _prioritized;

	public void ForceSync(Entity en)
	{
	}

	public void ForceSync(Entity en, out EntityProxy proxy)
	{
		proxy = null;
	}

	public bool TryFindProxy(Entity en, out EntityProxy proxy)
	{
		proxy = null;
		return false;
	}

	public void SetIdle(Entity entity, bool idle)
	{
	}

	public void SetScope(Entity entity, bool inScope)
	{
	}

	public bool ExistsOnRemote(Entity entity)
	{
		return false;
	}

	public ExistsResult ExistsOnRemote(Entity entity, bool allowMaybe)
	{
		return default(ExistsResult);
	}

	public bool MightExistOnRemote(Entity entity)
	{
		return false;
	}

	public void DestroyOnRemote(Entity entity)
	{
	}

	public void CreateOnRemote(Entity entity)
	{
	}

	public void CreateOnRemote(Entity entity, out EntityProxy proxy)
	{
		proxy = null;
	}

	public float GetPriority(Entity entity)
	{
		return 0f;
	}

	public override void Pack(Packet packet)
	{
	}

	public override void Read(Packet packet)
	{
	}

	public override void Lost(Packet packet)
	{
	}

	public override void Delivered(Packet packet)
	{
	}

	public override void Disconnected()
	{
	}

	public int GetSkippedUpdates(Entity en)
	{
		return 0;
	}

	private void ApplyPropertyPriorities(EntityProxyEnvelope env)
	{
	}

	private int PackUpdate(Packet packet, EntityProxy proxy)
	{
		return 0;
	}

	private bool ReadUpdate(Packet packet)
	{
		return false;
	}

	private void DestroyOutgoingProxy(EntityProxy proxy)
	{
	}

	private void DestroyIncommingProxy(EntityProxy proxy, IProtocolToken token)
	{
	}
}
