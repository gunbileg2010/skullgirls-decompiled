using System.IO;
using UnityEngine;

public class SpecialMoveDamageModifier : Modifier
{
	[SerializeField]
	private Fixed percent;

	public override string ToString()
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

	public override string GetDisplayName()
	{
		return null;
	}
}
