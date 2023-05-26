using System.IO;
using UnityEngine;

public class TagInCooldownModifier : Modifier
{
	[SerializeField]
	private CooldownMode mode;

	[SerializeField]
	private Fixed value;

	[SerializeField]
	private ValueType valueType;

	private Fixed reduction;

	public override string ToString()
	{
		return null;
	}

	public override string GetDisplayName()
	{
		return null;
	}

	public override bool CompareStates(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	public override void SaveState(BinaryWriter writer)
	{
	}

	public override void LoadState(BinaryReader reader)
	{
	}

	protected override void Apply()
	{
	}

	protected override void Unapply()
	{
	}
}
