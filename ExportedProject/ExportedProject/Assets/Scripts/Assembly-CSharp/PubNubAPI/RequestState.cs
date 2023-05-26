using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class RequestState
	{
		internal long StartRequestTicks;

		internal long EndRequestTicks;

		public PNOperationType OperationType
		{
			[CompilerGenerated]
			get
			{
				return default(PNOperationType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public long ResponseCode
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string URL
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

		public string WebRequestId
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

		public HTTPMethod httpMethod
		{
			[CompilerGenerated]
			get
			{
				return default(HTTPMethod);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string POSTData
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

		public int Timeout
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int Pause
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool Reconnect
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
	}
}
