using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class AddChannelsToChannelGroupRequestBuilder : PubNubNonSubBuilder<AddChannelsToChannelGroupRequestBuilder, PNChannelGroupsAddChannelResult>, IPubNubNonSubscribeBuilder<AddChannelsToChannelGroupRequestBuilder, PNChannelGroupsAddChannelResult>
	{
		private string ChannelGroupToAdd
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public AddChannelsToChannelGroupRequestBuilder(PubNubUnity pn)
		{
			((PubNubNonSubBuilder<, >)(object)this)._002Ector((PubNubUnity)null, default(PNOperationType));
		}

		public void Channels(List<string> channelNames)
		{
		}

		public void ChannelGroup(string channelGroupName)
		{
		}

		public void Async(Action<PNChannelGroupsAddChannelResult, PNStatus> callback)
		{
		}

		protected override void RunWebRequest(QueueManager qm)
		{
		}

		protected override void CreatePubNubResponse(object deSerializedResult, RequestState requestState)
		{
		}
	}
}
