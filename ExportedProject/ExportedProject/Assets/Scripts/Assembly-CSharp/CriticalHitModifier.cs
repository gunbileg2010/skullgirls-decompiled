using System.IO;
using UnityEngine;

public class CriticalHitModifier : Modifier
{
	[SerializeField]
	private Fixed critChance;

	[SerializeField]
	private Fixed critDamage;

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

	public Fixed GetCritChance()
	{
		return default(Fixed);
	}

	public Fixed GetCritDamage()
	{
		return default(Fixed);
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

	protected override void OnModifierDestroy()
	{
	}
}
