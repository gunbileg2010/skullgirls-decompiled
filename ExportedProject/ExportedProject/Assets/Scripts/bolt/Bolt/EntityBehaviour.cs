using UnityEngine;

namespace Bolt
{
	[Documentation]
	public abstract class EntityBehaviour : MonoBehaviour, IEntityBehaviour
	{
		internal BoltEntity _entity;

		public BoltEntity entity
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool Bolt_002EIEntityBehaviour_002Einvoke => false;

		public virtual void Initialized()
		{
		}

		public virtual void Attached()
		{
		}

		public virtual void Detached()
		{
		}

		public virtual void SimulateOwner()
		{
		}

		public virtual void SimulateController()
		{
		}

		public virtual void ControlGained()
		{
		}

		public virtual void ControlLost()
		{
		}

		public virtual void MissingCommand(Command previous)
		{
		}

		public virtual void ExecuteCommand(Command command, bool resetState)
		{
		}

		public virtual bool LocalAndRemoteResultEqual(Command command)
		{
			return false;
		}
	}
	[Documentation]
	public abstract class EntityBehaviour<TState> : EntityBehaviour
	{
		public TState state => default(TState);
	}
}
