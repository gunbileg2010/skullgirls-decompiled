using System.IO;

public class StunModifier : Modifier
{
	private bool startedAnimation;

	private Fixed stunLength;

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

	protected override void OnFrameUpdate()
	{
	}

	protected override void Unapply()
	{
	}
}
