using System;
using System.IO;

public class GearStatusTracker
{
	public Action<Actor> onUseCallback;

	private Gear gear;

	private int index;

	private float superbar;

	private float maxSuperbar;

	private float cooldownOverride;

	private bool usedThisCombo;

	private bool oneTimeUseSpent;

	public GearStatusTracker(Gear gear, int index)
	{
	}

	public GearStatusTracker(BinaryReader reader, Character character)
	{
	}

	public void UpdateSuperbar(float superbarDelta)
	{
	}

	public void SetSuperbar(float newValue)
	{
	}

	public float GetSuperbar()
	{
		return 0f;
	}

	public float GetMaxSuperbar()
	{
		return 0f;
	}

	public void SetCooldownOverride(float cooldownOverride)
	{
	}

	public Gear GetGear()
	{
		return null;
	}

	public GearType GetGearType()
	{
		return default(GearType);
	}

	public bool IsBB3()
	{
		return false;
	}

	public int GetIndex()
	{
		return 0;
	}

	public bool IsFrozen()
	{
		return false;
	}

	public bool HasSpentOneTimeUse()
	{
		return false;
	}

	public void ClearUsedFlag()
	{
	}

	public bool CanUse()
	{
		return false;
	}

	public ZInput GetRelatedInput()
	{
		return null;
	}

	public void SpendSuperbar()
	{
	}

	public void StartCooldown()
	{
	}

	public void ResetCooldown()
	{
	}

	public void SaveState(BinaryWriter writer)
	{
	}

	public void LoadState(BinaryReader reader, Character character)
	{
	}

	private float GetSuperbarPerSecond()
	{
		return 0f;
	}
}
