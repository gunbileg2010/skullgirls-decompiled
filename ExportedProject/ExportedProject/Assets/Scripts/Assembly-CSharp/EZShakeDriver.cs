using UnityEngine;

public class EZShakeDriver : EZAnimationDriver
{
	[SerializeField]
	private Vector3 magnitude;

	[SerializeField]
	private float oscillation;

	protected override EZAnimation CreateAndStart()
	{
		return null;
	}
}
