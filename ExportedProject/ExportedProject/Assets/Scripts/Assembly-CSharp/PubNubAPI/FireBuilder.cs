using System;
using System.Collections.Generic;

namespace PubNubAPI
{
	public class FireBuilder
	{
		private readonly PublishRequestBuilder pubBuilder;

		public FireBuilder(PubNubUnity pn, uint counter)
		{
		}

		public FireBuilder Message(object messageToPublish)
		{
			return null;
		}

		public FireBuilder Channel(string channelName)
		{
			return null;
		}

		public FireBuilder UsePost(bool usePostRequest)
		{
			return null;
		}

		public FireBuilder Meta(Dictionary<string, string> metadata)
		{
			return null;
		}

		public FireBuilder PublishAsIs(bool publishMessageAsIs)
		{
			return null;
		}

		public void Async(Action<PNPublishResult, PNStatus> callback)
		{
		}
	}
}
