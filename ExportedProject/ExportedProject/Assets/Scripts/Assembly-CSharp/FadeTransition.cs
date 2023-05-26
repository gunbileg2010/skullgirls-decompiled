using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeTransition : Transition
{
	private Image faderImage;

	private bool transitioningOut;

	private Coroutine faderCoroutine;

	private void Awake()
	{
	}

	public override Coroutine TransitionOut(float duration, Action callback)
	{
		return null;
	}

	public override Coroutine TransitionIn(float duration, Action callback)
	{
		return null;
	}

	public override void SetT(float t)
	{
	}

	public override float GetT()
	{
		return 0f;
	}

	public override bool IsTransitioning()
	{
		return false;
	}

	public override bool IsTransitioningOut()
	{
		return false;
	}

	private void SetFade(float alpha)
	{
	}

	private IEnumerator DoFade(float duration, float toAlpha, Action callback)
	{
		return null;
	}
}
