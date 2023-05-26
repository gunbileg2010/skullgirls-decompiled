using System;
using UnityEngine;

public class AspectRatioCanvasScaler : MonoBehaviour
{
	[Serializable]
	public struct Setting
	{
		public float aspect;

		public float matchWidthOrHeight;
	}

	[SerializeField]
	private Setting[] settings;

	private void Awake()
	{
	}

	private float GetLandscapeScreenAspectRatio()
	{
		return 0f;
	}
}
