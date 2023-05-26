using UnityEngine;
using UnityEngine.EventSystems;

public class DragObject : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	private CanvasGroup canvasGroup;

	private bool dragging;

	private int pointerId;

	protected Vector3 dragOffset;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
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

	private void OnBeginDragInternal(PointerEventData eventData)
	{
	}

	private void OnDragInternal(PointerEventData eventData)
	{
	}
}
