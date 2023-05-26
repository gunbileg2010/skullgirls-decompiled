using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class RemoveChannelsFromGroupRequestBuilder : PubNubNonSubBuilder<RemoveChannelsFromGroupRequestBuilder, PNChannelGroupsRemoveChannelResult>, IPubNubNonSubscribeBuilder<RemoveChannelsFromGroupRequestBuilder, PNChannelGroupsRemoveChannelResult>
	{
		private string ChannelGroupToDelete
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

		public RemoveChannelsFromGroupRequestBuilder(PubNubUnity pn)
		{
			((PubNubNonSubBuilder<, >)(object)this)._002Ector((PubNubUnity)null, default(PNOperationType));
		}

		public void Channels(List<string> channelNames)
		{
		}

		public void ChannelGroup(string channelGroupName)
		{
		}

		public void Async(Action<PNChannelGroupsRemoveChannelResult, PNStatus> callback)
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
