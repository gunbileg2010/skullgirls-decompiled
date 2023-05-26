using System.IO;
using UnityEngine;

public class DoomModifier : Modifier
{
	[SerializeField]
	private bool killToRemove;

	public override ModifierType GetModifierType()
	{
		return default(ModifierType);
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

	protected override void ModifierFrameUpdate(object passed)
	{
	}

	protected override void OnFrameUpdate()
	{
	}
}
