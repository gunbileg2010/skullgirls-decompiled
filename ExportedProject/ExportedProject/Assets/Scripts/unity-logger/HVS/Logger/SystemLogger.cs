using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace HVS.Logger
{
	public class SystemLogger
	{
		private CentralLogHandler logHandler;

		private string tag;

		private string tagColor;

		public LogType filterLogType
		{
			[CompilerGenerated]
			get
			{
				return default(LogType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool logEnabled
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public SystemLogger()
		{
		}

		public SystemLogger(string tag, Color tagColor)
		{
		}

		public void Log(object message)
		{
		}

		public void LogWarning(object message)
		{
		}

		public void LogError(object message)
		{
		}

		private static string GetString(object message)
		{
			return null;
		}

		private bool IsLogTypeAllowed(LogType logType)
		{
			return false;
		}

		[DebuggerHidden]
		private void SendToLogHandler(LogType logType, object message, Object context)
		{
		}
	}
}
