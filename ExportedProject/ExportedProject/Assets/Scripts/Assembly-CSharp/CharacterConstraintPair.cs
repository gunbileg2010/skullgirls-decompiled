using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CharacterConstraintPair : ConstraintPair
{
	[SerializeField]
	private CharacterConstraint characterConstraint;

	private List<BaseCharacterData> baseCharacterConstraints;

	public CharacterConstraintPair()
	{
	}

	public CharacterConstraintPair(Dictionary<string, object> dataDict)
	{
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public float GetAddedProbability()
	{
		return 0f;
	}

	public List<BaseCharacterData> GetBaseCharacterConstraints()
	{
		return null;
	}

	public bool GetIsInverted()
	{
		return false;
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
