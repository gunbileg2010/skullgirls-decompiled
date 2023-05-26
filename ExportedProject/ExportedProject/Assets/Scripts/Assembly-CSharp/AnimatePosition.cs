using System;
using UnityEngine;

public class AnimatePosition : EZAnimation
{
	private ANIM_MODE animMode;

	private GameObject subject;

	private Transform subTrans;

	private Vector3 start;

	private Vector3 delta;

	private Vector3 end;

	public static AnimatePosition Do(GameObject sub, Vector3 begin, Vector3 dest, ref EZAnimOptions options, Action<EZAnimation> startDel, Action<EZAnimation> stopDel)
	{
		return null;
	}

	public static AnimatePosition Do(GameObject sub, ANIM_MODE mode, Vector3 begin, Vector3 dest, Interpolator interp, float dur, float delay, Action<EZAnimation> startDel, Action<EZAnimation> stopDel)
	{
		return null;
	}

	public static AnimatePosition Do(GameObject sub, ANIM_MODE mode, Vector3 dest, Interpolator interp, float dur, float delay, Action<EZAnimation> startDel, Action<EZAnimation> stopDel)
	{
		return null;
	}

	public void Start(GameObject sub, ANIM_MODE mode, Vector3 dest, Interpolator interp, float dur, float delay, Action<EZAnimation> startDel, Action<EZAnimation> stopDel)
	{
	}

	public void Start(GameObject sub, ANIM_MODE mode, Vector3 begin, Vector3 dest, Interpolator interp, float dur, float delay, Action<EZAnimation> startDel, Action<EZAnimation> stopDel)
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

	protected override void LoopReset()
	{
	}

	protected override void OnDelayDone()
	{
	}

	protected override void DoAnim()
	{
	}
}
