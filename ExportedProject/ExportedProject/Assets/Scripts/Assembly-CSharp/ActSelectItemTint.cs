using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ActSelectItemTint : MonoBehaviour
{
	[SerializeField]
	private Image overlay;

	[SerializeField]
	private Image frame;

	[SerializeField]
	private Color focusedFrameColor;

	[SerializeField]
	private Color unfocusedFrameColor;

	[SerializeField]
	private Color overlayColor;

	[SerializeField]
	private Color disabledFrameColor;

	[SerializeField]
	private Color disabledOverlayColor;

	private ScrollListItem scrollListItem;

	private Coroutine runningCoroutine;

	private bool disabled;

	private bool isFocused;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetDisabled(bool disabled)
	{
	}

	private IEnumerator SetFocusedState(bool focused, float duration)
	{
		return null;
	}

	private void AnimateFocusedState(bool focused, float duration)
	{
	}

	private void OnWillBeFocused(ScrollListItem item)
	{
	}

	private void OnFocused(ScrollListItem item)
	{
	}

	private void OnUnfocused(ScrollListItem item)
	{
	}
}
