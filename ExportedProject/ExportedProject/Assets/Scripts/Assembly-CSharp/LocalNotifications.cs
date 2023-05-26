using System;
using Unity.Notifications.Android;

public static class LocalNotifications
{
	private static class Android
	{
		private const string kChannelId = "local-notifications";

		public static void Init()
		{
		}

		public static int Schedule(string title, string message, DateTime utcDateTime, int badgeNumber, string notificationType)
		{
			return 0;
		}

		public static void Cancel(int id)
		{
		}

		public static void CancelAll()
		{
		}

		public static void Clear(int id)
		{
		}

		public static void ClearAll()
		{
		}

		public static AndroidNotificationChannel GetChannel()
		{
			return default(AndroidNotificationChannel);
		}

		public static bool Allowed()
		{
			return false;
		}

		public static string GetLaunchNotificationType()
		{
			return null;
		}
	}

	public static void Init()
	{
	}

	public static void Schedule(string title, string message, DateTime utcDateTime, int badgeNumber, string notificationType)
	{
	}

	public static void CancelAll()
	{
	}

	public static void ClearAll()
	{
	}

	public static bool Allowed()
	{
		return false;
	}

	public static string GetLaunchNotificationType()
	{
		return null;
	}
}
