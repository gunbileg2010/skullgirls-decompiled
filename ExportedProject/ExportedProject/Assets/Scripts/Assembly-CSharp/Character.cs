using System;
using System.Collections.Generic;

public class Character
{
	public enum EquipGearStatus
	{
		NullItem = 0,
		InvalidIndex = 1,
		InvalidBaseCharacterType = 2,
		NotEnoughGearPoints = 3,
		MultipleStrenght3Items = 4,
		DuplicateBB = 5,
		Success = 6
	}

	public static readonly int[] kMaxCharacterLevels;

	public const int kMaxPossibleCharacterLevel = 60;

	public const int kMaxCharacterEnergy = 10;

	public const int kMaxGearLevel = 15;

	public const int kMaxGearSlots = 5;

	private string backendId;

	private VariantCharacterData variantData;

	private RarityTier tier;

	private long experience;

	private double levelAndProgress;

	private int cachedFighterScore;

	private Energy standardEnergy;

	private Energy multiplayerEnergy;

	private Dictionary<string, SkillTreeNodeStateData> skillTreeData;

	private int[] superAbilityLevels;

	private int superAbilityActiveFeatureSet;

	private int prestigeAbilityLevel;

	private float extraFSMultiplierAddition;

	private List<Gear> gears;

	public SkillTree currentSkillTree;

	private bool isLocked;

	private bool isNew;

	private bool isShiny;

	private HashSet<EventData> eventsLockedInto;

	private CharacterStats characterStats;

	private bool isRandom;

	private const float kMinimumAdjustmentIncrement = 0.001f;

	private Actor actor;

	public Character(VariantCharacterData myCharacterData, bool isSyncPvpCompetitiveCharacter = false, bool isShiny = false)
	{
	}

	public Character(Reward reward)
	{
	}

	public Character(Character otherCharacter)
	{
	}

	public Character(Character otherCharacter, List<Gear> overrideGears)
	{
	}

	public Character(CharacterServerData characterServerData, Profile profile = null)
	{
	}

	public Character(EnemyCharacterServerData enemyCharacterServerData, bool isRandom, SkillTree overrideSkillTree)
	{
	}

	public Character(IDataReader reader)
	{
	}

	public void UpdateFromCharacterServerData(CharacterServerData characterServerData, Profile profile = null)
	{
	}

	public void UpdateFromEnemyCharacterServerData(EnemyCharacterServerData enemyCharacterServerData, bool isRandom, SkillTree overrideSkillTree)
	{
	}

	public void Serialize(IDataWriter writer)
	{
	}

	public void SetExperience(long newExperience, bool ignoreLevelCaps = false)
	{
	}

	public long GetExperience()
	{
		return 0L;
	}

	public void SetLevel(int inLevel, bool ignoreLevelCaps = false)
	{
	}

	public int GetLevel()
	{
		return 0;
	}

	public float GetFloatLevel()
	{
		return 0f;
	}

	public float GetLevelProgress()
	{
		return 0f;
	}

	public bool AtLevelCap()
	{
		return false;
	}

	public int GetLevelCap()
	{
		return 0;
	}

	public void Evolve()
	{
	}

	public RarityTier GetTier()
	{
		return default(RarityTier);
	}

	public void SetTier(RarityTier rarity)
	{
	}

	public Element GetElement()
	{
		return default(Element);
	}

	public bool IsShiny()
	{
		return false;
	}

	public void SetShinyNoRecalc(bool value)
	{
	}

	public bool ShowShinyVisuals()
	{
		return false;
	}

	public SkillTree GetSkillTree()
	{
		return null;
	}

	public int GetTotalNumberOfPurchaseableSkillNodes()
	{
		return 0;
	}

	public int GetTotalNumberOfPurchasedNodes()
	{
		return 0;
	}

	public float GetSkillTreeCompletionRatio()
	{
		return 0f;
	}

	public void AutoSpendSkillPoints(int pointsToSpend = 0, SkillTree overrideTree = null)
	{
	}

	public Dictionary<string, SkillTreeNodeStateData> GetSkillTreeData()
	{
		return null;
	}

	public SkillTreeNodeStateData GetSkillTreeProgressionDataForNode(string guid)
	{
		return null;
	}

	public bool HasSkillTreeUpgradesAvailable()
	{
		return false;
	}

	public bool IsSkillTreeMaxedOut()
	{
		return false;
	}

	public Energy GetEnergy()
	{
		return null;
	}

	public Energy GetEnergy(EnergyType energyType)
	{
		return null;
	}

	public int GetAvailableEnergy()
	{
		return 0;
	}

	public int GetAvailableEnergy(EnergyType energyType)
	{
		return 0;
	}

	public void RefreshEnergyCooldowns()
	{
	}

	public float GetEnergyCooldownInSeconds()
	{
		return 0f;
	}

	public float GetSecondsToNextEnergy()
	{
		return 0f;
	}

	public float GetSecondsToNextEnergy(EnergyType energyType)
	{
		return 0f;
	}

	public float GetSecondsUntilEnergyFull(EnergyType energyType)
	{
		return 0f;
	}

