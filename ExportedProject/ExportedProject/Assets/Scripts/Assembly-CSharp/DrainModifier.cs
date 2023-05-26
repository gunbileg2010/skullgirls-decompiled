using System.IO;
using UnityEngine;

public class DrainModifier : Modifier
{
	public enum DrainType
	{
		Life = 0,
		Meter = 1
	}

	[SerializeField]
	private DrainType drainType;

	[SerializeField]
	private Fixed percentage;

	public override string ToString()
	{
		return null;
	}

	public override string GetDisplayName()
	{
		return null;
	}

	public override bool ShouldStackWith(Modifier toStack)
	{
		return false;
	}

	public DrainType GetDrainType()
	{
		return default(DrainType);
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
}
