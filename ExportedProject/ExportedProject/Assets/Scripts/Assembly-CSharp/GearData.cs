using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class GearData : GuidScriptableObject, IServerUploadable
{
	public enum AIDistance : byte
	{
		ZERO = 0,
		VERY_CLOSE = 1,
		CLOSE = 2,
		MID = 3,
		FAR = 4,
		INFINITE = 5
	}

	[Serializable]
	public struct AIDistanceRange
	{
		public AIDistance min;

		public AIDistance max;
	}

	[SerializeField]
	private int id;

	[SerializeField]
	private string title;

	[SerializeField]
	private bool isInCompetitiveCollection;

	[SerializeField]
	private bool grantAfterFtue;

	[SerializeField]
	private RarityTier tier;

	[SerializeField]
	private GearDamageTier gearDamageTier;

	[SerializeField]
	private bool shouldActivateOnChildrenMidLifeCycle;

	[SerializeField]
	private int gearPointsCost;

	[SerializeField]
	private DynamicResource signatureAbility;

	[SerializeField]
	private PalettizedImage palettizedIcon;

	[SerializeField]
	private int iconOptionSet;

	[SerializeField]
	private float superbarCost;

	[SerializeField]
	private int[] damageIndicatorLevels;

	[SerializeField]
	private float[] attackDamageMultipliers;

	[SerializeField]
	private AIDistanceRange effectiveRange;

	[SerializeField]
	private GearUsageType usageType;

	[NonSerialized]
	private BaseCharacterData baseCharacter;

	public int GetId()
	{
		return 0;
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

	public abstract GearType GetGearType();

	public string GetName(bool localized = true)
	{
		return null;
	}

	public BaseCharacterData GetBaseCharacterData()
	{
		return null;
	}

	public PalettizedImage GetImageResource()
	{
		return null;
	}

	public int GetImageResourceOptionSet()
	{
		return 0;
	}

	public float GetDamageMultiplierForEvolution(int evolution)
	{
		return 0f;
	}

	public int GetDamageIndicatorLevelForEvolution(int evolution)
	{
		return 0;
	}

	public GearDamageTier GetGearDamageTier()
	{
		return default(GearDamageTier);
	}

	public virtual float GetCooldown(int level = 0)
	{
		return 0f;
	}

	public bool GetIsOneTimeUse()
	{
		return false;
	}

	public ZInput GetRelatedInput()
	{
		return null;
	}

	public RarityTier GetTier()
	{
		return default(RarityTier);
	}

	public float GetSuperbarCost()
	{
		return 0f;
	}

	public virtual float GetSuperbarMultiplier()
	{
		return 0f;
	}

	public virtual float GetStartingSuperbar()
	{
		return 0f;
	}

	public virtual int GetStrengthLevel()
	{
		return 0;
	}

	public virtual int GetGearPointsCost()
	{
		return 0;
	}

	public bool ShouldActivateOnChildrenMidLifecycle()
	{
		return false;
	}

	public GearUsageType GetUsageType()
	{
		return default(GearUsageType);
	}

	public bool InEffectiveRange(float xdiff)
	{
		return false;
	}

	public bool IsDuplicateOf(GearData other)
	{
		return false;
	}

	public virtual Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	private float GetValueForAIDistance(AIDistance dist)
	{
		return 0f;
	}
}
