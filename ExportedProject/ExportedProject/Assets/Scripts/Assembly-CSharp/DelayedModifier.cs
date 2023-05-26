using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DelayedModifier : Modifier
{
	[SerializeField]
	private Modifier delayedModifier;

	private bool isActive;

	public override string ToString()
	{
		return null;
	}

	public override bool ShouldStackWith(Modifier toStack)
	{
		return false;
	}

	public override List<Modifier> GetInternalModifiers()
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

	protected override void Unapply()
	{
	}

	protected override void OnFrameUpdate()
	{
	}
}
