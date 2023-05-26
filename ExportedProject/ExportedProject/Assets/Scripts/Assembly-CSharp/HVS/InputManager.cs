using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace HVS
{
	public class InputManager : MonoBehaviour
	{
		[SerializeField]
		private int maxSimultaneousTouches;

		[SerializeField]
		private float maxTapTime;

		[SerializeField]
		private float maxTapInches;

		[SerializeField]
		private float maxTapNormalized;

		[SerializeField]
		private float swipeMagnitudeInches;

		[SerializeField]
		private float swipeMagnitudeNormalized;

		private const int kMaxMouseButtons = 3;

		private TouchInfo[] touchStates;

		public event Action<TouchInfo> TouchEvent
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

		public event Action<TouchInfo> TapEvent
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

		public event Action<TouchInfo> SwipeEvent
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

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public int GetTouchCount()
		{
			return 0;
		}

		public TouchInfo GetTouch(int index)
		{
			return null;
		}

		public bool IsPointerOverUI(int pointerId)
		{
			return false;
		}

		public void RecalculateSwipeMagnitudes(Resolution targetResolution)
		{
		}

		private void TouchUpdate()
		{
		}

		private void MouseUpdate()
		{
		}

		private void SendInputEvent(Vector2 screenPos, TouchPhase inputPhase, int id)
		{
		}

		private float InchesToPixels(float inches)
		{
			return 0f;
		}

		private float NormalizedToPixels(float normalized)
		{
			return 0f;
		}

		private void CalculateCurrentSwipeMagnitudes(Resolution targetResolution, out float maxTapMagnitudePixels, out float swipeMagnitudePixels)
		{
			maxTapMagnitudePixels = default(float);
			swipeMagnitudePixels = default(float);
		}
	}
}
