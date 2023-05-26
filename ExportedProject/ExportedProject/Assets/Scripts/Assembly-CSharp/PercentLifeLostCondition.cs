using UnityEngine;

public class PercentLifeLostCondition : Condition
{
	[SerializeField]
	private float value;

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
