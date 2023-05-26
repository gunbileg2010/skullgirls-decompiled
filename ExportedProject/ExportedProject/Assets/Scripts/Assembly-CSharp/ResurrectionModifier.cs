using System.IO;
using UnityEngine;

public class ResurrectionModifier : Modifier
{
	[SerializeField]
	protected Fixed value;

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

	public void SetValue(Fixed newValue)
	{
	}

	public Fixed GetValue()
	{
		return default(Fixed);
	}

	protected override void Apply()
	{
	}

	protected void Resurrect()
	{
	}
}
