using System;
using System.Collections.Generic;

namespace PubNubAPI
{
	public class PublishBuilder
	{
		private readonly PublishRequestBuilder pubBuilder;

		public PublishBuilder(PubNubUnity pn, uint counter)
		{
		}

		public PublishBuilder Message(object messageToPublish)
		{
			return null;
		}

		public PublishBuilder Channel(string channelName)
		{
			return null;
		}

		public PublishBuilder ShouldStore(bool shouldStoreInHistory)
		{
			return null;
		}

		public PublishBuilder UsePost(bool usePostRequest)
		{
			return null;
		}

		public PublishBuilder Meta(Dictionary<string, string> metadata)
		{
			return null;
		}

		public PublishBuilder PublishAsIs(bool publishMessageAsIs)
		{
			return null;
		}

		public PublishBuilder Replicate(bool replicateMessage)
		{
			return null;
		}

		public PublishBuilder Ttl(int publishTTL)
		{
			return null;
		}

		public void Async(Action<PNPublishResult, PNStatus> callback)
		{
		}
	}
}
