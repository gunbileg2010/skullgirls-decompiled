using UnityEngine;

namespace Crosstales.Common.Util
{
	public class RandomScaler : MonoBehaviour
	{
		public Vector3 ScaleMin;

		public Vector3 ScaleMax;

		public bool Uniform;

		public Vector2 ChangeInterval;

		private Transform tf;

		private Vector3 endScale;

		private float elapsedTime;

		private float changeTime;

		private Vector3 startScale;

		private float lerpTime;

		public void Start()
		{
		}

		public void Update()
		{
		}
	}
}
