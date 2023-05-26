using System;
using System.Collections.Generic;

namespace PubNubAPI
{
	public class LeaveRequestBuilder : PubNubNonSubBuilder<LeaveRequestBuilder, PNLeaveRequestResult>, IPubNubNonSubscribeBuilder<LeaveRequestBuilder, PNLeaveRequestResult>
	{
		public LeaveRequestBuilder(PubNubUnity pn)
		{
			((PubNubNonSubBuilder<, >)(object)this)._002Ector((PubNubUnity)null, default(PNOperationType));
		}

		public void ChannelGroups(List<string> channelGroupNames)
		{
		}

		public void Channels(List<string> channelNames)
		{
		}

		public void Async(Action<PNLeaveRequestResult, PNStatus> callback)
		{
		}

		protected override void RunWebRequest(QueueManager qm)
		{
		}

		protected override void CreatePubNubResponse(object deSerializedResult, RequestState requestState)
		{
		}

		private void RemoveUnsubscribedChannelsAndDeleteUserState(List<ChannelEntity> channelEntities)
		{
		}
	}
}
