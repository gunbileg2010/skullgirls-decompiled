using System;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class ListPushProvisionsRequestBuilder : PubNubNonSubBuilder<ListPushProvisionsRequestBuilder, PNPushListProvisionsResult>, IPubNubNonSubscribeBuilder<ListPushProvisionsRequestBuilder, PNPushListProvisionsResult>
	{
		private string DeviceIDForPush
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

		public PNPushType PushType
		{
			[CompilerGenerated]
			get
			{
				return default(PNPushType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ListPushProvisionsRequestBuilder(PubNubUnity pn)
		{
			((PubNubNonSubBuilder<, >)(object)this)._002Ector((PubNubUnity)null, default(PNOperationType));
		}

		public void DeviceId(string deviceIdToPush)
		{
		}

		public void Async(Action<PNPushListProvisionsResult, PNStatus> callback)
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
