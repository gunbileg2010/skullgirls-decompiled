using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PubNubAPI
{
	public class PubNub
	{
		private PubNubUnity pnUnity;

		private bool cleanedUp;

		private readonly IJsonLibrary jsonLibrary;

		private readonly GameObject gameObj;

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

		public GameObject GameObjectRef => null;

		public string Version => null;

		public IJsonLibrary JsonLibrary => null;

		public event EventHandler<EventArgs> SusbcribeCallback
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

		private void PubNubUnityInitializationAfterCleanup()
		{
		}

		private void RaiseEvent(EventArgs ea)
		{
		}

		public PubNub(PNConfiguration pnConfiguration)
		{
		}

		public PubNub(PNConfiguration pnConfiguration, GameObject gameObjectRef)
		{
		}

		private PubNub(PNConfiguration pnConfiguration, GameObject gameObjectRef, IJsonLibrary jsonLibrary)
		{
		}

		public void CleanUp()
		{
		}

		~PubNub()
		{
		}

		public void Reconnect()
		{
		}

		public SubscribeBuilder Subscribe()
		{
			return null;
		}

		public TimeBuilder Time()
		{
			return null;
		}

		public WhereNowBuilder WhereNow()
		{
			return null;
		}

		public HereNowBuilder HereNow()
		{
			return null;
		}

		public HistoryBuilder History()
		{
			return null;
		}

		public FetchBuilder FetchMessages()
		{
			return null;
		}

		public DeleteMessagesBuilder DeleteMessages()
		{
			return null;
		}

		public PublishBuilder Publish()
		{
			return null;
		}

		public FireBuilder Fire()
		{
			return null;
		}

		public UnsubscribeBuilder Unsubscribe()
		{
			return null;
		}

		public UnsubscribeAllBuilder UnsubscribeAll()
		{
			return null;
		}

		public GetStateBuilder GetPresenceState()
		{
			return null;
		}

		public SetStateBuilder SetPresenceState()
		{
			return null;
		}

		public AddChannelsToChannelGroupBuilder AddChannelsToChannelGroup()
		{
			return null;
		}

		public DeleteChannelGroupBuilder DeleteChannelGroup()
		{
			return null;
		}

		public RemoveChannelsFromGroupBuilder RemoveChannelsFromChannelGroup()
		{
			return null;
		}

		public GetAllChannelsForGroupBuilder ListChannelsForChannelGroup()
		{
			return null;
		}

		public AddChannelsToPushBuilder AddPushNotificationsOnChannels()
		{
			return null;
		}

		public ListPushProvisionsBuilder AuditPushChannelProvisions()
		{
			return null;
		}

		public RemoveAllPushChannelsForDeviceBuilder RemoveAllPushNotifications()
		{
			return null;
		}

		public RemoveChannelsFromPushBuilder RemovePushNotificationsFromChannels()
		{
			return null;
		}

		public void AddListener(Action<PNStatus> callback, Action<PNMessageResult> callback2, Action<PNPresenceEventResult> callback3)
		{
		}

		public static long TranslateDateTimeToPubnubUnixNanoSeconds(DateTime dotNetUTCDateTime)
		{
			return 0L;
		}

		public static DateTime TranslatePubnubUnixNanoSecondsToDateTime(long unixNanoSecondTime)
		{
			return default(DateTime);
		}
	}
}
