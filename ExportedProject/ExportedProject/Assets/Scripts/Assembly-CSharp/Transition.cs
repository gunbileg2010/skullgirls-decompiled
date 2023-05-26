using System;
using UnityEngine;

public abstract class Transition : MonoBehaviour
{
	public const float kMaxTransitionDeltaTime = 0.05f;

	protected Action<float, bool> blockRaycastsCallback;

	public virtual void Init(Action<float, bool> blockRaycastsCallback)
	{
	}

	public abstract Coroutine TransitionOut(float duration, Action callback);

	public abstract Coroutine TransitionIn(float duration, Action callback);

	public abstract void SetT(float t);

	public abstract float GetT();

	public abstract bool IsTransitioning();

	public abstract bool IsTransitioningOut();
}
