using UnityEngine;

public class PointAtCharacterDetailsGearTutorialAction : SequentialTutorialAction
{
	[SerializeField]
	private GearData gear;

	[SerializeField]
	private int gearIndex;

	[SerializeField]
	private bool gearSlot;

	public override string ToString()
	{
		return null;
	}

	protected override void ExecuteAction()
	{
	}
}
