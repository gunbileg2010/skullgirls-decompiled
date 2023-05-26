using System.Collections;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public sealed class RequestQueue
	{
		private static RequestQueue instance;

		private static object syncRoot;

		private readonly Queue q;

		public int QueueCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool HasItems
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static RequestQueue Instance => null;

		private RequestQueue()
		{
		}

		public void Enqueue(object callback, PNOperationType operationType, object operationParams, PubNubUnity pn)
		{
		}

		internal QueueStorage Dequeue()
		{
			return null;
		}

		public void Reset()
		{
		}
	}
}
