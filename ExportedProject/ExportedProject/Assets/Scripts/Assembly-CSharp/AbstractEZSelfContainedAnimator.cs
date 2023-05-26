using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class AbstractEZSelfContainedAnimator : MonoBehaviour
{
	[SerializeField]
	protected bool playOnEnable;

	[SerializeField]
	protected bool loop;

	[SerializeField]
	protected float duration;

	[SerializeField]
	protected float delay;

	[SerializeField]
	protected EZAnimation.EASING_TYPE interpolator;

	[SerializeField]
	protected EZAnimation.ANIM_MODE animationMode;

	protected EZAnimation currentAnimation;

	public bool isPlaying
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public event Action<EZAnimation> startedAnimation
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

	public event Action<EZAnimation> updatedAnimation
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

	public event Action<EZAnimation> stoppedAnimation
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

	protected virtual void Awake()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	public void PlayAnimation()
	{
	}

	public void PlayAnimation(bool rewind)
	{
	}

	public void StopAnimation()
	{
	}

	public void ResetAnimation()
	{
	}

	public void ResetAnimation(bool playImmediately)
	{
	}

	public void AddOnStartListener(Action callback)
	{
	}

	public void AddOnStopListener(Action callback)
	{
	}

	public void SetDuration(float duration)
	{
	}

	protected float GetDuration()
	{
		return 0f;
	}

	protected EZAnimation.Interpolator GetInterpolator()
	{
		return null;
	}

	protected void OnStart(EZAnimation animation)
	{
	}

	protected void OnStep(EZAnimation animation)
	{
	}

	protected void OnStop(EZAnimation animation)
	{
	}

	protected abstract EZAnimation GetAnimation();

	protected abstract void Reset();
}
