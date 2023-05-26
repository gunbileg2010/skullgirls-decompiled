using UnityEngine;

public class RotationEZSelfContainedAnimation : AbstractEZSelfContainedAnimator
{
	[SerializeField]
	private Vector3 origin;

	[SerializeField]
	private Vector3 destination;

	private Quaternion originalRotation;

	protected override void Awake()
	{
	}

	protected override EZAnimation GetAnimation()
	{
		return null;
	}

	protected override void Reset()
	{
	}
}
