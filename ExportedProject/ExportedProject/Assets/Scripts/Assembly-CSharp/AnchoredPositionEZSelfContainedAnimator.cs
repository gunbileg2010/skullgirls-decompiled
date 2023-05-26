using UnityEngine;

public class AnchoredPositionEZSelfContainedAnimator : AbstractEZSelfContainedAnimator
{
	[SerializeField]
	private Vector3 origin;

	[SerializeField]
	private Vector3 destination;

	private Vector3 startingPosition;

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

	public void SetOrigin(Vector3 origin)
	{
	}

	public void SetDestination(Vector3 destination)
	{
	}
}
