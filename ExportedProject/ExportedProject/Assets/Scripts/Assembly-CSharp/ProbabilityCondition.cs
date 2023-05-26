using UnityEngine;

public class ProbabilityCondition : Condition
{
	[SerializeField]
	private float probability;

	public override bool Evaluate(object context)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
