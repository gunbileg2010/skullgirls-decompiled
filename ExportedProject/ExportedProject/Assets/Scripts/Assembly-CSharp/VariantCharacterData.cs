using System;
using System.Collections.Generic;
using UnityEngine;

public class VariantCharacterData : GuidScriptableObject, IServerUploadable
{
	[Serializable]
	public class BaseScaledValues
	{
		public int lifebar;

		public int attack;
	}

	[SerializeField]
	[Lockable]
	public int variantIndex;

	[SerializeField]
	private BaseCharacterData baseCharacter;

	public string displayVariantName;

	public string variantDescription;

	public string variantQuote;

	public int paletteIndex;

	public RarityTier initialTier;

	[SerializeField]
	private BaseScaledValues[] baseScaledValuesByTier;

	[SerializeField]
	private DynamicResource signatureAbility;

	[SerializeField]
	private DynamicResource superAbility;

	public int introAnimId;

	public Color tintColor;

	public SkillTree skillTree;

	public Element elementAffiliation;

	public PalettizedImage cardPortraitPalettizedImage;

	public bool cardPortraitAboveTopFrame;

	[SerializeField]
	private bool isInCompetitiveCollection;

	[SerializeField]
	private bool isBannedFromSyncPvp;

	public bool placeholder;

	public GearData startingGear;

	public int startingGearSlots;

	public int startingGearPointsLimit;

	[SerializeField]
	private string wikiPath;

	[SerializeField]
	private string wikiPopupLocKey;

	public string GetDataName()
	{
		return null;
	}

	public string GetVariantName()
	{
		return null;
	}

	public string GetBaseName()
	{
		return null;
	}

	public BaseCharacterData GetBaseData()
	{
		return null;
	}

	public bool GetIsInCompetitiveCollection()
	{
		return false;
	}

	public bool HasSignatureAbility()
	{
		return false;
	}

	public SignatureAbility TakeSignatureAbility()
	{
		return null;
	}

	public void ReturnSignatureAbility()
	{
	}

	public bool HasSuperAbility()
	{
		return false;
	}

	public SignatureAbility TakeSuperAbility()
	{
		return null;
	}

	public void ReturnSuperAbility()
	{
	}

	public int GetFighterScore(RarityTier currentTier, int level, Dictionary<string, SkillTreeNodeStateData> stateData, int[] superAbilityLevels = null, int superAbilityActiveFeature = 0, int prestigeAbilityLevel = 0, float extraFSMultiplierAddition = 0f, SkillTree overrideSkillTree = null)
	{
		return 0;
	}

	public float GetAttackWithModsFloat(Dictionary<string, SkillTreeNodeStateData> stateData, RarityTier currentTier, int level, SkillTree overrideSkillTree = null)
	{
		return 0f;
	}

	public int GetAttackWithMods(Dictionary<string, SkillTreeNodeStateData> stateData, RarityTier currentTier, int level, SkillTree overrideSkillTree = null)
	{
		return 0;
	}

	public float GetLifebarWithModsFloat(Dictionary<string, SkillTreeNodeStateData> stateData, RarityTier currentTier, int level, SkillTree overrideSkillTree = null)
	{
		return 0f;
	}

	public int GetLifebarWithMods(Dictionary<string, SkillTreeNodeStateData> stateData, RarityTier currentTier, int level, SkillTree overrideSkillTree = null)
	{
		return 0;
	}

	public bool IsSignatureAbilityUnlocked(Dictionary<string, SkillTreeNodeStateData> stateData, SkillTree overrideSkillTree = null)
	{
		return false;
	}

	public int[] GetSignatureAbilityLevels(Dictionary<string, SkillTreeNodeStateData> stateData, SkillTree overrideSkillTree = null)
	{
		return null;
	}

	public bool IsSuperAbilityUnlocked(Dictionary<string, SkillTreeNodeStateData> stateData, SkillTree overrideSkillTree = null)
	{
		return false;
	}

	public int[] GetSuperAbilityLevels(Dictionary<string, SkillTreeNodeStateData> stateData, SkillTree overrideSkillTree = null)
	{
		return null;
	}

	public bool IsAdvancedComboUnlocked(Dictionary<string, SkillTreeNodeStateData> stateData, SkillTree overrideSkillTree = null)
	{
		return false;
	}

	public bool IsTripUnlocked(Dictionary<string, SkillTreeNodeStateData> stateData, SkillTree overrideSkillTree = null)
	{
		return false;
	}

	public bool IsChargeUnlocked(Dictionary<string, SkillTreeNodeStateData> stateData, SkillTree overrideSkillTree = null)
	{
		return false;
	}

	public bool IsChargeUpgradeUnlocked(Dictionary<string, SkillTreeNodeStateData> stateData, SkillTree overrideSkillTree = null)
	{
		return false;
	}

	public bool IsAdvancedJuggleUnlocked(Dictionary<string, SkillTreeNodeStateData> stateData, SkillTree overrideSkillTree = null)
	{
		return false;
	}

	public bool IsCharacterAbilityUnlocked(Dictionary<string, SkillTreeNodeStateData> stateData, SkillTree overrideSkillTree = null)
	{
		return false;
	}

	public float CalculateSkillTreeBuff(SkillTreeNodeType nodeType, Dictionary<string, SkillTreeNodeStateData> stateData, SkillTree overrideSkillTree = null)
	{
		return 0f;
	}

	public int GetGearPoints(Dictionary<string, SkillTreeNodeStateData> skillTreeData, RarityTier currentTier, SkillTree overrideSkillTree = null)
	{
		return 0;
	}

	public int GetSlotsCount(Dictionary<string, SkillTreeNodeStateData> skillTreeData, SkillTree overrideSkillTree = null)
	{
		return 0;
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public override bool HasIssues()
	{
		return false;
	}

	public GearData GetStartingGearData()
	{
		return null;
	}

	public Gradient GetBackgroundGradient()
	{
		return null;
	}

	public void SetBaseAttackValue(int index, int value)
	{
	}

	public void SetBaseLifebarValue(int index, int value)
	{
	}

	public string GetWikiPath()
	{
		return null;
	}

	public string GetWikiPopupLocKey()
	{
		return null;
	}

	private BaseScaledValues GetBaseScaledValuesForTier(RarityTier initialTier, RarityTier currentTier)
	{
		return null;
	}
}
