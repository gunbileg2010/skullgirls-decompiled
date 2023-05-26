using UnityEngine;

public class EZAnimatePositionDriver : EZAnimationDriver
{
	[SerializeField]
	private Transform from;

	[SerializeField]
	private Transform to;

	[SerializeField]
	private Vector3 fromPosition;

	[SerializeField]
	private Vector3 toPosition;

	protected override EZAnimation CreateAndStart()
	{
		return null;
	}

	private Vector3 GetFrom()
	{
		return default(Vector3);
	}

	private Vector3 GetTo()
	{
		return default(Vector3);
	}
}
