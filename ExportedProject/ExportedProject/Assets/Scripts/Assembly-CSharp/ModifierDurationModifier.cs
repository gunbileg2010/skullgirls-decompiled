using System.IO;
using UnityEngine;

public class ModifierDurationModifier : Modifier
{
	public enum ModifyType : byte
	{
		Add = 0,
		Multiply = 1
	}

	[SerializeField]
	private ModifyType modifyType;

	[SerializeField]
	private Fixed value;

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
}
