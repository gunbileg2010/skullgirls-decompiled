using System;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	internal class HeartbeatWorker
	{
		private readonly PNUnityWebRequest webRequest;

		private readonly PubNubUnity PubNubInstance;

		private bool keepHearbeatRunning;

		private bool isHearbeatRunning;

		private string webRequestId;

		private bool internetStatus;

		private int heartbeatInterval;

		private const int MINEXPONENTIALBACKOFF = 1;

		private const int MAXEXPONENTIALBACKOFF = 32;

		private int retryCount;

		public int HeartbeatInterval
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public event EventHandler<EventArgs> InternetDisconnected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<EventArgs> InternetAvailable
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<EventArgs> RetriesExceeded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal HeartbeatWorker(PubNubUnity pn, PNUnityWebRequest webRequest)
		{
		}

		~HeartbeatWorker()
		{
		}

		internal void CleanUp()
		{
		}

		private void WebRequestCompleteHandler(object sender, EventArgs ea)
		{
		}

		internal void StopHeartbeat()
		{
		}

		internal void ResetInternetCheckSettings()
		{
		}

		private void StartHeartbeat(bool pause, int pauseTime)
		{
		}

		internal void RunHeartbeat(bool pause, int pauseTime)
		{
		}

		private void HeartbeatHandler(CustomEventArgs cea)
		{
		}

		private void RetryLoop()
		{
		}

		private void InternetConnectionAvailableHandler(CustomEventArgs cea)
		{
		}
	}
}
