using System.Runtime.CompilerServices;
using UnityEngine;

namespace PubNubAPI
{
	public class PubNubUnityBase
	{
		protected Counter publishMessageCounter;

		private const string build = "4.0.1";

		private string pnsdkVersion;

		internal PNLoggingMethod PNLog;

		private IJsonLibrary jsonLibrary;

		internal bool localGobj;

		public readonly PNLatencyManager latency;

		public string Version
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public PNConfiguration PNConfig
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

		internal QueueManager QManager
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

		public IJsonLibrary JsonLibrary
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal GameObject GameObjectRef
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

		public Subscription SubscriptionInstance
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

		internal SubscriptionWorker<SubscribeEnvelope> SubWorker
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

		public PNLatencyManager Latency => null;

		public PubNubUnityBase(PNConfiguration pnConfiguration, GameObject gameObjectRef, IJsonLibrary jsonLibrary)
		{
		}

		public void CleanUp()
		{
		}
	}
}
