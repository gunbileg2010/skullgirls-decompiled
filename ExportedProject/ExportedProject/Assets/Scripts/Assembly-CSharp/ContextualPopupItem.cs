using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContextualPopupItem : MonoBehaviour
{
	[SerializeField]
	private RectTransform frameGuideTransform;

	[SerializeField]
	private RectTransform frameTransform;

	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private Image frameImage;

	[SerializeField]
	protected GameObject headerGO;

	[SerializeField]
	protected LocalizedUGUIText headerText;

	[SerializeField]
	private LocalizedUGUIText text;

	[SerializeField]
	private TimerUI timerUI;

	[SerializeField]
	private RectTransform contextualImagesParent;

	[SerializeField]
	private CollectibleIcon collectectibleIconPrefab;

	private const float kMoveOnscreenSpeed = 4f;

	private const float kMoveGuideOnscreenSpeed = 50f;

	private CanvasGroup backgroundCanvasGroup;

	private EZAnimation showAnim;

	private float secondsVisible;

	private bool hideOnPress;

	private Action pressedCallback;

	private Action hideCallback;

	private Vector3[] frameWorldCorners;

	private Vector3[] canvasWorldCorners;

	private RectTransform canvasRectTransform;

	private List<CollectibleIcon> collectableIconsSpawnedIn;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void SetMessage(string message, string header = "", float timerSecondsLeft = -1f)
	{
	}

	public void SetCollectableIcons(List<Loot> lootList)
	{
	}

	public void SetWidth(float width)
	{
	}

	public void SetPivot(Vector2 pivot)
	{
	}

	public void SetHideOnPress(bool hideOnPress)
	{
	}

	public void Show(Vector3 position, float secondsVisible = -1f, bool hideOnPress = false, bool showBackground = false, bool clearBackground = false)
	{
	}

	public void Hide(bool hideBackground = true)
	{
	}

	public void SetPressedCallback(Action callback)
	{
	}

	public void SetHideCallback(Action callback)
	{
	}

	public void UGUI_ScreenPressed()
	{
	}

	public void SetFrameTint(Color color)
	{
	}

	private void OnPreStateChanged(string prevState, string newState)
	{
	}
}
