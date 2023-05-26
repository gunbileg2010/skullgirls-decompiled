using UnityEngine;

namespace Unity.Notifications.Android
{
	internal class NotificationCallback : AndroidJavaProxy
	{
		public NotificationCallback()
			: base((string)null)
		{
		}

		public void onSentNotification(AndroidJavaObject notification)
		{
		}
	}
}
