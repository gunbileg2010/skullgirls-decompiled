using System;

public class EZAnimateFloat : EZAnimation
{
	private float startVal;

	private float delta;

	private float endVal;

	private Action<float> updateDelegate;

	public static EZAnimateFloat Do(float begin, float dest, ref EZAnimOptions options, Action<EZAnimation> startDel, Action<float> updateDel, Action<EZAnimation> stopDel)
	{
		return null;
	}

	public static EZAnimateFloat Do(float begin, float dest, Interpolator interp, float dur, float delay, Action<EZAnimation> startDel, Action<float> updateDel, Action<EZAnimation> stopDel)
	{
		return null;
	}

	public void Start(float begin, float dest, Interpolator interp, float dur, float delay, Action<EZAnimation> startDel, Action<float> updateDel, Action<EZAnimation> stopDel)
	{
	}

	public void Start()
	{
	}

	public override object GetSubject()
	{
		return null;
	}

	public override void SetToStartState()
	{
	}

	public override void EndInternal()
	{
	}

	protected override void DoAnim()
	{
	}
}
