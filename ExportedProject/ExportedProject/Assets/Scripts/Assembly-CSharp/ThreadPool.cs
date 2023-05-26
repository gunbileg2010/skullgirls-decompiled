using System.Collections.Generic;
using System.Threading;

public static class ThreadPool
{
	private static object locker;

	private static List<Thread> workers;

	private static Queue<object> taskQueue;

	private static Queue<WaitCallback> taskCallbacks;

	public static void Init(int threadCount)
	{
	}

	public static void AddThread()
	{
	}

	public static int GetThreadCount()
	{
		return 0;
	}

	public static void EnqueueTask(WaitCallback callback, object context)
	{
	}

	public static bool PerformTask()
	{
		return false;
	}

	private static void ConsumeThread()
	{
	}
}
