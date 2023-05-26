using System;
using System.Collections.Generic;

namespace PubNubAPI
{
	public class FetchMessagesRequestBuilder : PubNubNonSubBuilder<FetchMessagesRequestBuilder, PNFetchMessagesResult>, IPubNubNonSubscribeBuilder<FetchMessagesRequestBuilder, PNFetchMessagesResult>
	{
		private long StartTime;

		private long EndTime;

		private const ushort MaxCount = 25;

		private ushort count;

		private bool ReverseHistory;

		private bool IncludeTimetokenInHistory;

		private ushort HistoryCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public FetchMessagesRequestBuilder(PubNubUnity pn)
		{
			((PubNubNonSubBuilder<, >)(object)this)._002Ector((PubNubUnity)null, default(PNOperationType));
		}

		public FetchMessagesRequestBuilder IncludeTimetoken(bool include)
		{
			return null;
		}

		public FetchMessagesRequestBuilder Reverse(bool reverseHistory)
		{
			return null;
		}

		public FetchMessagesRequestBuilder Start(long startTime)
		{
			return null;
		}

		public FetchMessagesRequestBuilder End(long endTime)
		{
			return null;
		}

		public FetchMessagesRequestBuilder Channel(List<string> channelNames)
		{
			return null;
		}

		public FetchMessagesRequestBuilder Count(ushort historyCount)
		{
			return null;
		}

		public void Async(Action<PNFetchMessagesResult, PNStatus> callback)
		{
		}

		protected override void RunWebRequest(QueueManager qm)
		{
		}

		protected override void CreatePubNubResponse(object deSerializedResult, RequestState requestState)
		{
		}

		protected bool CreateFetchMessagesResult(object objChannelsDict, out Dictionary<string, List<PNMessageResult>> channelsResult)
		{
			channelsResult = null;
			return false;
		}
	}
}
