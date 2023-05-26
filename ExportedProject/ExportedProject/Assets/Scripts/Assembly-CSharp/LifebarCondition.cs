using UnityEngine;

public class LifebarCondition : Condition
{
	[SerializeField]
	private bool compareToEnemy;

	[SerializeField]
	private ComparisonOperator comparison;

	[SerializeField]
	private ValueType valueType;

	[SerializeField]
	private float value;

	public override bool Evaluate(object context)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
