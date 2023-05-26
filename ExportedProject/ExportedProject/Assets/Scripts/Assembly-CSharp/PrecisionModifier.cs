using System.IO;

public class PrecisionModifier : Modifier
{
	private bool initialized;

	private SignatureAbility disabledAbility;

	private int disabledFrame;

	private const int kFramesToWait = 2;

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

	private void OnActorCollision(object passed)
	{
	}

	private void OnFightFrameUpdated(object passed)
	{
	}

	protected override void OnModifierDestroy()
	{
	}
}
