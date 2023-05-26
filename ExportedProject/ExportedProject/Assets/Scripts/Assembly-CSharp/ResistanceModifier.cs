using System.IO;
using UnityEngine;

public class ResistanceModifier : Modifier
{
	[SerializeField]
	private bool debuff;

	[SerializeField]
	private ModifierType resistType;

	[SerializeField]
	private Fixed resistChance;

	public override string GetDisplayName()
	{
		return null;
	}

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
}
