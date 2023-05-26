using System.Collections.Generic;

public class Gear
{
	private GearData gearData;

	private string backendId;

	private bool isLocked;

	private bool isNew;

	private int level;

	private List<Stat> stats;

	private Character equippingCharacter;

	private int softCurrencyValue;

	private RerolledMoveStat rerolledMoveStat;

	public Gear(GearServerData data)
	{
	}

	public Gear(GearData data, bool isSyncPvpCompetitiveGear = false)
	{
	}

	public Gear(Reward reward)
	{
	}

	public Gear(Gear other)
	{
	}

	public Gear(IDataReader reader, Character character)
	{
	}

	public void Serialize(IDataWriter writer)
	{
	}

	public GearType GetGearType()
	{
		return default(GearType);
	}

	public GearData GetGearData()
	{
		return null;
	}

	public bool GetIsNew()
	{
		return false;
	}

	public void SetIsNew(bool isNew)
	{
	}

	public bool GetIsLocked()
	{
		return false;
	}

	public void SetIsLocked(bool shouldBeLocked)
	{
	}

	public float GetCooldown()
	{
		return 0f;
	}

	public float GetBaseCooldownForDisplay()
	{
		return 0f;
	}

	public int GetLevel()
	{
		return 0;
	}

	public void SetLevel(int level)
	{
	}

	public List<Stat> GetStats()
	{
		return null;
	}

	public void SetStats(List<Stat> inStats)
	{
	}

	public void SetStatLevels(List<int> inLevels)
	{
	}

	public RerolledMoveStat GetRerolledMoveStat()
	{
		return null;
	}

	public void SetRerolledMoveStat(string originalMoveStatGuid, string newMoveStatGuid)
	{
	}

	public int GetRerolledMoveStatIndex()
	{
		return 0;
	}

	public void ResetRerolledMoveStat()
	{
	}

	public void ApplyRerolledMoveStat()
	{
	}

	public float GetDamageMultiplier()
	{
		return 0f;
	}

	public int GetSoftCurrencyValue()
	{
		return 0;
	}

	public void SetSoftCurrencyValue(int softCurrencyValue)
	{
	}

	public bool IsSignatureAbilityUnlocked()
	{
		return false;
	}

	public void UpdateFromGearServerData(GearServerData specialData)
	{
	}

	public void UpdateStatsFromStatServerDatas(List<StatServerData> statServerDatas)
	{
	}

	public float GetSuperbarPerSecond()
	{
		return 0f;
	}

	public string GetBackendId()
	{
		return null;
	}

	public Character GetEquippingCharacter()
	{
		return null;
	}

	public bool IsEquippedBy(Character character)
	{
		return false;
	}

	public void ClearCharacter(Character character)
	{
	}

	public void SetEquippingCharacter(Character character)
	{
	}

	public bool ShouldActivateOnChildrenMidLifecycle()
	{
		return false;
	}

	public bool IsFrozen()
	{
		return false;
	}

	public bool IsDuplicateOf(Gear other, bool exact = false)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	private int CalculateSoftCurrencyValue()
	{
		return 0;
	}
}
