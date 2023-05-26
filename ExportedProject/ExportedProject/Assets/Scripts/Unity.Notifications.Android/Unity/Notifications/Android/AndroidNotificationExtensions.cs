using System;
using UnityEngine;

namespace Unity.Notifications.Android
{
	internal static class AndroidNotificationExtensions
	{
		public static Importance ToImportance(this int importance)
		{
			return default(Importance);
		}

		public static LockScreenVisibility ToLockScreenVisibility(this int lockscreenVisibility)
		{
			return default(LockScreenVisibility);
		}

		public static GroupAlertBehaviours ToGroupAlertBehaviours(this int groupAlertBehaviour)
		{
			return default(GroupAlertBehaviours);
		}

		public static Color ToColor(this int color)
		{
			return default(Color);
		}

		public static int ToInt(this Color? color)
		{
			return 0;
		}

		public static long ToLong(this DateTime dateTime)
		{
			return 0L;
		}

		public static DateTime ToDatetime(this long dateTime)
		{
			return default(DateTime);
		}

		public static long ToLong(this TimeSpan? timeSpan)
		{
			return 0L;
		}

		public static TimeSpan ToTimeSpan(this long timeSpan)
		{
			return default(TimeSpan);
		}
	}
}
