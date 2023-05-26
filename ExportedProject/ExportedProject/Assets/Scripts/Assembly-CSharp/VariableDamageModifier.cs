using System.IO;
using UnityEngine;

public class VariableDamageModifier : Modifier
{
	[SerializeField]
	public float percentDamageIncrease;

	[SerializeField]
	public int damageAddPerHealthPercentLost;

	[SerializeField]
	public ModifierType modifierToCheck;

	[SerializeField]
	public bool ignoreTypeNone;

	[SerializeField]
	public bool buffs;

	[SerializeField]
	public bool debuffs;

	[SerializeField]
	public bool checkEnemy;

	private Fixed lastAppliedBonusDamagePercent;

	public override string ToString()
	{
		return null;
	}

	public override string GetDisplayName()
	{
		return null;
	}

	public override void SaveState(BinaryWriter writer)
	{
	}

	public override void LoadState(BinaryReader reader)
	{
	}

	public override bool CompareStates(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	protected override void Apply()
	{
	}

	protected override void Unapply()
	{
	}
}
