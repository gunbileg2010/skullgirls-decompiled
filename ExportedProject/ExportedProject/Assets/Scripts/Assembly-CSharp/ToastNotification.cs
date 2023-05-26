using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ToastNotification : MonoBehaviour
{
	public enum State
	{
		Showing = 0,
		Visible = 1,
		Hiding = 2,
		Hidden = 3
	}

	[SerializeField]
	private float showDuration;

	[SerializeField]
	private float visibleDuration;

	[SerializeField]
	private float hideDuration;

	[SerializeField]
	private VerticalLayoutGroup swipingGroup;

	[SerializeField]
	private GraphicPulse pulsingGlow;

	[SerializeField]
	private LocalizedUGUIText titleText;

	[SerializeField]
	private LocalizedUGUIText messageText;

	[SerializeField]
	private Button toastButton;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Sprite defaultIcon;

	[SerializeField]
	private GameObject achievementIcon;

	private State state;

	private UnityAction callback;

	private Coroutine showHideCoroutine;

	private Rect Rect => default(Rect);

	public void Reset()
	{
	}

	public void Show(ToastManager.ToastData toastData)
	{
	}

	public State GetState()
	{
		return default(State);
	}

	public void UGUI_InvokeCallback()
	{
	}

	private IEnumerator DoShowHide(float durationVisible)
	{
		return null;
	}

	private IEnumerator DoHide()
	{
		return null;
	}
}
