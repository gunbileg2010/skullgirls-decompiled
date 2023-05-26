using UnityEngine;

public class SplineEvaluator : MonoBehaviour
{
	[SerializeField]
	protected float from;

	[SerializeField]
	protected float to;

	[SerializeField]
	protected bool onlyActiveInRange;

	private void Awake()
	{
	}

	public virtual void Evaluate(float t)
	{
	}

	protected bool ShouldEvaluate(float t)
	{
		return false;
	}

	protected bool OutsideRange(float t)
	{
		return false;
	}

	protected float GetFraction(float t)
	{
		return 0f;
	}
}
