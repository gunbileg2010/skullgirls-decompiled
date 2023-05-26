using UnityEngine;

public class EZAnimateScaleDriver : EZAnimationDriver
{
	[SerializeField]
	private Transform from;

	[SerializeField]
	private Transform to;

	[SerializeField]
	private Vector3 fromScale;

	[SerializeField]
	private Vector3 toScale;

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
