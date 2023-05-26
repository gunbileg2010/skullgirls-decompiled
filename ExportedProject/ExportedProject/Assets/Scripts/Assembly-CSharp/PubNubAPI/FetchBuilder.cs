using System;
using System.Collections.Generic;

namespace PubNubAPI
{
	public class FetchBuilder
	{
		private readonly FetchMessagesRequestBuilder pubBuilder;

		public FetchBuilder IncludeTimetoken(bool includeTimetokenForFetch)
		{
			return null;
		}

		public FetchBuilder Reverse(bool reverseHistory)
		{
			return null;
		}

		public FetchBuilder Start(long startTime)
		{
			return null;
		}

		public FetchBuilder End(long endTime)
		{
			return null;
		}

		public FetchBuilder Channels(List<string> channelNames)
		{
			return null;
		}

		public FetchBuilder Count(ushort historyCount)
		{
			return null;
		}

		public FetchBuilder(PubNubUnity pn)
		{
		}

		public void Async(Action<PNFetchMessagesResult, PNStatus> callback)
		{
		}
	}
}
