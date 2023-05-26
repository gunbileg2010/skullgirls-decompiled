using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class HereNowRequestBuilder : PubNubNonSubBuilder<HereNowRequestBuilder, PNHereNowResult>, IPubNubNonSubscribeBuilder<HereNowRequestBuilder, PNHereNowResult>
	{
		private bool IncludeStateInHereNow
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private bool IncludeUUIDsInHereNow
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public HereNowRequestBuilder(PubNubUnity pn)
		{
			((PubNubNonSubBuilder<, >)(object)this)._002Ector((PubNubUnity)null, default(PNOperationType));
		}

		public void IncludeUUIDs(bool includeUUIDsInHereNow)
		{
		}

		public void IncludeState(bool includeStateInHereNow)
		{
		}

		public void Channels(List<string> channelNames)
		{
		}

		public void ChannelGroups(List<string> channelGroupNames)
		{
		}

		public void Async(Action<PNHereNowResult, PNStatus> callback)
		{
		}

		protected override void RunWebRequest(QueueManager qm)
		{
		}

		protected override void CreatePubNubResponse(object deSerializedResult, RequestState requestState)
		{
		}

		protected bool CreateHereNowResult(object objChannelsDict, out Dictionary<string, PNHereNowChannelData> channelsResult)
		{
			channelsResult = null;
			return false;
		}
	}
}
