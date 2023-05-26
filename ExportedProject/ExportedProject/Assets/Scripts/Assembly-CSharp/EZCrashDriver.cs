using UnityEngine;

public class EZCrashDriver : EZAnimationDriver
{
	[SerializeField]
	private Vector3 magnitude;

	protected override EZAnimation CreateAndStart()
	{
		return null;
	}
}
