using System.IO;
using UnityEngine;

public class LifebarThresholdCondition : Condition
{
	[SerializeField]
	private float value;

	[SerializeField]
	private bool onlyActivateOnce;

	private bool activatedAlready;

	public override bool Evaluate(object context)
	{
		return false;
	}

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
}
