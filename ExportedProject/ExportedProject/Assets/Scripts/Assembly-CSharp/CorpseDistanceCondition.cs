using UnityEngine;

public class CorpseDistanceCondition : Condition
{
	[SerializeField]
	private float distance;

	[SerializeField]
	private ComparisonOperator comparison;

	[SerializeField]
	private bool checkAllies;

	[SerializeField]
	private bool checkEnemies;

	public override bool Evaluate(object context)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
