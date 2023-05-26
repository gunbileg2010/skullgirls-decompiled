using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class UITouchAndHoldButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler, IEndDragHandler
{
	public enum ExecutionOrder
	{
		OnPress = 0,
		OnEnter = 1,
		OnTap = 2
	}

	public bool interactable;

	[SerializeField]
	private ExecutionOrder execution;

	[SerializeField]
	private float delayInSeconds;

	[SerializeField]
	private float scrollThreshold;

	[SerializeField]
	private UnityEvent onBecomeActive;

	[SerializeField]
	private UnityEvent onBecameInactive;

	[SerializeField]
	private UnityEvent onTapEvent;

	private Coroutine countdown;

	private bool canClick;

	public event Action becameActiveEvent
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

	public event Action becameInactiveEvent
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

	public event Action tapEventDetected
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

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	private bool IsDragging(PointerEventData eventData)
	{
		return false;
	}

	private void RunActivationSequence()
	{
	}

	private void RunDeactivationSequence()
	{
	}

	private void Activate()
	{
	}

	private void Deactivate()
	{
	}

	private IEnumerator Countdown(float delayInSeconds)
	{
		return null;
	}
}
