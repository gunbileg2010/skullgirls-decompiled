using System;

namespace PubNubAPI
{
	internal class PresenceHeartbeatWorker
	{
		private bool keepPresenceHearbeatRunning;

		private bool isPresenceHearbeatRunning;

		private readonly PNUnityWebRequest webRequest;

		private string webRequestId;

		private readonly PubNubUnity PubNubInstance;

		internal PresenceHeartbeatWorker(PubNubUnity pn, PNUnityWebRequest webRequest)
		{
		}

		~PresenceHeartbeatWorker()
		{
		}

		internal void CleanUp()
		{
		}

		private void WebRequestCompleteHandler(object sender, EventArgs ea)
		{
		}

		internal void StopPresenceHeartbeat()
		{
		}

		private void PresenceHeartbeatHandler(CustomEventArgs cea)
		{
		}

		private void StartPresenceHeartbeat(bool pause, int pauseTime)
		{
		}

		internal void RunPresenceHeartbeat(bool pause, int pauseTime)
		{
		}
	}
}
