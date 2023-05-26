using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	public class DiagnosticsTraceWriter : ITraceWriter
	{
		public TraceLevel LevelFilter
		{
			[CompilerGenerated]
			get
			{
				return default(TraceLevel);
			}
		}

		private TraceEventType GetTraceEventType(TraceLevel level)
		{
			return default(TraceEventType);
		}

		public void Trace(TraceLevel level, string message, Exception ex)
		{
		}
	}
}
