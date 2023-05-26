using System.IO;

public class MiasmaModifier : Modifier
{
	private BleedModifier bleedModifier;

	private RegenModifier regenModifier;

	private SuperbarModifier meterDrainModifier;

	private SuperbarModifier meterBuildModifier;

	private const int kDrainDistance = 300;

	private Fixed percentage;

	private bool initialized;

	private Fixed accumulatedTime;

	private Fixed timeUntilActivation;

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

	protected override void Unapply()
	{
	}

	protected override void OnFrameUpdate()
	{
	}

	private void Tick()
	{
	}

	private void InitializeTemplateModifiers()
	{
	}

	private void SetRate(Fixed percent)
	{
	}

	private bool IsDrainAllowed()
	{
		return false;
	}
}
