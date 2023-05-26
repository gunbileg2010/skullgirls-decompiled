using UnityEngine;

public class FightTimeElapsedCondition : Condition
{
	[SerializeField]
	private ComparisonOperator comparison;

	[SerializeField]
	private int seconds;

	[SerializeField]
	private int offset;

	[SerializeField]
	private bool anyMultiple;

	[SerializeField]
	private bool countZeroAsMultiple;

	public override bool Evaluate(object context)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
