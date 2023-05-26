using System.Runtime.CompilerServices;

namespace Unity.Notifications.Android
{
	public struct AndroidNotificationChannel
	{
		public string Id
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

		public string Name
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

		public string Description
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

		public Importance Importance
		{
			[CompilerGenerated]
			readonly get
			{
				return default(Importance);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool CanBypassDnd
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

		public bool CanShowBadge
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

		public bool EnableLights
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

		public bool EnableVibration
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

		public long[] VibrationPattern
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

		public LockScreenVisibility LockScreenVisibility
		{
			[CompilerGenerated]
			readonly get
			{
				return default(LockScreenVisibility);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool Enabled => false;
	}
}
