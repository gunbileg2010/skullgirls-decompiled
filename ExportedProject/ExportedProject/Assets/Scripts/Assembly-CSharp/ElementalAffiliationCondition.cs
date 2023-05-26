using UnityEngine;

public class ElementalAffiliationCondition : Condition
{
	[SerializeField]
	private Element element;

	public void SetElement(Element element)
	{
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
