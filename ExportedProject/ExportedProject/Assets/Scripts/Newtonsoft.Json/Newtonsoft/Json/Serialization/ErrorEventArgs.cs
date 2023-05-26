using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	public class ErrorEventArgs : EventArgs
	{
		private object CurrentObject
		{
			[CompilerGenerated]
			set
			{
			}
		}

		private ErrorContext ErrorContext
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public ErrorEventArgs(object currentObject, ErrorContext errorContext)
		{
		}
	}
}
