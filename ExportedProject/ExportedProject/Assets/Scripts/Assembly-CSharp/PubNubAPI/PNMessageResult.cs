using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class PNMessageResult
	{
		public object Payload
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

		public string Subscription
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

		public string Channel
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

		public long Timetoken
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

		public long OriginatingTimetoken
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

		public object UserMetadata
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

		public string IssuingClientId
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

		public PNMessageResult(string subscribedChannel, string actualchannel, object payload, long timetoken, long originatingTimetoken, object userMetadata, string issuingClientId)
		{
		}
	}
}
