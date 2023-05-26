using System;
using System.Runtime.CompilerServices;

public abstract class EZAnimation : IEZLinkedListItem<EZAnimation>
{
	public enum ANIM_MODE : byte
	{
		By = 0,
		To = 1,
		FromTo = 2
	}

	public enum EASING_TYPE : byte
	{
		Linear = 0,
		BackIn = 1,
		BackOut = 2,
		BackInOut = 3,
		BackOutIn = 4,
		BounceIn = 5,
		BounceOut = 6,
		BounceInOut = 7,
		BounceOutIn = 8,
		CircularIn = 9,
		CircularOut = 10,
		CircularInOut = 11,
		CircularOutIn = 12,
		CubicIn = 13,
		CubicOut = 14,
		CubicInOut = 15,
		CubicOutIn = 16,
		ElasticIn = 17,
		ElasticOut = 18,
		ElasticInOut = 19,
		ElasticOutIn = 20,
		ExponentialIn = 21,
		ExponentialOut = 22,
		ExponentialInOut = 23,
		ExponentialOutIn = 24,
		QuadraticIn = 25,
		QuadraticOut = 26,
		QuadraticInOut = 27,
		QuadraticOutIn = 28,
		QuarticIn = 29,
		QuarticOut = 30,
		QuarticInOut = 31,
		QuarticOutIn = 32,
		QuinticIn = 33,
		QuinticOut = 34,
		QuinticInOut = 35,
		QuinticOutIn = 36,
		SinusoidalIn = 37,
		SinusoidalOut = 38,
		SinusoidalInOut = 39,
		SinusoidalOutIn = 40,
		Spring = 41
	}

	public delegate float Interpolator(float timeElapsed, float start, float deltaFromStart, float duration);

	public bool loop;

	public bool pingPong;

	public bool delayOnLoop;

	public bool delayOnPingPong;

	public bool restartOnLoop;

	public bool stopOnLevelLoad;

	public bool useRealTimeDelta;

	protected const float PIx2 = (float)Math.PI * 2f;

	protected Action<EZAnimation> startDelegate;

	protected Action<EZAnimation> stopDelegate;

	protected Interpolator interpolator;

	protected float delay;

	protected float duration;

	private bool paused;

	protected sbyte direction;

	protected float remainingDelay;

	protected float timeElapsed;

	protected EZAnimation m_prev;

	protected EZAnimation m_next;

	public bool running
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

	public float Delay => 0f;

	public float Duration => 0f;

	public bool Paused
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public EZAnimation prev
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public EZAnimation next
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void ApplyAnimOptions(ref EZAnimOptions options)
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public abstract object GetSubject();

	public virtual void SetToStartState()
	{
	}

	public void Stop()
	{
	}

	public void End()
	{
	}

	public virtual bool StepInternal(float timeDelta)
	{
		return false;
	}

	public void StartInternal()
	{
	}

	public void StopInternal()
	{
	}

	public virtual void EndInternal()
	{
	}

	public void ClearInternal()
	{
	}

	protected abstract void DoAnim();

	protected virtual void LoopReset()
	{
	}

	protected virtual void OnDelayDone()
	{
	}

	protected void StartCommon()
	{
	}

	public static Interpolator GetInterpolator(EASING_TYPE type)
	{
		return null;
	}

	public static float linear(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float quadraticIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float quadraticOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float quadraticInOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float quadraticOutIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float cubicIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float cubicOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float cubicInOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float cubicOutIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float quarticIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float quarticOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float quarticInOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float quarticOutIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float quinticIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float quinticOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float quinticInOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float quinticOutIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float sinusIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float sinusOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float sinusInOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float sinusOutIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float expIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float expOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float expInOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float expOutIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float circIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float circOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float circInOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float circOutIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float punch(float amplitude, float value)
	{
		return 0f;
	}

	public static float spring(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float elasticIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float elasticIn(float time, float start, float delta, float duration, float amplitude, float period)
	{
		return 0f;
	}

	public static float elasticOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float elasticOut(float time, float start, float delta, float duration, float amplitude, float period)
	{
		return 0f;
	}

	public static float elasticInOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float elasticInOut(float time, float start, float delta, float duration, float amplitude, float period)
	{
		return 0f;
	}

	public static float elasticOutIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float elasticOutIn(float time, float start, float delta, float duration, float amplitude, float period)
	{
		return 0f;
	}

	public static float backIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float backIn(float time, float start, float delta, float duration, float overshootAmt)
	{
		return 0f;
	}

	public static float backOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float backOut(float time, float start, float delta, float duration, float overshootAmt)
	{
		return 0f;
	}

	public static float backInOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float backInOut(float time, float start, float delta, float duration, float overshootAmt)
	{
		return 0f;
	}

	public static float backOutIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float backOutIn(float time, float start, float delta, float duration, float overshootAmt)
	{
		return 0f;
	}

	public static float bounceIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float bounceOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float bounceInOut(float time, float start, float delta, float duration)
	{
		return 0f;
	}

	public static float bounceOutIn(float time, float start, float delta, float duration)
	{
		return 0f;
	}
}
