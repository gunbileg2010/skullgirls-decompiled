using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prime31
{
	public class LifecycleHelper : MonoBehaviour
	{
		public event Action<bool> onApplicationPausedEvent
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

		private void OnApplicationPause(bool paused)
		{
		}
	}
}
