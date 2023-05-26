using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Open.Nat;
using UnityEngine;

public class OpenNATProtocol
{
	public class UnityLogTraceListener : TraceListener
	{
		private static object _sync;

		public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
		{
		}

		public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args)
		{
		}

		public override void WriteLine(string message)
		{
		}

		public override void Write(string message)
		{
		}

		private static void WriteColor(string message, Color color)
		{
		}
	}

	private int targetLocalPort;

	private int portToOpen;

	private string id;

	private bool showDebug;

	private NatDiscoverer natDiscoverer;

	private NatDevice natDevice;

	private static string portDescriptionString;

	public OpenNATProtocol(int targetLocalPort, int portToOpen, string id, bool showDebug)
	{
	}

	public void Execute(Action<bool> callback)
	{
	}

	public static void Cleanup()
	{
	}

	private void DoOpenNATProtocol(Action<bool> callback)
	{
	}

	private bool RunTask(Task task)
	{
		return false;
	}
}
