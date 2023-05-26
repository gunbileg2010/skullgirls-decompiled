using System;
using System.Collections.Generic;

namespace PubNubAPI
{
	public class AddChannelsToChannelGroupBuilder
	{
		private readonly AddChannelsToChannelGroupRequestBuilder pubBuilder;

		public AddChannelsToChannelGroupBuilder Channels(List<string> channelNames)
		{
			return null;
		}

		public AddChannelsToChannelGroupBuilder ChannelGroup(string channelGroupName)
		{
			return null;
		}

		public AddChannelsToChannelGroupBuilder(PubNubUnity pn)
		{
		}

		public void Async(Action<PNChannelGroupsAddChannelResult, PNStatus> callback)
		{
		}
	}
}
