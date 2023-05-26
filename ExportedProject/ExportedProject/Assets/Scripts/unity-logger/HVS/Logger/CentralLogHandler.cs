using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace HVS.Logger
{
	public class CentralLogHandler : ILogHandler
	{
		private static CentralLogHandler instance;

		private ILogHandler defaultLogHandler;

		private List<ILogHandler> additionalLogHandlers;

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

		private CentralLogHandler()
		{
		}

		public static CentralLogHandler GetInstance()
		{
			return null;
		}

		[DebuggerHidden]
		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[DebuggerHidden]
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		private bool IsLogTypeAllowed(LogType logType)
		{
			return false;
		}
	}
}
