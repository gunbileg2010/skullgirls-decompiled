using UnityEngine;

public class ChildDistanceCondition : Condition
{
	[SerializeField]
	private int distance;

	[SerializeField]
	private bool distanceToSelf;

	[SerializeField]
	private string stateString;

	public override bool Evaluate(object context)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
