using System;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class CustomEventArgs : EventArgs
	{
		public string Message
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

		public RequestState PubNubRequestState
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

		public bool IsError
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

		public bool IsTimeout
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

		public PNCurrentRequestType CurrRequestType
		{
			[CompilerGenerated]
			get
			{
				return default(PNCurrentRequestType);
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
