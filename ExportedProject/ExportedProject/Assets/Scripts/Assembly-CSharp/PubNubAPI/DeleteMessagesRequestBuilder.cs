using System;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class DeleteMessagesRequestBuilder : PubNubNonSubBuilder<DeleteMessagesRequestBuilder, PNDeleteMessagesResult>, IPubNubNonSubscribeBuilder<DeleteMessagesRequestBuilder, PNDeleteMessagesResult>
	{
		private long StartTime;

		private long EndTime;

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

		public void Start(long startTime)
		{
		}

		public void End(long endTime)
		{
		}

		public void Channel(string channelName)
		{
		}

		public DeleteMessagesRequestBuilder(PubNubUnity pn)
		{
			((PubNubNonSubBuilder<, >)(object)this)._002Ector((PubNubUnity)null, default(PNOperationType));
		}

		public void Async(Action<PNDeleteMessagesResult, PNStatus> callback)
		{
		}

		protected override void RunWebRequest(QueueManager qm)
		{
		}

		protected override void CreatePubNubResponse(object deSerializedResult, RequestState requestState)
		{
		}
	}
}
