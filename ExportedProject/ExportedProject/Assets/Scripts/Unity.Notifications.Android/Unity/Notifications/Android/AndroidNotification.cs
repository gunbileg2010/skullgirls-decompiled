using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Notifications.Android
{
	public struct AndroidNotification
	{
		private Color m_Color;

		private TimeSpan m_RepeatInterval;

		private DateTime m_CustomTimestamp;

		public string Title
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string Text
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string SmallIcon
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DateTime FireTime
		{
			[CompilerGenerated]
			readonly get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public TimeSpan? RepeatInterval
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string LargeIcon
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public NotificationStyle Style
		{
			[CompilerGenerated]
			readonly get
			{
				return default(NotificationStyle);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Color? Color
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Number
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool ShouldAutoCancel
		{
			[CompilerGenerated]
			readonly get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool UsesStopwatch
		{
			[CompilerGenerated]
			readonly get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string Group
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool GroupSummary
		{
			[CompilerGenerated]
			readonly get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public GroupAlertBehaviours GroupAlertBehaviour
		{
			[CompilerGenerated]
			readonly get
			{
				return default(GroupAlertBehaviours);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string SortKey
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string IntentData
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool ShowTimestamp
		{
			[CompilerGenerated]
			readonly get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DateTime CustomTimestamp
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		internal bool ShowCustomTimestamp
		{
			[CompilerGenerated]
			readonly get
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
