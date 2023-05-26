using UnityEngine;

public class ComboCountCondition : Condition
{
	[SerializeField]
	private ComparisonOperator comparison;

	[SerializeField]
	private int count;

	[SerializeField]
	private bool useOffByOne;

	[SerializeField]
	private bool anyMultiple;

	public int GetCount()
	{
		return 0;
	}

	public override bool Evaluate(object context)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
