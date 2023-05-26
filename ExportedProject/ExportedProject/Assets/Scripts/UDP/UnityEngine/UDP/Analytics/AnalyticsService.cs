namespace UnityEngine.UDP.Analytics
{
	[HideInInspector]
	internal class AnalyticsService
	{
		public enum SessionState
		{
			kSessionStopped = 0,
			kSessionStarted = 1,
			kSessionPaused = 2,
			kSessionResumed = 3
		}

		private const uint kResumeTimeoutInSeconds = 1800u;

		private const string kPlayerSessionIdKey = "udp.player_sessionId";

		private const string kPlayerSessionElapsedTime = "udp.player_session_elapsed_time";

		private const string kPlayerSessionBackgroundTime = "udp.player_session_background_time";

		private static SessionState m_PlayerSessionState;

		private static string m_PlayerSessionId;

		private static ulong m_PlayerSessionElapsedTime;

		private static ulong m_PlayerSessionForegroundTime;

		private static ulong m_PlayerSessionBackgroundTime;

		public static void Initialize()
		{
		}

		public static void OnPlayerQuit()
		{
		}

		public static void OnExitPlayMode()
		{
		}

		public static void OnPlayerPaused(bool paused)
		{
		}

		public static void OnDidReloadMonoDomain()
		{
		}

		public static void OnAppAwake()
		{
		}

		private static void onPlayerStateChanged(SessionState sessionState)
		{
		}

		public static ulong GetPlayerSessionElapsedTime()
		{
			return 0uL;
		}
	}
}
