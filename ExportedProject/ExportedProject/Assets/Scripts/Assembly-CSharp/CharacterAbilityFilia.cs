using System.IO;

public class CharacterAbilityFilia : CharacterAbility
{
	private Fixed critChanceBonus;

	private bool bonusApplied;

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

	protected override void OnActorWhiffedHit(object passed)
	{
	}

	protected override void OnActorLandedCrit(object passed)
	{
	}
}
