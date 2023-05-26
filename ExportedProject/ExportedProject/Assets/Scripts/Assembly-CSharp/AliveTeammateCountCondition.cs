using UnityEngine;

public class AliveTeammateCountCondition : Condition
{
	[SerializeField]
	private int count;

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
