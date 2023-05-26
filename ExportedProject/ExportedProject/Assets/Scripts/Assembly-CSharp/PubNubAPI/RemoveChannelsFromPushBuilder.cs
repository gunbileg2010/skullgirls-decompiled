using System;
using System.Collections.Generic;

namespace PubNubAPI
{
	public class RemoveChannelsFromPushBuilder
	{
		private readonly RemoveChannelsFromPushRequestBuilder pubBuilder;

		public RemoveChannelsFromPushBuilder Channels(List<string> channelNames)
		{
			return null;
		}

		public RemoveChannelsFromPushBuilder DeviceID(string deviceIdForPush)
		{
			return null;
		}

		public RemoveChannelsFromPushBuilder PushType(PNPushType pnPushType)
		{
			return null;
		}

		public RemoveChannelsFromPushBuilder(PubNubUnity pn)
		{
		}

		public void Async(Action<PNPushRemoveChannelResult, PNStatus> callback)
		{
		}
	}
}
