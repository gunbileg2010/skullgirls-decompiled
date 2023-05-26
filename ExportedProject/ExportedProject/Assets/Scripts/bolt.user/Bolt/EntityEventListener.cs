using BoltInternal;

namespace Bolt
{
	public class EntityEventListener : EntityEventListenerBase, ILogEventListener, ILobbyCountdownListener, ILobbyPlayerKickListener, IFlashColorEventListener
	{
		public virtual void OnEvent(LogEvent evnt)
		{
		}

		public virtual void OnEvent(LobbyCountdown evnt)
		{
		}

		public virtual void OnEvent(LobbyPlayerKick evnt)
		{
		}

		public virtual void OnEvent(FlashColorEvent evnt)
		{
		}
	}
	public class EntityEventListener<TState> : EntityEventListenerBase<TState>, ILogEventListener, ILobbyCountdownListener, ILobbyPlayerKickListener, IFlashColorEventListener
	{
		public EntityEventListener()
		{
			((EntityEventListenerBase<TState>)(object)this)._002Ector();
		}

		public virtual void OnEvent(LogEvent evnt)
		{
		}

		public virtual void OnEvent(LobbyCountdown evnt)
		{
		}

		public virtual void OnEvent(LobbyPlayerKick evnt)
		{
		}

		public virtual void OnEvent(FlashColorEvent evnt)
		{
		}
	}
}
