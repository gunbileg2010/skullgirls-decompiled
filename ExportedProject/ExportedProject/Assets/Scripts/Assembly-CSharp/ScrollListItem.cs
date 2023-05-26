using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ScrollListItem : MonoBehaviour
{
	[SerializeField]
	private bool animateScale;

	[SerializeField]
	private Vector3 unfocusedScale;

	[SerializeField]
	private Vector3 focusedScale;

	[SerializeField]
	private float scaleSpeed;

	[SerializeField]
	private Button tapToFocusButton;

	[SerializeField]
	private RectTransform sidebar;

	[SerializeField]
	private Animation sidebarAnimation;

	[SerializeField]
	private float animForwardSpeed;

	[SerializeField]
	private float animReverseSpeed;

	[SerializeField]
	private float sidebarExpandedWidthMultiplier;

	private LayoutElement layoutElement;

	private float originalPreferredWidth;

	private float targetPreferredWidth;

	private Vector2 originalSidebarAnchoredPosition;

	private Vector2 targetSidebarAnchoredPosition;

	private Vector3 targetLocalScale;

	private bool sidebarShown;

	public event Action<ScrollListItem> WillBeFocused
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

	public event Action<ScrollListItem> Focused
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

	public event Action<ScrollListItem> Unfocused
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

	public event Action<ScrollListItem> Clicked
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

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void UpdateScrollScale(float t)
	{
	}

	public void WillGetFocus()
	{
	}

	public void Focus()
	{
	}

	public void Unfocus(bool immediate = false)
	{
	}

	private void ShowSidebar(bool immediate)
	{
	}

	private void HideSidebar(bool immediate)
	{
	}

	private void OnItemClick()
	{
	}
}
