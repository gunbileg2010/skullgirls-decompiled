using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ResetModifierTimerModifier : Modifier
{
	[SerializeField]
	private bool buffs;

	[SerializeField]
	private bool debuffs;

	[SerializeField]
	private List<ModifierType> includedTypes;

	[SerializeField]
	private List<ModifierType> excludedTypes;

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
}
