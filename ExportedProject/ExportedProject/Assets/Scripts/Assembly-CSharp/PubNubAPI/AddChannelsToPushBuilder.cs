using System;
using System.Collections.Generic;

namespace PubNubAPI
{
	public class AddChannelsToPushBuilder
	{
		private readonly AddChannelsToPushRequestBuilder pubBuilder;

		public AddChannelsToPushBuilder Channels(List<string> channelNames)
		{
			return null;
		}

		public AddChannelsToPushBuilder DeviceID(string deviceIdForPush)
		{
			return null;
		}

		public AddChannelsToPushBuilder PushType(PNPushType pnPushType)
		{
			return null;
		}

		public AddChannelsToPushBuilder(PubNubUnity pn)
		{
		}

		public void Async(Action<PNPushAddChannelResult, PNStatus> callback)
		{
		}
	}
}
