using UnityEngine;

public class StateTagCondition : Condition
{
	[SerializeField]
	private StateTag state;

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

	public void Convert()
	{
	}

	private string StateToString(StateTag state)
	{
		return null;
	}
}
