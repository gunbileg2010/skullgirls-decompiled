using System;
using System.Runtime.CompilerServices;
using Bolt;
using UdpKit;
using UnityEngine;

namespace BoltInternal
{
	[Documentation]
	public abstract class GlobalEventListenerBase : MonoBehaviour, IBoltListNode<GlobalEventListenerBase>
	{
		private static readonly BoltDoubleList<GlobalEventListenerBase> callbacks;

		private GlobalEventListenerBase IBoltListNode_003CBoltInternal_002EGlobalEventListenerBase_003E_002Eprev
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

		private GlobalEventListenerBase IBoltListNode_003CBoltInternal_002EGlobalEventListenerBase_003E_002Enext
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

		private object IBoltListNode_003CBoltInternal_002EGlobalEventListenerBase_003E_002Elist
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

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		public virtual bool PersistBetweenStartupAndShutdown()
		{
			return false;
		}

		public virtual void BoltStartBegin()
		{
		}

		internal static void BoltStartBeginInvoke()
		{
		}

		public virtual void BoltStartDone()
		{
		}

		internal static void BoltStartDoneInvoke()
		{
		}

		public virtual void BoltStartFailed()
		{
		}

		internal static void BoltStartFailedInvoke()
		{
		}

		public virtual void BoltShutdownBegin(AddCallback registerDoneCallback)
		{
		}

		internal static void BoltShutdownBeginInvoke(AddCallback registerDoneCallback)
		{
		}

		public virtual void BoltShutdownBegin(AddCallback registerDoneCallback, UdpConnectionDisconnectReason disconnectReason)
		{
		}

		internal static void BoltShutdownBeginInvoke(AddCallback registerDoneCallback, UdpConnectionDisconnectReason disconnectReason)
		{
		}

		public virtual void Connected(BoltConnection connection)
		{
		}

		internal static void ConnectedInvoke(BoltConnection connection)
		{
		}

		public virtual void ConnectFailed(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		internal static void ConnectFailedInvoke(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		public virtual void ConnectRequest(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		internal static void ConnectRequestInvoke(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		public virtual void ConnectRefused(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		internal static void ConnectRefusedInvoke(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		public virtual void ConnectAttempt(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		internal static void ConnectAttemptInvoke(UdpEndPoint endpoint, IProtocolToken token)
		{
		}

		public virtual void ControlOfEntityLost(BoltEntity entity)
		{
		}

		internal static void ControlOfEntityLostInvoke(BoltEntity entity)
		{
		}

		public virtual void ControlOfEntityGained(BoltEntity entity)
		{
		}

		internal static void ControlOfEntityGainedInvoke(BoltEntity entity)
		{
		}

		public virtual void Disconnected(BoltConnection connection)
		{
		}

		internal static void DisconnectedInvoke(BoltConnection connection)
		{
		}

		public virtual void EntityAttached(BoltEntity entity)
		{
		}

		internal static void EntityAttachedInvoke(BoltEntity entity)
		{
		}

		public virtual void EntityDetached(BoltEntity entity)
		{
		}

		internal static void EntityDetachedInvoke(BoltEntity entity)
		{
		}

		public virtual void EntityReceived(BoltEntity entity)
		{
		}

		internal static void EntityReceivedInvoke(BoltEntity entity)
		{
		}

		public virtual void EntityFrozen(BoltEntity entity)
		{
		}

		internal static void EntityFrozenInvoke(BoltEntity entity)
		{
		}

		public virtual void EntityThawed(BoltEntity entity)
		{
		}

		internal static void EntityThawedInvoke(BoltEntity entity)
		{
		}

		public virtual void SceneLoadLocalBegin(string scene)
		{
		}

		internal static void SceneLoadLocalBeginInvoke(string scene)
		{
		}

		public virtual void SceneLoadLocalBegin(string scene, IProtocolToken token)
		{
		}

		internal static void SceneLoadLocalBeginInvoke(string scene, IProtocolToken token)
		{
		}

		public virtual void SceneLoadLocalDone(string scene)
		{
		}

		internal static void SceneLoadLocalDoneInvoke(string scene)
		{
		}

		public virtual void SceneLoadLocalDone(string scene, IProtocolToken token)
		{
		}

		internal static void SceneLoadLocalDoneInvoke(string scene, IProtocolToken token)
		{
		}

		public virtual void SceneLoadRemoteDone(BoltConnection connection)
		{
		}

		internal static void SceneLoadRemoteDoneInvoke(BoltConnection connection)
		{
		}

		public virtual void SceneLoadRemoteDone(BoltConnection connection, IProtocolToken token)
		{
		}

		internal static void SceneLoadRemoteDoneInvoke(BoltConnection connection, IProtocolToken token)
		{
		}

		public virtual void SessionListUpdated(Map<Guid, UdpSession> sessionList)
		{
		}

		internal static void SessionListUpdatedInvoke(Map<Guid, UdpSession> sessionList)
		{
		}

		public virtual void SessionConnectFailed(UdpSession session, IProtocolToken token)
		{
		}

		internal static void SessionConnectFailedInvoke(UdpSession session, IProtocolToken token)
		{
		}

		public virtual void SessionCreated(UdpSession session)
		{
		}

		internal static void SessionCreatedInvoke(UdpSession session)
		{
		}

		public virtual void SessionCreationFailed(UdpSession session)
		{
		}

		internal static void SessionCreationFailedInvoke(UdpSession session)
		{
		}

		public virtual void StreamDataReceived(BoltConnection connection, UdpStreamData data)
		{
		}

		internal static void StreamDataReceivedInvoke(BoltConnection connection, UdpStreamData data)
		{
		}
	}
}
