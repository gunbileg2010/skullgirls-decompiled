using UnityEngine;

public class MeterCondition : Condition
{
	[SerializeField]
	private float meterLevel;

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
