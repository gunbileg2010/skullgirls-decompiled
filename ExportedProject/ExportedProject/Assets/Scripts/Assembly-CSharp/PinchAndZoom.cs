using System;
using UnityEngine;
using UnityEngine.UI;

public class PinchAndZoom : MonoBehaviour
{
	public Action<float> ZoomUpdated;

	[SerializeField]
	private float minScale;

	[SerializeField]
	private float initialScale;

	[SerializeField]
	private float maxScale;

	[SerializeField]
	private float maxPinchSize;

	[SerializeField]
	private float zoomTilt;

	[SerializeField]
	private bool applyTilt;

	private Transform cachedTransform;

	private Vector3 targetScale;

	private ScrollRect scrollRect;

	private float startPinchSize;

	private float startScale;

	private float startScaleNormalized;

	private Vector2 centerPinch;

	private bool pinching;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void ResetZoom()
	{
	}

	public float GetZoomLevel()
	{
		return 0f;
	}

	public float GetInitialScale()
	{
		return 0f;
	}

	private void OnDrawGizmos()
	{
	}

	private void Zoom(float pinch)
	{
	}
}
