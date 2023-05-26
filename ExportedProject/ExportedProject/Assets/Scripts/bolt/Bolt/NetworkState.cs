using System;
using System.Collections.Generic;
using UdpKit;
using UnityEngine;

namespace Bolt
{
	internal abstract class NetworkState : NetworkObj_Root, IEntitySerializer, IState, IDisposable
	{
		internal Entity Entity;

		internal List<Animator> Animators;

		internal new NetworkState_Meta Meta;

		internal BitSet PropertyDefaultMask;

		internal Priority[] PropertyPriorityTemp;

		internal BoltDoubleList<NetworkStorage> Frames;

		private Dictionary<string, List<PropertyCallback>> Callbacks;

		private Dictionary<string, List<PropertyCallbackSimple>> CallbacksSimple;

		public Animator Animator => null;

		internal sealed override NetworkStorage Storage => null;

		private TypeId Bolt_002EIEntitySerializer_002ETypeId => default(TypeId);

		private Animator Bolt_002EIState_002EAnimator => null;

		private IEnumerable<Animator> Bolt_002EIState_002EAllAnimators => null;

		internal NetworkState(NetworkState_Meta meta)
			: base(null)
		{
		}

		public void SetAnimator(Animator animator)
		{
		}

		public void AddAnimator(Animator animator)
		{
		}

		internal void WriteInitialPosition(Vector3 position, UdpPacket packet)
		{
		}

		internal Vector3 ReadInitialPosition(UdpPacket packet)
		{
			return default(Vector3);
		}

		internal void WriteInitialRotation(Quaternion rotation, UdpPacket packet)
		{
		}

		internal Quaternion ReadInitialRotation(UdpPacket packet)
		{
			return default(Quaternion);
		}

		private void Bolt_002EIEntitySerializer_002EOnRender()
		{
		}

		private void Bolt_002EIEntitySerializer_002EOnInitialized()
		{
		}

		private void Bolt_002EIEntitySerializer_002EOnCreated(Entity entity)
		{
		}

		private void Bolt_002EIEntitySerializer_002EOnParentChanging(Entity newParent, Entity oldParent)
		{
		}

		private void Bolt_002EIEntitySerializer_002EOnSimulateBefore()
		{
		}

		private void Bolt_002EIEntitySerializer_002EOnSimulateAfter()
		{
		}

		private void Bolt_002EIEntitySerializer_002EOnControlGained()
		{
		}

		private void Bolt_002EIEntitySerializer_002EOnControlLost()
		{
		}

		private BitSet Bolt_002EIEntitySerializer_002EGetDefaultMask()
		{
			return null;
		}

		private BitSet Bolt_002EIEntitySerializer_002EGetFilter(BoltConnection connection, EntityProxy proxy)
		{
			return null;
		}

		private void Bolt_002EIEntitySerializer_002EDebugInfo()
		{
		}

		private string FixArrayIndices(string path, int[] indices)
		{
			return null;
		}

		private void Bolt_002EIEntitySerializer_002EInitProxy(EntityProxy p)
		{
		}

		private int Bolt_002EIEntitySerializer_002EPack(BoltConnection connection, UdpPacket stream, EntityProxyEnvelope env)
		{
			return 0;
		}

		private void PackProperties(BoltConnection connection, UdpPacket packet, EntityProxyEnvelope env, Priority[] priority, int count)
		{
		}

		private void Bolt_002EIEntitySerializer_002ERead(BoltConnection connection, UdpPacket packet, int frame)
		{
		}

		private bool VerifyCallbackPath(string path)
		{
			return false;
		}

		private void Bolt_002EIState_002EAddAnimator(Animator animator)
		{
		}

		private void Bolt_002EIState_002ESetAnimator(Animator animator)
		{
		}

		private void Bolt_002EIState_002EAddCallback(string path, PropertyCallback callback)
		{
		}

		private void Bolt_002EIState_002EAddCallback(string path, PropertyCallbackSimple callback)
		{
		}

		private void Bolt_002EIState_002ERemoveCallback(string path, PropertyCallback callback)
		{
		}

		private void Bolt_002EIState_002ERemoveCallback(string path, PropertyCallbackSimple callback)
		{
		}

		private void Bolt_002EIState_002ERemoveAllCallbacks()
		{
		}

		private void Bolt_002EIState_002ESetDynamic(string property, object value)
		{
		}

		private object Bolt_002EIState_002EGetDynamic(string property)
		{
			return null;
		}

		private void Bolt_002EIState_002ESetTeleport(NetworkTransform transform)
		{
		}

		private void Bolt_002EIState_002ESetTransforms(NetworkTransform transform, Transform simulate)
		{
		}

		private void Bolt_002EIState_002ESetTransforms(NetworkTransform transform, Transform simulate, Transform render)
		{
		}

		private void Bolt_002EIState_002EForceTransform(NetworkTransform transform, Vector3 position)
		{
		}

		private void Bolt_002EIState_002EForceTransform(NetworkTransform transform, Vector3 position, Quaternion rotation)
		{
		}

		private bool Bolt_002EIState_002ETrySetDynamic(string property, object value)
		{
			return false;
		}

		private bool Bolt_002EIState_002ETryGetDynamic(string property, out object value)
		{
			value = null;
			return false;
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		private void InvokeCallbacks()
		{
		}

		private void InvokeCallbacksForProperty(int propertyIndex)
		{
		}
	}
}
