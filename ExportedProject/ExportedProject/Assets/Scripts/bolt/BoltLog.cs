using System;
using System.Collections.Generic;
using System.Threading;

public static class BoltLog
{
	public interface IWriter : IDisposable
	{
		void Info(string message);

		void Debug(string message);

		void Warn(string message);

		void Error(string message);
	}

	internal class File : IWriter, IDisposable
	{
		private bool running;

		private bool isServer;

		private Thread thread;

		private AutoResetEvent threadEvent;

		private Queue<string> threadQueue;

		public File(bool server)
		{
		}

		private void Queue(string message)
		{
		}

		private void BoltLog_002EIWriter_002EInfo(string message)
		{
		}

		private void BoltLog_002EIWriter_002EDebug(string message)
		{
		}

		private void BoltLog_002EIWriter_002EWarn(string message)
		{
		}

		private void BoltLog_002EIWriter_002EError(string message)
		{
		}

		public void Dispose()
		{
		}

		private void WriteLoop()
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	internal class ConsoleWriter : IWriter, IDisposable
	{
		private void BoltLog_002EIWriter_002EInfo(string message)
		{
		}

		private void BoltLog_002EIWriter_002EDebug(string message)
		{
		}

		private void BoltLog_002EIWriter_002EWarn(string message)
		{
		}

		private void BoltLog_002EIWriter_002EError(string message)
		{
		}

		public void Dispose()
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	internal class SystemOutWriter : IWriter, IDisposable
	{
		private void BoltLog_002EIWriter_002EInfo(string message)
		{
		}

		private void BoltLog_002EIWriter_002EDebug(string message)
		{
		}

		private void BoltLog_002EIWriter_002EWarn(string message)
		{
		}

		private void BoltLog_002EIWriter_002EError(string message)
		{
		}

		public void Dispose()
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	internal class UnityWriter : IWriter, IDisposable
	{
		private void BoltLog_002EIWriter_002EInfo(string message)
		{
		}

		private void BoltLog_002EIWriter_002EDebug(string message)
		{
		}

		private void BoltLog_002EIWriter_002EWarn(string message)
		{
		}

		private void BoltLog_002EIWriter_002EError(string message)
		{
		}

		public void Dispose()
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	private static readonly object _lock;

	private static List<IWriter> _writers;

	public static void RemoveAll()
	{
	}

	public static void Add<T>(T instance) where T : class, IWriter
	{
	}

	public static void Info(string message)
	{
	}

	public static void Info(object message)
	{
	}

	public static void Info(string message, object arg0)
	{
	}

	public static void Info(string message, object arg0, object arg1)
	{
	}

	public static void Info(string message, object arg0, object arg1, object arg2)
	{
	}

	public static void Info(string message, params object[] args)
	{
	}

	internal static void Debug(string message)
	{
	}

	internal static void Debug(object message)
	{
	}

	internal static void Debug(string message, object arg0)
	{
	}

	internal static void Debug(string message, object arg0, object arg1)
	{
	}

	internal static void Debug(string message, object arg0, object arg1, object arg2)
	{
	}

	internal static void Debug(string message, params object[] args)
	{
	}

	public static void Warn(string message)
	{
	}

	public static void Warn(object message)
	{
	}

	public static void Warn(string message, object arg0)
	{
	}

	public static void Warn(string message, object arg0, object arg1)
	{
	}

	public static void Warn(string message, object arg0, object arg1, object arg2)
	{
	}

	public static void Warn(string message, params object[] args)
	{
	}

	private static object[] FixNulls(object[] args)
	{
		return null;
	}

	public static void Error(string message)
	{
	}

	public static void Error(object message)
	{
	}

	public static void Error(string message, object arg0)
	{
	}

	public static void Error(string message, object arg0, object arg1)
	{
	}

	public static void Error(string message, object arg0, object arg1, object arg2)
	{
	}

	public static void Error(string message, params object[] args)
	{
	}

	public static void Exception(Exception exception)
	{
	}

	private static string Format(object message)
	{
		return null;
	}

	private static string Format(string message, object arg0)
	{
		return null;
	}

	private static string Format(string message, object arg0, object arg1)
	{
		return null;
	}

	private static string Format(string message, object arg0, object arg1, object arg2)
	{
		return null;
	}

	private static string Format(string message, object[] args)
	{
		return null;
	}

	internal static void Setup(BoltNetworkModes mode, BoltConfigLogTargets logTargets)
	{
	}
}
