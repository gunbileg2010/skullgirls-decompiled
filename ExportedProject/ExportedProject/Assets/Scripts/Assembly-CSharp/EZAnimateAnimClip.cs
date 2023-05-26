using System;
using UnityEngine;

public class EZAnimateAnimClip : EZAnimation
{
	private GameObject subject;

	private AnimationClip clip;

	public static EZAnimateAnimClip Do(GameObject sub, AnimationClip clip, ref EZAnimOptions options, Action<EZAnimation> startDel, Action<EZAnimation> stopDel)
	{
		return null;
	}

	public static EZAnimateAnimClip Do(GameObject sub, AnimationClip clip, Interpolator interp, float dur, float delay, Action<EZAnimation> startDel, Action<EZAnimation> stopDel)
	{
		return null;
	}

	public void Start(GameObject sub, AnimationClip clip, Interpolator interp, float dur, float delay, Action<EZAnimation> startDel, Action<EZAnimation> stopDel)
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
