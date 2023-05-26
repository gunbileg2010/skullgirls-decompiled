using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	public class ErrorContext
	{
		internal bool Traced
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

		public Exception Error
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private object OriginalObject
		{
			[CompilerGenerated]
			set
			{
			}
		}

		private object Member
		{
			[CompilerGenerated]
			set
			{
			}
		}

		private string Path
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public bool Handled
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		internal ErrorContext(object originalObject, object member, string path, Exception error)
		{
		}
	}
}
