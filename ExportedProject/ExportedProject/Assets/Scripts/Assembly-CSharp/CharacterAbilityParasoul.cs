using System.IO;

public class CharacterAbilityParasoul : CharacterAbility
{
	private int tearsActive;

	private uint tearDetonated;

	private uint tearDissolved;

	private uint tearSpawned;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public int GetNumTearsActive()
	{
		return 0;
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

	protected override void OnAniEvent(object passed)
	{
	}

	private void OnTearDetonation()
	{
	}

	private void OnTearSpawned()
	{
	}

	private void OnTearDissolved()
	{
	}
}
