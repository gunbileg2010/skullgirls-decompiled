using System;
using System.Collections.Generic;

namespace PubNubAPI
{
	public class SubscriptionWorker<U>
	{
		private readonly PNUnityWebRequest webRequest;

		private readonly PubNubUnity PubNubInstance;

		private readonly HeartbeatWorker hbWorker;

		private readonly PresenceHeartbeatWorker phbWorker;

		private string webRequestId;

		private bool reconnect;

		private bool internetStatus;

		private readonly bool enableResumeOnReconnect;

		private bool resetTimetoken;

		private bool uuidChanged;

		private long lastSubscribeTimetoken;

		private long lastSubscribeTimetokenForNewMultiplex;

		private string region;

		public bool UUIDChanged
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public SubscriptionWorker(PubNubUnity pn)
		{
		}

		private void InternetAvailableHandler(object sender, EventArgs ea)
		{
		}

		private void InternetDisconnectedHandler(object sender, EventArgs ea)
		{
		}

		private void RetriesExceededHandler(object sender, EventArgs ea)
		{
		}

		~SubscriptionWorker()
		{
		}

		public void CleanUp()
		{
		}

		public void BounceRequest()
		{
		}

		public void AbortPreviousRequest(List<ChannelEntity> existingChannels)
		{
		}

		public void ContinueToSubscribeRestOfChannels()
		{
		}

		public void Add(long timetokenToUse, List<ChannelEntity> existingChannels)
		{
		}

		private bool CheckAllChannelsAreUnsubscribed()
		{
			return false;
		}

		private long SaveLastTimetoken(long timetoken)
		{
			return 0L;
		}

		private void RunSubscribeRequest(long timetoken, bool reconnect)
		{
		}

		private SubscribeEnvelope ParseReceiedJSONV2(string jsonString)
		{
			return null;
		}

		private void ParseReceiedTimetoken(bool reconnect, long receivedTimetoken)
		{
		}

		private void SubscribePresenceHanlder(CustomEventArgs cea)
		{
		}

		internal void ProcessResponse(ref SubscribeEnvelope resultSubscribeEnvelope, RequestState pnRequestState)
		{
		}

		internal void SendResponseToConnectCallback(RequestState pnRequestState)
		{
		}

		internal void FindChannelEntityAndCallback(SubscribeMessage subscribeMessage, ChannelIdentity ci)
		{
		}

		internal void ResponseToUserCallbackForSubscribe(List<SubscribeMessage> subscribeMessages)
		{
		}

		public void CreateEventArgsAndRaiseEvent(PNStatus pnStatus)
		{
		}

		protected void ExceptionHandler(RequestState pnRequestState)
		{
		}

		private void WebRequestCompleteHandler(object sender, EventArgs ea)
		{
		}

		internal void CreatePNMessageResult(SubscribeMessage subscribeMessage, out PNMessageResult messageResult)
		{
			messageResult = null;
		}

		internal PNPresenceEvent CreatePNPresenceEvent(object payload)
		{
			return null;
		}

		internal void CreatePNPresenceEventResult(SubscribeMessage subscribeMessage, out PNPresenceEventResult messageResult)
		{
			messageResult = null;
		}
	}
}
