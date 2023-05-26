using System.IO;
using UnityEngine;

public class SpecialCooldownModifier : Modifier
{
	[SerializeField]
	private CooldownMode mode;

	[SerializeField]
	private bool activeGearOnly;

	[SerializeField]
	private Fixed value;

	public override string ToString()
	{
		return null;
	}

	public override string GetDisplayName()
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
