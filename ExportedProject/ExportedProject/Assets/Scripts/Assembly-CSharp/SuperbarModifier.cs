using System.IO;
using UnityEngine;

public class SuperbarModifier : Modifier
{
	public enum Mode
	{
		AdjustByValue = 0,
		AdjustByPercent = 1,
		MatchOpponentTopValue = 2
	}

	[SerializeField]
	private Mode modifyMode;

	[SerializeField]
	private Fixed value;

	[SerializeField]
	private bool perSecond;

	[SerializeField]
	private bool activeGearOnly;

	[SerializeField]
	private bool assignedGearOnly;

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

	public void SetPerSecond(bool onOff)
	{
	}

	public void SetAdjustmentMode(Mode newMode)
	{
	}

	protected override void OnFrameUpdate()
	{
	}

	protected override void Apply()
	{
	}

	private void AdjustSuperBar()
	{
	}

	private float GetOpponentTopBBMeterValue()
	{
		return 0f;
	}
}
