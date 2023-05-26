using System;

namespace PubNubAPI
{
	public class GetAllChannelsForGroupBuilder
	{
		private readonly GetAllChannelsForGroupRequestBuilder pubBuilder;

		public GetAllChannelsForGroupBuilder ChannelGroup(string channelGroupName)
		{
			return null;
		}

		public GetAllChannelsForGroupBuilder(PubNubUnity pn)
		{
		}

		public void Async(Action<PNChannelGroupsAllChannelsResult, PNStatus> callback)
		{
		}
	}
}
