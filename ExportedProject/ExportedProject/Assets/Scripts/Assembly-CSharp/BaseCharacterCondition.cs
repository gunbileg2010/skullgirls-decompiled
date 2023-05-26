using UnityEngine;

public class BaseCharacterCondition : Condition
{
	[SerializeField]
	private BaseCharacterData baseCharacterData;

	public override bool Evaluate(object context)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public void SetBaseCharacter(BaseCharacterData baseCharacterData)
	{
	}
}
