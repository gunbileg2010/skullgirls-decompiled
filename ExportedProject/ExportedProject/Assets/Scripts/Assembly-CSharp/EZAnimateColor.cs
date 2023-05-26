using System;
using UnityEngine;

public class EZAnimateColor : EZAnimation
{
	private Color startVal;

	private Color delta;

	private Color endVal;

	private Action<Color> updateDelegate;

	public static EZAnimateColor Do(Color begin, Color dest, Interpolator interp, float dur, float delay, Action<EZAnimation> startDel, Action<Color> updateDel, Action<EZAnimation> stopDel)
	{
		return null;
	}

	public void Start(Color begin, Color dest, Interpolator interp, float dur, float delay, Action<EZAnimation> startDel, Action<Color> updateDel, Action<EZAnimation> stopDel)
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
