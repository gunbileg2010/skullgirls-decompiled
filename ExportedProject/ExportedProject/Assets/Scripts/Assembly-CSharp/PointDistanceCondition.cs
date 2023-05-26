using UnityEngine;

public class PointDistanceCondition : Condition
{
	[SerializeField]
	private float distance;

	[SerializeField]
	private ComparisonOperator comparison;

	public override bool Evaluate(object context)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
