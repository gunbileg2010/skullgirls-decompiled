using System;
using System.Runtime.CompilerServices;

namespace Bolt.Exceptions
{
	public class BoltException : Exception
	{
		public object ExtraInfo
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected string ExtraInfoLabel
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override string Message => null;

		public BoltException(string msg = "", string label = "Extra Info")
		{
		}
	}
}
