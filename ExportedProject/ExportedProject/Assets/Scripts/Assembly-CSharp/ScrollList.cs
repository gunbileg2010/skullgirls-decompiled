using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollList : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
{
	[SerializeField]
	private float snapUnderScrollSpeed;

	[SerializeField]
	private float snapSpeed;

	[SerializeField]
	private float edgeSnapBuffer;

	[SerializeField]
	private float focusedDistance;

	[SerializeField]
	private bool updateItemScaleContinuously;

	[SerializeField]
	private float updateItemScaleDistance;

	[SerializeField]
	private bool tapToFocus;

	private ScrollRect _scrollRect;

	private int focusedIndex;

	private List<ScrollListItem> items;

	private List<Vector3> positions;

	private bool isLerping;

	private Vector3 lerpTarget;

	private bool dragging;

	private bool waitForScrollSlowdown;

	private Vector3 originalContentPosition;

	public GameObject Pagination;

	[HideInInspector]
	public GameObject NextButton;

	[HideInInspector]
	public GameObject PrevButton;

	[HideInInspector]
	public bool UseFastSwipe;

	[HideInInspector]
	public int FastSwipeThreshold;

	public ScrollRect ScrollRect => null;

	public int Count => 0;

	public event Action<ScrollListItem> ItemWillBeFocused
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

	public event Action<ScrollListItem> ItemFocused
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

	public event Action<ScrollListItem> ItemUnfocused
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

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Rebuild()
	{
	}

	public void PositionAt(int index, bool immediate)
	{
	}

	public bool NextScreen()
	{
		return false;
	}

	public bool PreviousScreen()
	{
		return false;
	}

	public ScrollListItem GetFocusedItem()
	{
		return null;
	}

	public int GetFocusedIndex()
	{
		return 0;
	}

	public void SetTapToFocus(bool allowed)
	{
	}

	public int GetIndexOf(ScrollListItem item)
	{
		return 0;
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

	private int GetNearestIndex()
	{
		return 0;
	}

	private int FindClosestIndex(Vector3 pos)
	{
		return 0;
	}

	private void NextScreenCommand()
	{
	}

	private void PrevScreenCommand()
	{
	}

	private void ChangeBulletsInfo(int index)
	{
	}

	private void OnItemClicked(ScrollListItem item)
	{
	}
}
