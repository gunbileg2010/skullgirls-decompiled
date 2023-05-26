using UnityEngine;

public class EZCrashRotationDriver : EZAnimationDriver
{
	[SerializeField]
	private Vector3 magnitude;

	[SerializeField]
	private Vector3 oscillation;

	protected override EZAnimation CreateAndStart()
	{
		return null;
	}
}
