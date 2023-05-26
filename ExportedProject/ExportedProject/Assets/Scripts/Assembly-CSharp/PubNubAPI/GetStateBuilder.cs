using System;
using System.Collections.Generic;

namespace PubNubAPI
{
	public class GetStateBuilder
	{
		private readonly GetStateRequestBuilder pubBuilder;

		public GetStateBuilder(PubNubUnity pn)
		{
		}

		public GetStateBuilder UUID(string uuidForState)
		{
			return null;
		}

		public GetStateBuilder Channels(List<string> channelNames)
		{
			return null;
		}

		public GetStateBuilder ChannelGroups(List<string> channelGroupNames)
		{
			return null;
		}

		public void Async(Action<PNGetStateResult, PNStatus> callback)
		{
		}
	}
}
