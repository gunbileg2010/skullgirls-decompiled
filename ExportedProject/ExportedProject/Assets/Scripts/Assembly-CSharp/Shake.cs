using System;
using UnityEngine;

public class Shake : EZAnimation
{
	private GameObject subject;

	private Transform subTrans;

	private Vector3 start;

	private Vector3 magnitude;

	private float oscillations;

	public static Shake Do(GameObject sub, Vector3 mag, float oscill, ref EZAnimOptions options, Action<EZAnimation> startDel, Action<EZAnimation> stopDel)
	{
		return null;
	}

	public static Shake Do(GameObject sub, Vector3 mag, float oscill, float dur, float delay, Action<EZAnimation> startDel, Action<EZAnimation> stopDel)
	{
		return null;
	}

	public void Start(GameObject sub, Vector3 mag, float oscill, float dur, float delay, Action<EZAnimation> startDel, Action<EZAnimation> stopDel)
	{
	}

	public void Start(GameObject sub, Vector3 begin, Vector3 mag, float oscill, float dur, float delay, Action<EZAnimation> startDel, Action<EZAnimation> stopDel)
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

	protected override void OnDelayDone()
	{
	}

	protected override void DoAnim()
	{
	}
}
