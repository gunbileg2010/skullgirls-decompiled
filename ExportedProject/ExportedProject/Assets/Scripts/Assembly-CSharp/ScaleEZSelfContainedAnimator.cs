using UnityEngine;

public class ScaleEZSelfContainedAnimator : AbstractEZSelfContainedAnimator
{
	[SerializeField]
	private Vector3 startingScale;

	[SerializeField]
	private Vector3 targetScale;

	private Vector3 originalScale;

	protected override void Awake()
	{
	}

	public void Setup()
	{
	}

	protected override EZAnimation GetAnimation()
	{
		return null;
	}

	protected override void Reset()
	{
	}

	public void SetTargetScale(Vector3 scale)
	{
	}

	public void SetOriginScale(Vector3 scale)
	{
	}
}
