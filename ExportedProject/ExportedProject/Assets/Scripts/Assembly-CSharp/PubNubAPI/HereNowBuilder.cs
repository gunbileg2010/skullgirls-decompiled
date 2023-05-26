using System;
using System.Collections.Generic;

namespace PubNubAPI
{
	public class HereNowBuilder
	{
		private readonly HereNowRequestBuilder pubBuilder;

		public HereNowBuilder(PubNubUnity pn)
		{
		}

		public HereNowBuilder IncludeUUIDs(bool includeUUIDInHereNow)
		{
			return null;
		}

		public HereNowBuilder IncludeState(bool includeStateInHereNow)
		{
			return null;
		}

		public HereNowBuilder Channels(List<string> channelNames)
		{
			return null;
		}

		public HereNowBuilder ChannelGroups(List<string> channelGroupNames)
		{
			return null;
		}

		public void Async(Action<PNHereNowResult, PNStatus> callback)
		{
		}
	}
}
