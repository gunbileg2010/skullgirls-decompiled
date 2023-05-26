using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class PNStatus
	{
		public PNStatusCategory Category
		{
			[CompilerGenerated]
			get
			{
				return default(PNStatusCategory);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public PNErrorData ErrorData
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

		public bool Error
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

		public long StatusCode
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

		public PNOperationType Operation
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

		public bool TlsEnabled
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

		public string UUID
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

		public string AuthKey
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

		public string Origin
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

		public object ClientRequest
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

		public List<string> AffectedChannels
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

		public List<string> AffectedChannelGroups
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

		public PNStatus()
		{
		}

		public PNStatus(PNStatusCategory category, PNErrorData errorData, bool error, long statusCode, PNOperationType operation, bool tlsEnabled, string uuid, string authKey, string origin, List<string> affectedChannels, List<string> affectedChannelGroups, object clientRequest)
		{
		}
	}
}
