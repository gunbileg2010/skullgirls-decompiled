using System;

namespace PubNubAPI
{
	public class ListPushProvisionsBuilder
	{
		private readonly ListPushProvisionsRequestBuilder pubBuilder;

		public ListPushProvisionsBuilder DeviceID(string deviceIdForPush)
		{
			return null;
		}

		public ListPushProvisionsBuilder PushType(PNPushType pnPushType)
		{
			return null;
		}

		public ListPushProvisionsBuilder(PubNubUnity pn)
		{
		}

		public void Async(Action<PNPushListProvisionsResult, PNStatus> callback)
		{
		}
	}
}
