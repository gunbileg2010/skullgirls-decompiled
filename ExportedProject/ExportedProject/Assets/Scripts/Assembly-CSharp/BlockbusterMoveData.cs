using UnityEngine;

public class BlockbusterMoveData : GearData, IServerUploadable
{
	[SerializeField]
	private int strengthLevel;

	public override GearType GetGearType()
	{
		return default(GearType);
	}

	public override int GetStrengthLevel()
	{
		return 0;
	}
}
