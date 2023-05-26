using System.IO;
using UnityEngine;

public class DisableModifier : Modifier
{
	[SerializeField]
	private DisableType freezeType;

	private Fixed frozenSuperbarValue;

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

	protected override void OnFrameUpdate()
	{
	}

	protected override void Unapply()
	{
	}

	private void FreezeSuperbar()
	{
	}

	private void ClearAppropriateStickyInput(ZInput input)
	{
	}
}
