using System;

namespace PubNubAPI
{
	public class NonSubscribeWorker<U, V> : IDisposable where V : class
	{
		private readonly QueueManager queueManager;

		private PubNubNonSubBuilder<U, V> PNBuilder;

		private static int InstanceCount;

		private string webRequestId;

		private static object syncRoot;

		private readonly PNUnityWebRequest webRequest;

		public void Dispose()
		{
		}

		public NonSubscribeWorker(QueueManager queueManager)
		{
		}

		public void RunWebRequest(RequestState requestState, PubNubNonSubBuilder<U, V> pnBuilder)
		{
		}

		public void ProcessNonSubscribeResult(RequestState pubnubRequestState, string jsonString)
		{
		}

		private void WebRequestCompleteHandler(object sender, EventArgs ea)
		{
		}
	}
}
