using System.IO;
using UnityEngine;

public class RandomModifierModifier : Modifier
{
	[SerializeField]
	private int numberToAdd;

	[SerializeField]
	private RandomModifierList randomModifierList;

	public override string ToString()
	{
		return null;
	}

	public override string GetDisplayName()
	{
		return null;
	}

	public override void LoadState(BinaryReader reader)
	{
	}

	protected override void Apply()
	{
	}
}
