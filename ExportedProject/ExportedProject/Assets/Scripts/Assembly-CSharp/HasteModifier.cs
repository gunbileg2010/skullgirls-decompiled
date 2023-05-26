using System.IO;

public class HasteModifier : Modifier
{
	private Fixed bonus;

	public override string ToString()
	{
		return null;
	}

	public override string GetDisplayName()
	{
		return null;
	}

	public override ModifierType GetModifierType()
	{
		return default(ModifierType);
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
