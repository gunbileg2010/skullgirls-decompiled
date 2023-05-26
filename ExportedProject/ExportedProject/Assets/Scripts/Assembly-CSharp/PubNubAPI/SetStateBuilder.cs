using System;
using System.Collections.Generic;

namespace PubNubAPI
{
	public class SetStateBuilder
	{
		private readonly SetStateRequestBuilder pubBuilder;

		public SetStateBuilder(PubNubUnity pn)
		{
		}

		public SetStateBuilder UUID(string uuidForState)
		{
			return null;
		}

		public SetStateBuilder State(Dictionary<string, object> stateToSet)
		{
			return null;
		}

		public SetStateBuilder Channels(List<string> channelNames)
		{
			return null;
		}

		public SetStateBuilder ChannelGroups(List<string> channelGroupNames)
		{
			return null;
		}

		public void Async(Action<PNSetStateResult, PNStatus> callback)
		{
		}
	}
}
