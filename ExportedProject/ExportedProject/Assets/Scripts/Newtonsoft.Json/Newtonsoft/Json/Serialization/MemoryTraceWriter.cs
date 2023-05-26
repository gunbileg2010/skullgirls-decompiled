using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	public class MemoryTraceWriter : ITraceWriter
	{
		private readonly Queue<string> _traceMessages;

		public TraceLevel LevelFilter
		{
			[CompilerGenerated]
			get
			{
				return default(TraceLevel);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Trace(TraceLevel level, string message, Exception ex)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
