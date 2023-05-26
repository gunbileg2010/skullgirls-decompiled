using System;

namespace PubNubAPI
{
	public class DeleteMessagesBuilder
	{
		private readonly DeleteMessagesRequestBuilder pubBuilder;

		public DeleteMessagesBuilder(PubNubUnity pn)
		{
		}

		public DeleteMessagesBuilder Start(long startTime)
		{
			return null;
		}

		public DeleteMessagesBuilder End(long endTime)
		{
			return null;
		}

		public DeleteMessagesBuilder Channel(string channelName)
		{
			return null;
		}

		public void Async(Action<PNDeleteMessagesResult, PNStatus> callback)
		{
		}
	}
}
