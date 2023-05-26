using System;
using System.Collections;
using UnityEngine;

public class CurtainTransition : Transition
{
	private UICurtain curtain;

	private bool transitioningOut;

	private Coroutine curtainCoroutine;

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

	public void SetDirection(UICurtain.Direction direction)
	{
	}

	private IEnumerator DoCurtain(UICurtain curtain, float duration, float toT, Action callback)
	{
		return null;
	}
}