	public void UseEnergy(int amount)
	{
	}

	public void UseEnergy(EnergyType energyType, int amount)
	{
	}

	public void RefillEnergy(EnergyType energyType)
	{
	}

	public void RefillAllEnergies()
	{
	}

	public bool GetIsLocked()
	{
		return false;
	}

	public void SetIsLocked(bool shouldBeLocked)
	{
	}

	public bool GetIsNew()
	{
		return false;
	}

	public void SetIsNew(bool isNew)
	{
	}

	public float GetBaseAttack(int? level = null, RarityTier? rarityTier = null)
	{
		return 0f;
	}

	public int GetAttack(int? level = null, RarityTier? rarityTier = null)
	{
		return 0;
	}

	public float GetBaseLifebar(int? level = null, RarityTier? rarityTier = null)
	{
		return 0f;
	}

	public int GetLifebar(int? level = null, RarityTier? rarityTier = null)
	{
		return 0;
	}

	public float CalculateSkillTreeBuff(SkillTreeNodeType type)
	{
		return 0f;
	}

	public int GetFighterScore()
	{
		return 0;
	}

	public void InvalidateCachedFighterScore()
	{
	}

	public int GetFighterScoreWithTierAndLevel(RarityTier tier, int level)
	{
		return 0;
	}

	public void SetExtraFSMultiplierAddition(float multiplierAddition)
	{
	}

	public float GetExtraFSMultiplierAddition()
	{
		return 0f;
	}

	public bool IsSignatureAbilityUnlocked()
	{
		return false;
	}

	public int[] GetSignatureAbilityLevels()
	{
		return null;
	}

	public bool IsSuperAbilityUnlocked()
	{
		return false;
	}

	public int[] GetSuperAbilityLevels(bool forDisplayOnly = false)
	{
		return null;
	}

	public void UpgradeSuperAbility(int featureSetIndex)
	{
	}

	public void SetSuperAbilityActiveFeatureSet(int activeFeatureSetIndex)
	{
	}

	public int GetSuperAbilityActiveFeatureSet()
	{
		return 0;
	}

	public int GetActiveSuperAbilityLevel()
	{
		return 0;
	}

	public bool IsAdvancedComboUnlocked()
	{
		return false;
	}

	public bool IsAdvancedJuggleUnlocked()
	{
		return false;
	}

	public bool IsChargeUpgradeUnlocked()
	{
		return false;
	}

	public bool IsCharacterAbilityUnlocked()
	{
		return false;
	}

	public bool IsPrestigeAbilityUnlocked()
	{
		return false;
	}

	public int GetPrestigeAbilityLevel()
	{
		return 0;
	}

	public void SetPrestigeAbilityLevel(int prestigeAbilityLevel)
	{
	}

	public bool IsPrestigeAbilityMax()
	{
		return false;
	}

	public bool IsFullyMaxedOut()
	{
		return false;
	}

	public VariantCharacterData GetVariantData()
	{
		return null;
	}

	public BaseCharacterData GetBaseData()
	{
		return null;
	}

	public Actor GetActor()
	{
		return null;
	}

	public void SetActor(Actor myActor)
	{
	}

	public bool IsRandom()
	{
		return false;
	}

	public void SetRandom(bool random)
	{
	}

	public string GetBackendId()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public int GetTotalGearPoints(SkillTree overrideSkillTree = null)
	{
		return 0;
	}

	public int GetUsedGearPoints(List<Gear> overrideGear = null)
	{
		return 0;
	}

	public int GetAvailableGearPoints()
	{
		return 0;
	}

	public int GetGearSlotCount(SkillTree overrideSkillTree = null)
	{
		return 0;
	}

	public List<Gear> GetGears()
	{
		return null;
	}

	public void SetGears(List<Gear> overrideGears)
	{
	}

	public bool HasEquipped(Gear item)
	{
		return false;
	}

	public Gear GetEquippedAt(int idx)
	{
		return null;
	}

	public void EquipGear(int idx, Gear item)
	{
	}

	public void RemoveGearAtIndex(int idx)
	{
	}

	public void RemoveGear(Gear item)
	{
	}

	public void RemoveAllGear()
	{
	}

	public EquipGearStatus CanEquipGearInSlot(int idx, Gear item)
	{
		return default(EquipGearStatus);
	}

	public int GetEquippedGearIndex(Gear item)
	{
		return 0;
	}

	public void RecalculateStats()
	{
	}

	public CharacterStats GetStats()
	{
		return null;
	}

	public void IsLockedForFeeding(Action<bool> callback)
	{
	}

	public void LockIntoEvent(EventData eventData)
	{
	}

	public void UnlockFromEvent(EventData eventData)
	{
	}

	public HashSet<EventData> GetEventsLockedInto()
	{
		return null;
	}

	public bool IsLockedIntoEvent()
	{
		return false;
	}

	public bool HasAnyGearsEquipped()
	{
		return false;
	}

	private float ConvertLevelAndProgressToFloat(double value)
	{
		return 0f;
	}

	private void ParseSkillTreeData(string[] skillNodeGuids)
	{
	}
}
