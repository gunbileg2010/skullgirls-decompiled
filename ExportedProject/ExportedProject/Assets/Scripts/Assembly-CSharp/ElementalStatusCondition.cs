using UnityEngine;

public class ElementalStatusCondition : Condition
{
	[SerializeField]
	private ElementStatus elementStatus;

	[SerializeField]
	private bool checkSameElement;

	public override bool Evaluate(object context)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
