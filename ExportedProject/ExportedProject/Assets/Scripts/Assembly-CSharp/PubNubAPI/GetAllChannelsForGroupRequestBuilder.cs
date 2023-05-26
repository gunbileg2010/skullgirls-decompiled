using System;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class GetAllChannelsForGroupRequestBuilder : PubNubNonSubBuilder<GetAllChannelsForGroupRequestBuilder, PNChannelGroupsAllChannelsResult>, IPubNubNonSubscribeBuilder<GetAllChannelsForGroupRequestBuilder, PNChannelGroupsAllChannelsResult>
	{
		private string ChannelGroupToList
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

		public GetAllChannelsForGroupRequestBuilder(PubNubUnity pn)
		{
			((PubNubNonSubBuilder<, >)(object)this)._002Ector((PubNubUnity)null, default(PNOperationType));
		}

		public void ChannelGroup(string channelGroupName)
		{
		}

		public void Async(Action<PNChannelGroupsAllChannelsResult, PNStatus> callback)
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
