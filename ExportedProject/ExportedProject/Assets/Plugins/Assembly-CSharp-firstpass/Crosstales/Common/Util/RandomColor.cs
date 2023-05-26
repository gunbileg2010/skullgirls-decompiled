using UnityEngine;

namespace Crosstales.Common.Util
{
	public class RandomColor : MonoBehaviour
	{
		public Vector2 ChangeInterval;

		public float Saturation;

		public float Value;

		public float Opacity;

		public bool ChangeMaterial;

		public Material Material;

		public Vector2 ColorRange;

		public bool GrayScale;

		private float elapsedTime;

		private float changeTime;

		private Renderer currentRenderer;

		private Color32 startColor;

		private Color32 endColor;

		private float lerpProgress;

		public void Start()
		{
		}

		public void Update()
		{
		}
	}
}
