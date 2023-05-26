using System;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class WhereNowRequestBuilder : PubNubNonSubBuilder<WhereNowRequestBuilder, PNWhereNowResult>, IPubNubNonSubscribeBuilder<WhereNowRequestBuilder, PNWhereNowResult>
	{
		private string UuidForWhereNow
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

		public WhereNowRequestBuilder(PubNubUnity pn)
		{
			((PubNubNonSubBuilder<, >)(object)this)._002Ector((PubNubUnity)null, default(PNOperationType));
		}

		public WhereNowRequestBuilder Uuid(string uuidForWhereNow)
		{
			return null;
		}

		public void Async(Action<PNWhereNowResult, PNStatus> callback)
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
