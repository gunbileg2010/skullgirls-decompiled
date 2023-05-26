using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragCard : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IDropHandler
{
	public Action DragBegan;

	public Action DragEnded;

	public Action<DragCard> CardDroppedOn;

	private Transform savedParent;

	private Transform dragParent;

	private CanvasGroup canvasGroup;

	private bool dragging;

	private int pointerId;

	protected Vector3 startDragPosition;

	protected Vector3 dragOffset;

	protected virtual void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public void SetDragParent(Transform parent)
	{
	}

	public void SetSavedParent(Transform parent)
	{
	}

	public Transform GetSavedParent()
	{
		return null;
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	public void OnDrop(PointerEventData eventData)
	{
	}

	public void ForceDrop()
	{
	}

	protected virtual void OnBeginDragInternal(PointerEventData eventData)
	{
	}

	protected virtual void OnDragInternal(PointerEventData eventData)
	{
	}

	protected virtual void OnEndDragInternal(PointerEventData eventData)
	{
	}

	protected virtual void OnDropInternal(PointerEventData eventData)
	{
	}

	protected static void SwapParents(DragCard card1, DragCard card2)
	{
	}

	protected void Unparent()
	{
	}

	protected void Reparent()
	{
	}
}
