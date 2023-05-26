using System.IO;
using UnityEngine;

public class RemoveModifierModifier : Modifier
{
	[SerializeField]
	private ModifierType typeToRemove;

	[SerializeField]
	private bool debuffs;

	[SerializeField]
	private bool buffs;

	[SerializeField]
	private int numberToRemove;

	public int GetNumberToRemove()
	{
		return 0;
	}

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
}
