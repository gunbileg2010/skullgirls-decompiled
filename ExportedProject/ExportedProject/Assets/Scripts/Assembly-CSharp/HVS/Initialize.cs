using UnityEngine;

namespace HVS
{
	public class Initialize : MonoBehaviour
	{
		private static bool isInitialized;

		private void Awake()
		{
		}

		public static bool IsInitialized()
		{
			return false;
		}

		public virtual void Init()
		{
		}

		protected T FindOrCreateMonoManager<T>() where T : Component
		{
			return null;
		}
	}
}
