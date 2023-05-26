using System;

namespace PubNubAPI
{
	public class RemoveAllPushChannelsForDeviceBuilder
	{
		private readonly RemoveAllPushChannelsForDeviceRequestBuilder pubBuilder;

		public RemoveAllPushChannelsForDeviceBuilder DeviceID(string deviceIdForPush)
		{
			return null;
		}

		public RemoveAllPushChannelsForDeviceBuilder PushType(PNPushType pnPushType)
		{
			return null;
		}

		public RemoveAllPushChannelsForDeviceBuilder(PubNubUnity pn)
		{
		}

		public void Async(Action<PNPushRemoveAllChannelsResult, PNStatus> callback)
		{
		}
	}
}
