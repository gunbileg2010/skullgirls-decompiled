using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragReel : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	[SerializeField]
	private Transform startTransform;

	[SerializeField]
	private Transform targetTransform;

	[SerializeField]
	private DragTutorial dragTutorial;

	[SerializeField]
	private float targetRadius;

	[SerializeField]
	private float startScale;

	[SerializeField]
	private float targetScale;

	[SerializeField]
	protected EZAnimation.EASING_TYPE releaseInterpolator;

	private CanvasGroup canvasGroup;

	private bool droppedOnTarget;

	private Transform reelTransform;

	private float mostRecentDragFactor;

	private AnimatePosition reelAnimatePosition;

	private bool tutorialMode;

	public bool dragging
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
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

	public void Reset(bool isTutorialActive = false)
	{
	}

	public bool WasDroppedOnTarget()
	{
		return false;
	}

	public float GetMostRecentDragFactor()
	{
		return 0f;
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

	public void StopDrag()
	{
	}

	public void SetGachaTransform(Transform reelTransform)
	{
	}

	private Vector3 GetWorldPositionOfDrag(PointerEventData eventData)
	{
		return default(Vector3);
	}
}
