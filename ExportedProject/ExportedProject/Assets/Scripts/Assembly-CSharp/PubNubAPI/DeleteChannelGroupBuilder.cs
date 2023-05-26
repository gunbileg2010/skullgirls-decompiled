using System;

namespace PubNubAPI
{
	public class DeleteChannelGroupBuilder
	{
		private readonly DeleteChannelGroupRequestBuilder pubBuilder;

		public DeleteChannelGroupBuilder ChannelGroup(string channelGroupName)
		{
			return null;
		}

		public DeleteChannelGroupBuilder(PubNubUnity pn)
		{
		}

		public void Async(Action<PNChannelGroupsDeleteGroupResult, PNStatus> callback)
		{
		}
	}
}
