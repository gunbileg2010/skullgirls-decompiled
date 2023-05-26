using System;
using System.Collections.Generic;

namespace PubNubAPI
{
	public class UnsubscribeBuilder
	{
		private readonly LeaveRequestBuilder pubBuilder;

		public UnsubscribeBuilder Channels(List<string> channelNames)
		{
			return null;
		}

		public UnsubscribeBuilder ChannelGroups(List<string> channelGroupNames)
		{
			return null;
		}

		public UnsubscribeBuilder(PubNubUnity pn)
		{
		}

		public void Async(Action<PNLeaveRequestResult, PNStatus> callback)
		{
		}
	}
}
