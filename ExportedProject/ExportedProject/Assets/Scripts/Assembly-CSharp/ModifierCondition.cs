using UnityEngine;

public class ModifierCondition : Condition
{
	private enum Mode
	{
		ModifierType = 0,
		NumberStack = 1,
		ClassType = 2
	}

	[SerializeField]
	private ModifierType modifierType;

	[SerializeField]
	private Mode mode;

	[SerializeField]
	private bool debuff;

	[SerializeField]
	private bool buff;

	[SerializeField]
	private bool notAppliedThisFrame;

	[SerializeField]
	private bool allStrengths;

	[SerializeField]
	private ModifierStrength modifierStrength;

	[SerializeField]
	private bool ignorePermanent;

	[SerializeField]
	private bool atLeastStackNumber;

	[SerializeField]
	private int stackValue;

	[SerializeField]
	private bool useContextualModifier;

	[SerializeField]
	private bool appliedByThisSignatureAbility;

	[SerializeField]
	private bool checkInstantModifierType;

	[SerializeField]
	private string checkModifierId;

	[SerializeField]
	private Modifier modifierClass;

	public override bool Evaluate(object context)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	private bool IsCorrectModifierType(Modifier modifier)
	{
		return false;
	}

	private bool PassesCondition(Modifier modifier, SignatureAbility signatureAbility)
	{
		return false;
	}
}
