using System.IO;
using UnityEngine;

public class ThornsModifier : ReflectModifier
{
	[SerializeField]
	private Fixed percentOverride;

	public override bool ShouldStackWith(Modifier toStack)
	{
		return false;
	}

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

	protected override void OnActorWasHit(object passed)
	{
	}
}
