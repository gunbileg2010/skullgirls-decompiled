using System;

namespace PubNubAPI
{
	public class TimeRequestBuilder : PubNubNonSubBuilder<TimeRequestBuilder, PNTimeResult>, IPubNubNonSubscribeBuilder<TimeRequestBuilder, PNTimeResult>
	{
		public TimeRequestBuilder(PubNubUnity pn)
		{
			((PubNubNonSubBuilder<, >)(object)this)._002Ector((PubNubUnity)null, default(PNOperationType));
		}

		public void Async(Action<PNTimeResult, PNStatus> callback)
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
