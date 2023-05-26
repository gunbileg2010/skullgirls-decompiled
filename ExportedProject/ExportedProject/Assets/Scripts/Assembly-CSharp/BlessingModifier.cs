using System.IO;

public class BlessingModifier : ResurrectionModifier
{
	private bool initialized;

	public override ModifierType GetModifierType()
	{
		return default(ModifierType);
	}

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

	protected override void OnModifierDestroy()
	{
	}

	protected void OnAboutToDie(object passed)
	{
	}
}
