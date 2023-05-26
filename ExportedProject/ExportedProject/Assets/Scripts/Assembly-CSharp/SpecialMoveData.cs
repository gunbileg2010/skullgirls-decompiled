using UnityEngine;

public class SpecialMoveData : GearData, IServerUploadable
{
	[SerializeField]
	private float[] cooldownTimes;

	public override GearType GetGearType()
	{
		return default(GearType);
	}

	public override float GetCooldown(int level = 0)
	{
		return 0f;
	}

	public override float GetSuperbarMultiplier()
	{
		return 0f;
	}

	public override float GetStartingSuperbar()
	{
		return 0f;
	}
}
