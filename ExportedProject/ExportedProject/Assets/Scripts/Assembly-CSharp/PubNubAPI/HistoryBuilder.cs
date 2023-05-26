using System;

namespace PubNubAPI
{
	public class HistoryBuilder
	{
		private readonly HistoryRequestBuilder pubBuilder;

		public HistoryBuilder(PubNubUnity pn)
		{
		}

		public HistoryBuilder IncludeTimetoken(bool includeTimetokenForHistory)
		{
			return null;
		}

		public HistoryBuilder Reverse(bool reverseHistory)
		{
			return null;
		}

		public HistoryBuilder Start(long startTime)
		{
			return null;
		}

		public HistoryBuilder End(long endTime)
		{
			return null;
		}

		public HistoryBuilder Channel(string channelName)
		{
			return null;
		}

		public HistoryBuilder Count(ushort historyCount)
		{
			return null;
		}

		public void Async(Action<PNHistoryResult, PNStatus> callback)
		{
		}
	}
}
