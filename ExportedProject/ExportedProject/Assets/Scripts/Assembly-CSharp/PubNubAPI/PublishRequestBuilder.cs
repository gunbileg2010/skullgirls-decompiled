using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class PublishRequestBuilder : PubNubNonSubBuilder<PublishRequestBuilder, PNPublishResult>, IPubNubNonSubscribeBuilder<PublishRequestBuilder, PNPublishResult>
	{
		private bool ShouldStoreInHistory;

		private bool UsePostMethod;

		private bool ReplicateMessage;

		private bool publishAsIs;

		private readonly uint publishCounter;

		private object PublishMessage
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

		private string PublishChannel
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

		private Dictionary<string, string> Metadata
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

		private int PublishTtl
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public PublishRequestBuilder(PubNubUnity pn, uint counter)
		{
			((PubNubNonSubBuilder<, >)(object)this)._002Ector((PubNubUnity)null, default(PNOperationType));
		}

		public void Async(Action<PNPublishResult, PNStatus> callback)
		{
		}

		public PublishRequestBuilder Message(object messageToPublish)
		{
			return null;
		}

		public PublishRequestBuilder PublishAsIs(bool publishMessageAsIs)
		{
			return null;
		}

		public PublishRequestBuilder Channel(string channelName)
		{
			return null;
		}

		public PublishRequestBuilder ShouldStore(bool shouldStoreInHistory)
		{
			return null;
		}

		public PublishRequestBuilder UsePost(bool usePostRequest)
		{
			return null;
		}

		public PublishRequestBuilder Meta(Dictionary<string, string> metadata)
		{
			return null;
		}

		public PublishRequestBuilder Replicate(bool replicateMessage)
		{
			return null;
		}

		public PublishRequestBuilder Ttl(int publishTTL)
		{
			return null;
		}

		protected override void RunWebRequest(QueueManager qm)
		{
		}

		protected override void CreatePubNubResponse(object deSerializedResult, RequestState requestState)
		{
		}
	}
}
