using System;
using System.Runtime.CompilerServices;

namespace PubNubAPI
{
	public class PNConfiguration
	{
		private ushort concurrentNonSubscribeWorkers;

		private string uuid;

		private int messageQueueOverflowCount;

		private int subscribeTimeout;

		private int nonSubscribeTimeout;

		private string filterExpr;

		private PNHeartbeatNotificationOption heartbeatNotificationOption;

		private string origin;

		private PNReconnectionPolicy reconnectionPolicy;

		private int maximumReconnectionRetries;

		private bool suppressLeaveEvents;

		public ushort ConcurrentNonSubscribeWorkers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string SubscribeKey
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

		public string PublishKey
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

		public string SecretKey
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

		public string CipherKey
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

		public string UUID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PNLogVerbosity LogVerbosity
		{
			[CompilerGenerated]
			get
			{
				return default(PNLogVerbosity);
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

		public bool Secure
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

		public int MessageQueueOverflowCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int SubscribeTimeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int NonSubscribeTimeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string FilterExpression
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PNHeartbeatNotificationOption HeartbeatNotificationOption
		{
			get
			{
				return default(PNHeartbeatNotificationOption);
			}
			set
			{
			}
		}

		public string Origin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PNReconnectionPolicy ReconnectionPolicy
		{
			get
			{
				return default(PNReconnectionPolicy);
			}
			set
			{
			}
		}

		public int PresenceTimeout
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

		public int PresenceInterval
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

		public int MaximumReconnectionRetries
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool SuppressLeaveEvents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event EventHandler<EventArgs> UUIDChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<EventArgs> FilterExpressionChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}
	}
}
