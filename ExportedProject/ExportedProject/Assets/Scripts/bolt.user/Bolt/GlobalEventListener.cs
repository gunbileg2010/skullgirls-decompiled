using BoltInternal;

namespace Bolt
{
	public class GlobalEventListener : GlobalEventListenerBase, ILogEventListener, ILobbyCountdownListener, ILobbyPlayerKickListener
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
	}
}
