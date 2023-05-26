using Bolt;

namespace BoltInternal
{
	[Documentation]
	public abstract class EntityEventListenerBase : EntityBehaviour
	{
		public sealed override void Initialized()
		{
		}
	}
	[Documentation]
	public abstract class EntityEventListenerBase<TState> : EntityEventListenerBase
	{
		public TState state => default(TState);
	}
}
