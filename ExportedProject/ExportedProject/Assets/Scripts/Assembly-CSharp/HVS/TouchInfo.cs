using UnityEngine;

namespace HVS
{
	public class TouchInfo
	{
		private int id;

		private TouchPhase touchPhase;

		private Vector2 beginScreenPosition;

		private Vector2 lastScreenPosition;

		private Vector2 screenPositionDelta;

		private float beginTime;

		private float lastTime;

		private float maxTapTime;

		private float maxTapMagnitudeSq;

		private float swipeMagnitudeSq;

		private bool startedSwipe;

		private Vector2 swipeBeginScreenPosition;

		private Vector2 lastSwipeDirection;

		private bool beganOverUi;

		private bool isOverUi;

		public int Id => 0;

		public TouchPhase TouchPhase => default(TouchPhase);

		public Vector2 BeginScreenPosition => default(Vector2);

		public Vector2 LastScreenPosition => default(Vector2);

		public Vector2 ScreenPositionDelta => default(Vector2);

		public TouchInfo(int touchId, float maxTapTime, float maxTapDistance, float swipeMagnitudePixels)
		{
		}

		public void BeginTouch(Vector2 screenPosition, bool isUiTouch)
		{
		}

		public void MoveTouch(Vector2 screenPosition)
		{
		}

		public void StationaryTouch(Vector2 screenPosition)
		{
		}

		public void EndTouch(Vector2 screenPosition, bool wasCanceled)
		{
		}

		public bool IsTap()
		{
			return false;
		}

		public bool IsPress()
		{
			return false;
		}

		public bool StartedSwipe()
		{
			return false;
		}

		public Vector2 GetSwipeDirection()
		{
			return default(Vector2);
		}

		public float GetTouchDuration()
		{
			return 0f;
		}

		public float GetTouchLengthSquared(LengthUnits units, float sampleDepth = 0f)
		{
			return 0f;
		}

		public float GetTouchLength(LengthUnits units, float sampleDepth = 0f)
		{
			return 0f;
		}

		public Vector3 GetBeginPosition(LengthUnits units, float sampleDepth = 0f)
		{
			return default(Vector3);
		}

		public Vector3 GetLastPosition(LengthUnits units, float sampleDepth = 0f)
		{
			return default(Vector3);
		}

		public override string ToString()
		{
			return null;
		}

		public void ResetSwipe()
		{
		}

		public bool DidBeginOverUI()
		{
			return false;
		}

		public void SetIsOverUI(bool overUI)
		{
		}

		public bool IsOverUI()
		{
			return false;
		}

		public void UpdateSwipeThresholds(float maxTapMagnitudePixels, float swipeMagnitudePixels)
		{
		}

		private void CommonUpdate()
		{
		}

		private Vector3 ConvertPoint(Vector3 pixelValue, LengthUnits units, float sampleDepth = 0f)
		{
			return default(Vector3);
		}

		private void CheckSwipe(Vector2 currentScreenPosition)
		{
		}
	}
}
