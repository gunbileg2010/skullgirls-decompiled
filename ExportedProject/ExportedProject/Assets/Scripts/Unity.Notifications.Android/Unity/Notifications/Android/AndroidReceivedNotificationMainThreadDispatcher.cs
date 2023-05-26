using System.Collections.Generic;
using UnityEngine;

namespace Unity.Notifications.Android
{
	public class AndroidReceivedNotificationMainThreadDispatcher : MonoBehaviour
	{
		private static AndroidReceivedNotificationMainThreadDispatcher instance;

		private List<AndroidJavaObject> m_ReceivedNotificationQueue;

		private List<AndroidJavaObject> m_ReceivedNotificationList;

		internal void EnqueueReceivedNotification(AndroidJavaObject notification)
		{
		}

		internal static AndroidReceivedNotificationMainThreadDispatcher GetInstance()
		{
			return null;
		}

		public void Update()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
