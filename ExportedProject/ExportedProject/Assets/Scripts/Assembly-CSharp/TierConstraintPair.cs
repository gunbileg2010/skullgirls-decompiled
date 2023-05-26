using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TierConstraintPair : ConstraintPair
{
	[SerializeField]
	private TierConstraint tierConstraint;

	private List<RarityTier> rarityTiers;

	public TierConstraintPair()
	{
	}

	public TierConstraintPair(Dictionary<string, object> dataDict)
	{
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public List<RarityTier> GetRarityTiers()
	{
		return null;
	}

	public bool GetIsInverted()
	{
		return false;
	}

	public float GetAddedProbability()
	{
		return 0f;
	}

	public override string GetDescription()
	{
		return null;
	}

	public override bool DoCharactersMeetConstraint(List<Character> characters)
	{
		return false;
	}

	public override float GetBonusChanceForCharacters(List<Character> characters)
	{
		return 0f;
	}
}
