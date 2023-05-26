using System.IO;

public class CharacterAbilityFukua : CharacterAbility
{
	private const int kCloneOutFlag = 25;

	private const int kSlideCloneOutFlag = 26;

	private const int kRushCloneOutFlag = 27;

	private const int kSlideSpecialId = 6;

	private const int kRushSpecialId = 7;

	private int activeCloneGearIndex;

	private uint cloneHoldTimeExpired;

	private uint cloneHit;

	private uint cloneSpawned;

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

	protected override void OnAniEvent(object passed)
	{
	}

	private void TriggerClone()
	{
	}
}
