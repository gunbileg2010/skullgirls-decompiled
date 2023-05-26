using UnityEngine;

public class VariantCharacterDataCondition : Condition
{
	[SerializeField]
	private VariantCharacterData variantCharacterData;

	public override bool Evaluate(object context)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
