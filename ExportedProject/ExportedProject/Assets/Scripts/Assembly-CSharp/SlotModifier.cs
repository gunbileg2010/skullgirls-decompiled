using System.IO;
using UnityEngine;

public class SlotModifier : Modifier
{
	[SerializeField]
	private string slotOpsStatement;

	[SerializeField]
	[ReadOnly]
	private Fixed value;

	[SerializeField]
	[HideInInspector]
	private SlotOpChain slotOps;

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
