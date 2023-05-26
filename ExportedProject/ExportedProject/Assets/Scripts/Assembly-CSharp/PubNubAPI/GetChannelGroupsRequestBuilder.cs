using System;

namespace PubNubAPI
{
	public class GetChannelGroupsRequestBuilder : PubNubNonSubBuilder<GetChannelGroupsRequestBuilder, PNChannelGroupsListAllResult>, IPubNubNonSubscribeBuilder<GetChannelGroupsRequestBuilder, PNChannelGroupsListAllResult>
	{
		public GetChannelGroupsRequestBuilder(PubNubUnity pn)
		{
			((PubNubNonSubBuilder<, >)(object)this)._002Ector((PubNubUnity)null, default(PNOperationType));
		}

		public void Async(Action<PNChannelGroupsListAllResult, PNStatus> callback)
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
