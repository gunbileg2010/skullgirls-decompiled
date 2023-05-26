using System;
using UnityEngine;

public class Transitions : MonoSingleton<Transitions>
{
	public const float kDefaultDuration = 0.65f;

	public const float kDefaultFadeDuration = 0.5f;

	[SerializeField]
	private CanvasBubbler canvasBubbler;

	[SerializeField]
	private CurtainTransition curtainTransition;

	[SerializeField]
	private FadeTransition fadeTransition;

	private CanvasGroup canvasGroup;

	private Transition activeTransition;

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public Coroutine TransitionOut(TransType transType = TransType.Default, float duration = 0.65f, Action callback = null)
	{
		return null;
	}

	public Coroutine TransitionIn(TransType transType = TransType.Default, float duration = 0.65f, Action callback = null)
	{
		return null;
	}

	public bool IsTransitioning()
	{
		return false;
	}

	private void RefreshBlockRaycasts(Transition transition)
	{
	}

	public Transitions()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
