using System;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class HistoryRequestBuilder : PubNubNonSubBuilder<HistoryRequestBuilder, PNHistoryResult>, IPubNubNonSubscribeBuilder<HistoryRequestBuilder, PNHistoryResult>
	{
		private long StartTime;

		private long EndTime;

		private const ushort MaxCount = 100;

		private ushort count;

		private bool ReverseHistory;

		private bool IncludeTimetokenInHistory;

		private string HistoryChannel
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

		public HistoryRequestBuilder(PubNubUnity pn)
		{
			((PubNubNonSubBuilder<, >)(object)this)._002Ector((PubNubUnity)null, default(PNOperationType));
		}

		public HistoryRequestBuilder IncludeTimetoken(bool include)
		{
			return null;
		}

		public HistoryRequestBuilder Reverse(bool reverseHistory)
		{
			return null;
		}

		public HistoryRequestBuilder Start(long startTime)
		{
			return null;
		}

		public HistoryRequestBuilder End(long endTime)
		{
			return null;
		}

		public HistoryRequestBuilder Channel(string channelName)
		{
			return null;
		}

		public HistoryRequestBuilder Count(ushort historyCount)
		{
			return null;
		}

		public void Async(Action<PNHistoryResult, PNStatus> callback)
		{
		}

		protected override void RunWebRequest(QueueManager qm)
		{
		}

		protected override void CreatePubNubResponse(object deSerializedResult, RequestState requestState)
		{
		}

		private void ExtractMessageWithTimetokens(object element, string cipherKey, out PNHistoryItemResult pnHistoryItemResult)
		{
			pnHistoryItemResult = null;
		}

		private void ExtractMessage(object element, string cipherKey, out PNHistoryItemResult pnHistoryItemResult)
		{
			pnHistoryItemResult = null;
		}

		private bool ExtractMessages(object[] historyResponseArray, ref PNHistoryResult pnHistoryResult)
		{
			return false;
		}
	}
}
