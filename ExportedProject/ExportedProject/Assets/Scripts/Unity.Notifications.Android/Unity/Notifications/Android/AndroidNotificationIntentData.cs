using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Notifications.Android
{
	public class AndroidNotificationIntentData
	{
		public AndroidNotification Notification
		{
			[CompilerGenerated]
			get
			{
				return default(AndroidNotification);
			}
		}

		internal AndroidJavaObject NativeNotification
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public AndroidNotificationIntentData(int id, string channelId, AndroidNotification notification)
		{
		}
	}
}
