using System;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class DeleteChannelGroupRequestBuilder : PubNubNonSubBuilder<DeleteChannelGroupRequestBuilder, PNChannelGroupsDeleteGroupResult>, IPubNubNonSubscribeBuilder<DeleteChannelGroupRequestBuilder, PNChannelGroupsDeleteGroupResult>
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

		public DeleteChannelGroupRequestBuilder(PubNubUnity pn)
		{
			((PubNubNonSubBuilder<, >)(object)this)._002Ector((PubNubUnity)null, default(PNOperationType));
		}

		public void ChannelGroup(string channelGroupName)
		{
		}

		public void Async(Action<PNChannelGroupsDeleteGroupResult, PNStatus> callback)
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
