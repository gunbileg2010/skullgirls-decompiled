using System.IO;
using UnityEngine;

public class TeamLifeDrainModifier : Modifier
{
	[SerializeField]
	private Fixed percentage;

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

	private void SetLife(Actor actor, float newValue, Slot slot = Slot.LIFEBAR)
	{
	}
}
