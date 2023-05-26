using System;
using UnityEngine;

public class RunAnimClip : EZAnimation
{
	private GameObject subject;

	private string m_clip;

	private bool playedYet;

	private float blending;

	public static RunAnimClip Do(GameObject sub, string clip, float blend, float dur, float delay, Action<EZAnimation> startDel, Action<EZAnimation> del)
	{
		return null;
	}

	public void Start(GameObject sub, string clip, float blend, float dur, float delay, Action<EZAnimation> startDel, Action<EZAnimation> del)
	{
	}

	public override object GetSubject()
	{
		return null;
	}

	public override bool StepInternal(float timeDelta)
	{
		return false;
	}

	protected override void DoAnim()
	{
	}
}
