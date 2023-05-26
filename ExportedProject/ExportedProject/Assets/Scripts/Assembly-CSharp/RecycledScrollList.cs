using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecycledScrollList : MonoBehaviour
{
	public enum TransformOrdering : byte
	{
		None = 0,
		EarlierBelowLater = 1,
		EarlierAboveLater = 2
	}

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private RectTransform viewport;

	[SerializeField]
	private float additionalViewportBuffer;

	[SerializeField]
	private RectTransform itemParent;

	[SerializeField]
	private LayoutGroup referenceLayoutGroup;

	[SerializeField]
	private int rowOrColumnConstraint;

	[SerializeField]
	private RectOffset padding;

	[SerializeField]
	private Vector2 itemSize;

	[SerializeField]
	private Vector2 itemSpacing;

	[SerializeField]
	private TransformOrdering transformOrdering;

	private Func<int, RectTransform> addCallback;

	private Action<RectTransform> removeCallback;

	private RectTransform.Axis scrollDirection;

	private int itemCount;

	private int nextFrontIndex;

	private int nextEndIndex;

	private List<RectTransform> items;

	private float savedPosition;

	private Vector3[] viewportRectCorners;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public void Populate(int itemCount, Func<int, RectTransform> addCallback, Action<RectTransform> removeCallback)
	{
	}

	public void PopulateOrRefresh(int itemCount, Func<int, RectTransform> addCallback, Action<RectTransform> removeCallback)
	{
	}

	public void Clear()
	{
	}

	public void ClearAndReset()
	{
	}

	public void Repopulate(int updatedItemCount = -1)
	{
	}

	public bool IsInitialized()
	{
		return false;
	}

	public void SavePosition()
	{
	}

	public void RestorePosition()
	{
	}

	public void SetItemCount(int itemCount)
	{
	}

	public void SetItemSize(Vector2 itemSize)
	{
	}

	public Vector2 GetItemSize()
	{
		return default(Vector2);
	}

	public void SetItemSpacing(Vector2 itemSpacing)
	{
	}

	public Vector2 GetItemSpacing()
	{
		return default(Vector2);
	}

	public void RefreshVisibleCards(int updatedItemCount = -1)
	{
	}

	public void SetNormalizedPosition(float position)
	{
	}

	public void SetOffset(int offset, bool changeScrollPos)
	{
	}

	public void Swap(RectTransform itemToRemove, RectTransform itemToInsert)
	{
	}

	public void Remove(RectTransform itemToRemove)
	{
	}

	public void Add(RectTransform itemToAdd)
	{
	}

	public void RefreshLayoutConstraints()
	{
	}

	public ScrollRect GetScrollRect()
	{
		return null;
	}

	public RectTransform GetItemParent()
	{
		return null;
	}

	private void RemoveAllItems()
	{
	}

	private void RefreshContentSize()
	{
	}

	private RectTransform AddItemForIndex(int index)
	{
		return null;
	}

	private void AddItemToFront()
	{
	}

	private void AddItemToEnd()
	{
	}

	private void RemoveItemFromFront()
	{
	}

	private void RemoveItemFromEnd()
	{
	}

	private int GetCurrentFrontIndex()
	{
		return 0;
	}

	private int GetCurrentEndIndex()
	{
		return 0;
	}

	private Rect GetViewportRect()
	{
		return default(Rect);
	}

	private bool IsPositionOutsideRect(Vector3 pos, Rect rect)
	{
		return false;
	}

	private Vector3 GetPositionForItem(int index, bool max)
	{
		return default(Vector3);
	}
}
