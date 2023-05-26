using System.IO;
using UnityEngine;

public class TransferModifierModifier : Modifier
{
	[SerializeField]
	private int numberToTransfer;

	[SerializeField]
	private bool transferAll;

	[SerializeField]
	private bool duplicate;

	[SerializeField]
	private bool refreshDuration;

	[SerializeField]
	private bool chooseRandom;

	[SerializeField]
	private bool debuffs;

	[SerializeField]
	private bool buffs;

	[SerializeField]
	private bool targetOwnPoint;

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

	protected override void Apply()
	{
	}
}
