using System;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class RemoveAllPushChannelsForDeviceRequestBuilder : PubNubNonSubBuilder<RemoveAllPushChannelsForDeviceRequestBuilder, PNPushRemoveAllChannelsResult>, IPubNubNonSubscribeBuilder<RemoveAllPushChannelsForDeviceRequestBuilder, PNPushRemoveAllChannelsResult>
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

		public RemoveAllPushChannelsForDeviceRequestBuilder(PubNubUnity pn)
		{
			((PubNubNonSubBuilder<, >)(object)this)._002Ector((PubNubUnity)null, default(PNOperationType));
		}

		public void DeviceId(string deviceIdForPush)
		{
		}

		public void Async(Action<PNPushRemoveAllChannelsResult, PNStatus> callback)
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
