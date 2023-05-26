using System;

[Serializable]
public struct EZAnimOptions
{
	public EZAnimation.ANIM_MODE mode;

	public EZAnimation.EASING_TYPE easingType;

	public float delay;

	public float duration;

	public bool loop;

	public bool pingPong;

	public bool delayOnLoop;

	public bool delayOnPingPong;

	public bool useScaledDeltaTime;
}
