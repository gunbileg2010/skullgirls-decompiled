using System.Collections;
using UnityEngine;

namespace Crosstales.UI
{
	public class UIHint : MonoBehaviour
	{
		public CanvasGroup Group;

		public float Delay;

		public float FadeTime;

		public bool DestroyWhenFinished;

		public void Start()
		{
		}

		private IEnumerator fadeTo(float aValue, float delay, float aTime, bool destroy)
		{
			return null;
		}
	}
}
