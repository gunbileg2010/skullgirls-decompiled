using System;

namespace UnityEngine.EventSystems
{
	public class SGStandaloneInputModule : PointerInputModule
	{
		[Obsolete]
		public enum InputMode
		{
			Mouse = 0,
			Buttons = 1
		}

		private float m_PrevActionTime;

		private Vector2 m_LastMoveVector;

		private int m_ConsecutiveMoveCount;

		private Vector2 m_LastMousePosition;

		private Vector2 m_MousePosition;

		private int frameClickCount;

		[SerializeField]
		private string m_HorizontalAxis;

		[SerializeField]
		private string m_VerticalAxis;

		[SerializeField]
		private string m_SubmitButton;

		[SerializeField]
		private string m_CancelButton;

		[SerializeField]
		private float m_InputActionsPerSecond;

		[SerializeField]
		private float m_RepeatDelay;

		[SerializeField]
		private bool m_ForceModuleActive;

		[Obsolete]
		public InputMode inputMode => default(InputMode);

		[Obsolete]
		public bool allowActivationOnMobileDevice
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool forceModuleActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float inputActionsPerSecond
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float repeatDelay
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public string horizontalAxis
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string verticalAxis
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string submitButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string cancelButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected SGStandaloneInputModule()
		{
		}

		public override void UpdateModule()
		{
		}

		public override bool IsModuleSupported()
		{
			return false;
		}

		public override bool ShouldActivateModule()
		{
			return false;
		}

		public override void ActivateModule()
		{
		}

		public override void DeactivateModule()
		{
		}

		public override void Process()
		{
		}

		private bool ProcessTouchEvents()
		{
			return false;
		}

		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
		}

		protected bool SendSubmitEventToSelectedObject()
		{
			return false;
		}

		private Vector2 GetRawMoveVector()
		{
			return default(Vector2);
		}

		protected bool SendMoveEventToSelectedObject()
		{
			return false;
		}

		protected void ProcessMouseEvent()
		{
		}

		protected void ProcessMouseEvent(int id)
		{
		}

		protected bool SendUpdateEventToSelectedObject()
		{
			return false;
		}

		protected void ProcessMousePress(MouseButtonEventData data)
		{
		}
	}
}
