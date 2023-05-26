using System.IO;
using UnityEngine;

public class LifebarModifier : Modifier
{
	[SerializeField]
	private ValueType valueType;

	[SerializeField]
	private Fixed value;

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
