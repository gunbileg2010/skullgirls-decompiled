using System.IO;
using UnityEngine;

public class StatModifier : Modifier
{
	private enum StatsToModify
	{
		Attack = 0,
		Defense = 1
	}

	private enum ModifyBy
	{
		Percent = 0,
		PercentOfCurrentHealth = 1,
		CapTo = 2,
		PercentOfMissingHealth = 3
	}

	[SerializeField]
	private StatsToModify statToModify;

	[SerializeField]
	private ModifyBy modifyBy;

	[SerializeField]
	private Fixed value;

	private Fixed bonusApplied;

	public override string ToString()
	{
		return null;
	}

	public override bool ShouldStackWith(Modifier toStack)
	{
		return false;
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
