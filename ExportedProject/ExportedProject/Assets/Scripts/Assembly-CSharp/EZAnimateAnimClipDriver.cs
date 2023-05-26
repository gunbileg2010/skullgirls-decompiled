using UnityEngine;

public class EZAnimateAnimClipDriver : EZAnimationDriver
{
	[SerializeField]
	private AnimationClip clip;

	protected override EZAnimation CreateAndStart()
	{
		return null;
	}
}
