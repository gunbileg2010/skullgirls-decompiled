using System;
using System.Threading;
using System.Threading.Tasks;

namespace Open.Nat
{
	public static class TaskExtension
	{
		public static Task Delay(TimeSpan delay, CancellationToken token)
		{
			return null;
		}

		public static Task<Task> WhenAny(params Task[] tasks)
		{
			return null;
		}

		public static Task WhenAll(params Task[] tasks)
		{
			return null;
		}
	}
}
