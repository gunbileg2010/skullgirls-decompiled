using System.IO;
using UnityEngine;

public class ReserveRegenModifier : Modifier
{
	public enum RegenType
	{
		Life = 0,
		Meter = 1
	}

	[SerializeField]
	private RegenType regenType;

	[SerializeField]
	private Fixed value;

	private Slot slotToModify;

	private Fixed bonus;

	public override string ToString()
	{
		return null;
	}

	public override string GetDisplayName()
	{
		return null;
	}

	public RegenType GetRegenType()
	{
		return default(RegenType);
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
