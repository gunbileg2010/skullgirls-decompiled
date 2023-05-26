using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Realtime
{
	public class ConnectionHandler : MonoBehaviour
	{
		private byte fallbackThreadId;

		private bool didSendAcks;

		private int startedAckingTimestamp;

		private int deltaSinceStartedToAck;

		public int KeepAliveInBackground;

		public bool ApplyDontDestroyOnLoad;

		public LoadBalancingClient Client
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

		public int CountSendAcksOnly
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool FallbackThreadRunning => false;

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void OnApplicationQuit()
		{
		}

		public void StartFallbackSendAckThread()
		{
		}

		public void StopFallbackSendAckThread()
		{
		}

		public bool RealtimeFallbackThread()
		{
			return false;
		}
	}
}
