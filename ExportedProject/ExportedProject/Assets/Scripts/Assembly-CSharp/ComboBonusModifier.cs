using System.IO;
using UnityEngine;

public class ComboBonusModifier : Modifier
{
	[SerializeField]
	private Fixed percent;

	private Fixed bonus;

	public override string ToString()
	{
		return null;
	}

	public override string GetDisplayName()
	{
		return null;
	}

	public Fixed GetPercent()
	{
		return default(Fixed);
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

	protected override void Unapply()
	{
	}
}
