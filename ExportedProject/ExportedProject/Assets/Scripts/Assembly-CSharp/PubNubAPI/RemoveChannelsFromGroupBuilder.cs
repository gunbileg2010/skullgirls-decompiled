using System;
using System.Collections.Generic;

namespace PubNubAPI
{
	public class RemoveChannelsFromGroupBuilder
	{
		private readonly RemoveChannelsFromGroupRequestBuilder pubBuilder;

		public RemoveChannelsFromGroupBuilder Channels(List<string> channelNames)
		{
			return null;
		}

		public RemoveChannelsFromGroupBuilder ChannelGroup(string channelGroupNames)
		{
			return null;
		}

		public RemoveChannelsFromGroupBuilder(PubNubUnity pn)
		{
		}

		public void Async(Action<PNChannelGroupsRemoveChannelResult, PNStatus> callback)
		{
		}
	}
}
