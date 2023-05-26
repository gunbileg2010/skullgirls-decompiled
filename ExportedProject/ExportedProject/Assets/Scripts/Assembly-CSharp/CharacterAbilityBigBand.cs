using System.IO;

public class CharacterAbilityBigBand : CharacterAbility
{
	private bool unflinchingApplied;

	private bool unflinchingValue;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override void SaveState(BinaryWriter writer)
	{
	}

	public override void LoadState(BinaryReader reader)
	{
	}

	public override bool CompareState(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	protected override void OnFightFrameUpdated(object passed)
	{
	}

	protected override void OnActorLandedHit(object passed)
	{
	}

	protected override void OnActorWhiffedHit(object passed)
	{
	}

	protected override void OnActorWasHit(object passed)
	{
	}

	private void SetDefaultUnflinchingValue()
	{
	}
}
