using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Notifications.Android
{
	public class AndroidNotificationCenter
	{
		public delegate void NotificationReceivedCallback(AndroidNotificationIntentData data);

		[CompilerGenerated]
		private static NotificationReceivedCallback OnNotificationReceived;

		private static AndroidJavaClass s_NotificationManagerClass;

		private static AndroidJavaObject s_NotificationManager;

		private static AndroidJavaObject s_CurrentActivity;

		private static bool s_Initialized;

		private static AndroidJavaObject Notification_EXTRA_TITLE;

		private static AndroidJavaObject Notification_EXTRA_TEXT;

		private static AndroidJavaObject Notification_EXTRA_SHOW_CHRONOMETER;

		private static AndroidJavaObject Notification_EXTRA_BIG_TEXT;

		private static AndroidJavaObject Notification_EXTRA_SHOW_WHEN;

		private static int Notification_FLAG_AUTO_CANCEL;

		private static int Notification_FLAG_GROUP_SUMMARY;

		private static AndroidJavaObject KEY_FIRE_TIME;

		private static AndroidJavaObject KEY_ID;

		private static AndroidJavaObject KEY_INTENT_DATA;

		private static AndroidJavaObject KEY_LARGE_ICON;

		private static AndroidJavaObject KEY_REPEAT_INTERVAL;

		private static AndroidJavaObject KEY_NOTIFICATION;

		private static AndroidJavaObject KEY_SMALL_ICON;

		public static bool Initialize()
		{
			return false;
		}

		public static void RegisterNotificationChannel(AndroidNotificationChannel channel)
		{
		}

		public static AndroidNotificationChannel GetNotificationChannel(string channelId)
		{
			return default(AndroidNotificationChannel);
		}

		public static AndroidNotificationChannel[] GetNotificationChannels()
		{
			return null;
		}

		public static int SendNotification(AndroidNotification notification, string channelId)
		{
			return 0;
		}

		public static void SendNotification(AndroidJavaObject notificationBuilder)
		{
		}

		public static void CancelScheduledNotification(int id)
		{
		}

		public static void CancelDisplayedNotification(int id)
		{
		}

		public static void CancelAllScheduledNotifications()
		{
		}

		public static void CancelAllDisplayedNotifications()
		{
		}

		public static AndroidNotificationIntentData GetLastNotificationIntent()
		{
			return null;
		}

		public static AndroidJavaObject CreateNotificationBuilder(int id, AndroidNotification notification, string channelId)
		{
			return null;
		}

		internal static AndroidNotificationIntentData GetNotificationData(AndroidJavaObject notificationObj)
		{
			return null;
		}

		internal static void ReceivedNotificationCallback(AndroidJavaObject notification)
		{
		}
	}
}
