using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class RemoveChannelsFromPushRequestBuilder : PubNubNonSubBuilder<RemoveChannelsFromPushRequestBuilder, PNPushRemoveChannelResult>, IPubNubNonSubscribeBuilder<RemoveChannelsFromPushRequestBuilder, PNPushRemoveChannelResult>
	{
		private string DeviceIDForPush
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

		public PNPushType PushType
		{
			[CompilerGenerated]
			get
			{
				return default(PNPushType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public RemoveChannelsFromPushRequestBuilder(PubNubUnity pn)
		{
			((PubNubNonSubBuilder<, >)(object)this)._002Ector((PubNubUnity)null, default(PNOperationType));
		}

		public void Channels(List<string> channelNames)
		{
		}

		public void DeviceId(string deviceIdForPush)
		{
		}

		public void Async(Action<PNPushRemoveChannelResult, PNStatus> callback)
		{
		}

		protected override void RunWebRequest(QueueManager qm)
		{
		}

		protected override void CreatePubNubResponse(object deSerializedResult, RequestState requestState)
		{
		}
	}
}
